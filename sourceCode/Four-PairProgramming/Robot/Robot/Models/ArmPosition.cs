using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Models
{
    public class ArmPosition
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float RHead { get; set; }

        public ArmPosition() { }

        public ArmPosition(float x, float y, float z, float rHead = 0)
        {
            X = x;
            Y = y;
            Z = z;
            RHead = rHead;
        }
    }
}
