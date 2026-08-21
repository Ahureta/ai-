using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8_19
{
    internal class CarManager
    {
        
        //- 查看所有车辆信息
        //- 根据id查看一辆车的信息
        //- 查看所有空闲车辆
        private string _path = "./CarManager.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            PropertyNameCaseInsensitive = true,    //忽略大小写            
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,    // 在JSON序列化的时候中文不变
        };

        internal string Path {
            //Path事先验证文件路径存在,所以后续直接调用不为空的Path就好
            get 
            {
                if (!File.Exists(_path)) File.Create(_path).Dispose();
                return _path;
            }
            set 
            {
                if (File.Exists(value)) _path = value;
            } 
        }

        //JsonSerializerOptions options = new JsonSerializerOptions     //对于反射的使用太耗性能,一般不用.在基类上声明子类的类型就好了
        //{
        //    PropertyNameCaseInsensitive = true,
        //    TypeInfoResolver = new DefaultJsonTypeInfoResolver
        //    {
        //        Modifiers = { AddPolymorphicTypes }
        //    },
        //    WriteIndented = true,
        //    AllowTrailingCommas = true            
        //};

        //static void AddPolymorphicTypes(JsonTypeInfo typeInfo)
        //{
        //    if (typeInfo.Type == typeof(Vehicle))
        //    {
        //        typeInfo.PolymorphismOptions = new JsonPolymorphismOptions
        //        {
        //            DerivedTypes =
        //            {
        //                new JsonDerivedType(typeof(Car), "Car"),
        //                new JsonDerivedType(typeof(Truck), "Truck"),
        //                new JsonDerivedType(typeof(Motorcycle), "Motorcycle")
        //            }
        //        };
        //    }
        //}

        //- 添加车辆（id、车牌号、车辆类型（轿车、卡车、摩托车）、车辆状态（空闲、已租）、每小时的费用）
        public (string, List<Vehicle>) Add(string type, string price) 
        { 
            if (!Enum.TryParse<VehicleTypeEnum>(type, true, out var vehicleType))
                throw new ArgumentException("不支持的车辆类型");
            
            if (!double.TryParse(price, out double priceValue))
                throw new ArgumentException("价格格式不正确");

            Vehicle vehicle = vehicleType switch
            {
                VehicleTypeEnum.Car => new Car(priceValue),
                VehicleTypeEnum.Truck => new Truck(priceValue),
                VehicleTypeEnum.Motorcycle => new Motorcycle(priceValue),
                _ => throw new ArgumentException("不支持的车辆类型"),
            };

            //读取文件
            (_, List<Vehicle> list) = ReadFile();
            //添加逻辑
            list.Add(vehicle);
            //写入文件
            WriteFile(list);

            return ("新增成功", list);
        }

        //public (string error, List<T> data) ReadFile<T>(string path) where T : Vehicle
        public (string, List<Vehicle>) ReadFile() 
        {
            //由于Path事先验证文件路径存在,所以再加上文件内容验证,所以ReadFile返回值就一定不为空串,但是要注意空列表情况
            string str = File.ReadAllText(Path);
            if (string.IsNullOrEmpty(str)) return ("文件为空", new List<Vehicle>());
            var list = JsonSerializer.Deserialize<List<Vehicle>>(str, JsonOpt) ?? new List<Vehicle>();
            return ("读取成功", list);
        }
        public void WriteFile(List<Vehicle> list) 
        {
            File.WriteAllText(Path,JsonSerializer.Serialize(list, JsonOpt));
        }
        internal (string, List<Vehicle>) SearchAll()
        {
            //读取文件
            (_, List<Vehicle> list) = ReadFile();
            return ("查找成功", list);
        }

        internal (string, List<Vehicle>) SearchFree()
        {
            //读取文件
            (_, List<Vehicle> list) = ReadFile();
            //查询空闲车辆的逻辑
            List<Vehicle> list2 = list.FindAll(item => item.Status == VehicleStatusEnum.Available);

            string str = list2.Count == 0?"列表为空,暂无车辆":"读取成功";
            return (str, list2);
        }

        internal (string, List<Vehicle>) SearchOne(int id)
        {
            if (id <= 0) throw new ArgumentException("id必须大于0", nameof(id));

            (_, List<Vehicle> list) = ReadFile();                         
            if (!(list.Count == 0))
            {
                // 这里可以根据id查找并处理对应的Vehicle对象
                Vehicle? vehicle = list?.FirstOrDefault(v => v.Id == id);
                if (vehicle == null)
                {
                    return ($"id:{id}不存在", new List<Vehicle>());
                }
                else
                {
                    return ("查找成功", new List<Vehicle> { vehicle });
                }
            }
            else
            {
                return ("暂无车辆数据", new List<Vehicle>());
            }
        }
    }
}
