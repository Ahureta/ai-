using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_19
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
    }
}
