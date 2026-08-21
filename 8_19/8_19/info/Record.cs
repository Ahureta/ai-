using _8_19.info.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_19.info
{
    internal class Record
    {
        //- 添加租车记录（id、车辆id、客户id、租赁时间）
        //- 添加还车记录（id、车辆id、客户id、归还时间、支付金额）
        private static int _nextId = LoadNextId();   // 静态计数器

        private string _leaseTime;
        private string _returnTime;
        private double _pay;

        public int Id { get; }
        public int VehicleId { get; }
        public int UserId { get; }
        public string LeaseTime
        {
            get
            { 
                return _leaseTime;
            } 
            set
            { 
                _leaseTime = value; 
            }
        }   //租赁时间
        public string ReturnTime
        {
            get
            {
                return _returnTime;
            }
            set
            {
                _returnTime = value;
            }
        }   //归还时间
        public double Pay
        {
            get
            {
                return _pay;
            }
            set
            {
                _pay = value;
            }
        }

        public Record(int vehicleId, int userId, string leaseTime)
        {
            Id = GenerateId();
            VehicleId = vehicleId;
            UserId = userId;
            LeaseTime = leaseTime;
        }

        protected static string IdFilePath = "./recordId.txt";
        private static int GenerateId()
        {
            int id = Interlocked.Increment(ref _nextId);
            SaveNextId(_nextId);        // 持久化到文件
            return id;
        }

        private static int LoadNextId()
        {
            if (File.Exists(IdFilePath) && int.TryParse(File.ReadAllText(IdFilePath).Trim(), out int last))
                return last;
            return 0;
        }

        private static void SaveNextId(int id)
        {
            File.WriteAllText(IdFilePath, id.ToString());
        }
    }
}
