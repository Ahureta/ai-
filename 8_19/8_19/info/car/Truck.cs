using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_19
{
    internal class Truck : Vehicle
    {
        //public override string Type => "卡车";
        //public override string Type { get; } = "卡车";
        private static readonly string _type = "卡车";  // 静态只读字段，仅一份
        public override string Type => _type;            // 实例属性返回静态字段
        public Truck(double price) : base(price)
        {

        }
    }
}
