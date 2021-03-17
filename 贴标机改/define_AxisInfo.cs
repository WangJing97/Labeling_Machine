using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机改
{
    public class define_AxisInfo
    {
        public ushort AxisCard { get; set; }
        public ushort AxisCode { get; set; }
        public uint AxisMask { get; set; }
        public int AxisScale { get; set; }
        public int SlowSpeed { get; set; }
        public int HomeSpeed { get; set; }
        public int FastSpeed { get; set; }
        public int WorkSpeed { get; set; }
        public int UserSpeed { get; set; }
        public double AccTime { get; set; }
        public bool isLimit { get; set; }
        public bool isServo { get; set; }
        public int LimitPos { get; set; }
        public int LimitNeg { get; set; }
        public int OrginOff { get; set; }
        public int OrginMov { get; set; }
    }
}
