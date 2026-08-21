using _8_19.info;
using _8_19.info.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _8_19.Manager
{
    internal class RecordManager
    {
        private string _recordPath = "./RecordManager.json";
        private string _vehiclePath = "./CarManager.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };

        internal string RecordPath
        {
            //RecordPath事先验证文件路径存在,所以后续直接调用不为空的RecordPath就好
            get
            {
                if (!File.Exists(_recordPath)) File.Create(_recordPath).Dispose();
                return _recordPath;
            }
            set
            {
                if (File.Exists(value)) _recordPath = value;
            }
        }
        
        internal string VehiclePath
        {
            //Path事先验证文件路径存在,所以后续直接调用不为空的Path就好
            get
            {
                if (!File.Exists(_vehiclePath)) File.Create(_vehiclePath).Dispose();
                return _vehiclePath;
            }
            set
            {
                if (File.Exists(value)) _vehiclePath = value;
            }
        }

        public void WriteFile(List<Record> list)
        {
            File.WriteAllText(RecordPath, JsonSerializer.Serialize(list, JsonOpt));
        }

        public void WriteFile2(List<Vehicle> list)
        {
            File.WriteAllText(VehiclePath, JsonSerializer.Serialize(list, JsonOpt));
        }

        public (string, List<Record>) ReadFile()
        {
            //由于Path事先验证文件路径存在,所以再加上文件内容验证,所以ReadFile返回值就一定不为空串,但是要注意空列表情况
            string str = File.ReadAllText(RecordPath);
            if (string.IsNullOrEmpty(str)) return ("文件为空", new List<Record>());
            var list = JsonSerializer.Deserialize<List<Record>>(str, JsonOpt) ?? new List<Record>();
            return ("读取成功", list);
        }

        public (string, List<Vehicle>) ReadFile2()
        {
            //由于Path事先验证文件路径存在,所以再加上文件内容验证,所以ReadFile返回值就一定不为空串,但是要注意空列表情况
            string str = File.ReadAllText(VehiclePath);
            if (string.IsNullOrEmpty(str)) return ("文件为空", new List<Vehicle>());
            var list = JsonSerializer.Deserialize<List<Vehicle>>(str, JsonOpt) ?? new List<Vehicle>();
            return ("读取成功", list);
        }


        // 租赁
        public (string,List<Record>) lease(int VehicleId,int UserId)
        {
            // 租赁的逻辑处理
            try
            {
                if (VehicleId <= 0 || UserId <= 0) return ("车辆ID或用户ID不能为空", new List<Record>());
                (_, List<Record> listRecord) = ReadFile();
                (_, List<Vehicle> listVehicle) = ReadFile2();

                int findId = listVehicle.FindIndex(item => item.Id == VehicleId);                
                if (findId >= 0)
                {
                    listVehicle[findId].Status = VehicleStatusEnum.Rented;

                    Record newRecord = new Record(VehicleId, UserId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    listRecord.Add(newRecord);
                    // 写回文件
                    WriteFile(listRecord);
                    WriteFile2(listVehicle);
                    return ("租赁成功", listRecord);
                }
                else
                {
                    return ("车辆不存在", new List<Record>());
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        // 归还
        public (string, List<Record>) ret(int VehicleId)
        {
            // 归还的逻辑处理
            try
            {
                if (VehicleId <= 0) return ("车辆ID不能为空", new List<Record>());
                (_, List<Record> listRecord) = ReadFile();
                (_, List<Vehicle> listVehicle) = ReadFile2();

                int findId = listVehicle.FindIndex(item => item.Id == VehicleId);
                if (findId >= 0)
                {
                    listVehicle[findId].Status = VehicleStatusEnum.Available;

                    int index = listRecord.FindIndex(item => item.VehicleId == VehicleId && item.ReturnTime == null);
                    listRecord[index].ReturnTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    DateTime.TryParse(listRecord[index].LeaseTime, out DateTime leaseTime);
                    listRecord[index].Pay = (DateTime.Now - leaseTime).TotalHours * listVehicle[findId].Price;                    
                    
                    // 写回文件
                    WriteFile(listRecord);
                    WriteFile2(listVehicle);
                    return ("归还成功", listRecord);
                }
                else
                {
                    return ("车辆不存在", new List<Record>());
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        
    }
}
