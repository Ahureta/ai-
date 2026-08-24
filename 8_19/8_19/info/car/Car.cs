using System.Text.Json.Serialization;
using _8_19.Enum;

namespace _8_19.Info.Car
{
    internal class Car : Vehicle
    {
        //public override string Type => "轿车";

        //public override string Type { get; } = "轿车";
        private static readonly string _type = "轿车";  // 静态只读字段，仅一份
        public override string Type => _type;            // 实例属性返回静态字段
        public Car(double price) : base(price)
        {
            
        }

        [JsonConstructor]
        public Car(int id, string number, VehicleStatusEnum status, double price) : base(id, number, status, price)
        {

        }
    }
}
