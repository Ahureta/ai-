using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using _8_19.Enum;
namespace _8_19.Info.Car
{
    internal class Motorcycle : Vehicle
    {
        //public override string Type => "摩托车";
        //public override string Type { get; } = "摩托车";
        private static readonly string _type = "摩托车";  // 静态只读字段，仅一份
        public override string Type => _type;            // 实例属性返回静态字段
        public Motorcycle(double price) : base(price)
        {
            
        }

        [JsonConstructor]
        public Motorcycle(int id, string number, VehicleStatusEnum status, double price) : base(id, number, status, price)
        {

        }
    }
}
