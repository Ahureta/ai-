using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_19
{
    [JsonDerivedType(typeof(Car), "Car")]
    [JsonDerivedType(typeof(Truck), "Truck")]
    [JsonDerivedType(typeof(Motorcycle), "Motorcycle")]
    internal abstract class Vehicle
    {
        //- 添加车辆（id、车牌号、车辆类型（轿车、卡车、摩托车）、车辆状态（空闲、已租）、每小时的费用）
        //- 查看所有车辆信息
        //- 根据id查看一辆车的信息
        //- 查看所有空闲车辆
        private static int _nextId = LoadNextId();   // 静态计数器
        private static readonly Random _random = new();
       
        protected VehicleStatusEnum _status;
        protected double _price;

        public int Id { get; }
        public string Number { get;}
        public abstract string Type { get; }

        public VehicleStatusEnum Status
        {
            get
            {
                return _status;
            }
            set
            {
                // 检查 value 是否为 carStatusEnum 枚举的有效字符串
                if (!Enum.IsDefined(typeof(VehicleStatusEnum), value))
                {
                    throw new ArgumentException("无效的车辆状态");
                }
                _status = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                //string reg = @"^[1-9]?[0-9]*(\.[0-9]+)?$";
                //Regex.IsMatch(value, reg);
            }
        }


        public Vehicle(double price)
        {
            this.Id = GenerateId();
            this.Number = GetNumber();
            this._status = VehicleStatusEnum.Available;
            this.Price = price;
        }

        private static int GenerateId()
        {
            int id = Interlocked.Increment(ref _nextId);
            SaveNextId(_nextId);        // 持久化到文件
            return id;
        }

        private static int LoadNextId()
        {
            const string path = "./vehicle_counter.txt";
            if (File.Exists(path) && int.TryParse(File.ReadAllText(path).Trim(), out int last))
                return last;
            return 0;
        }

        private static void SaveNextId(int id)
        {
            File.WriteAllText("./vehicle_counter.txt", id.ToString());
        }

        protected string GetNumber()
        {
            //省份简称 + 城市字母 + 5位字符（数字/字母）
            //例：京A·12345、粤B·AB888

            // 省份简称池
            string[] provinces =
            {
                "京", "津", "沪", "渝", "冀", "豫", "云", "辽", "黑", "湘",
                "皖", "鲁", "新", "苏", "浙", "赣", "鄂", "桂", "甘", "晋",
                "蒙", "陕", "吉", "闽", "贵", "粤", "川", "青", "藏", "琼",
                "宁", "台", "港", "澳"
            };
            // 随机选一个 + 随机城市字母（A-Z，避开I和O）+ 5位随机字符
            char[] letters = "ABCDEFGHJKLMNPQRSTUVWXYZ".ToCharArray();
            char[] digits = "0123456789".ToCharArray();

            string province = provinces[_random.Next(provinces.Length)];
            char cityLetter = letters[_random.Next(letters.Length)];                        

            // 后5位：随机字母+数字混合            
            var sb = new StringBuilder(5);
            for (int i = 0; i < 5; i++)
                sb.Append(_random.Next(2) == 0 ? letters[_random.Next(letters.Length)] : digits[_random.Next(digits.Length)]);

            return $"{province}{cityLetter}·{sb}";
        }
    }
}
