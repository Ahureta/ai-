using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.DoMain.Entities
{
    public class ArmPosition
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float RHead { get; set; }

        public ArmPosition() { }

        public ArmPosition(float x, float y, float z = 0, float rHead = 0)
        {
            X = x; Y = y; Z = z; RHead = rHead;
        }
    }
}
