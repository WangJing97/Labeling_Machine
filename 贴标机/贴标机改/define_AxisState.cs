using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机改
{
    public class define_AxisState
    {
        //public int Place { get; set; }
        public bool isReady { get; set; }
        public bool isAlarm { get; set; }
        public bool isPosLt { get; set; }
        public bool isNegLt { get; set; }
        public bool isOrgin { get; set; }
    }
}
