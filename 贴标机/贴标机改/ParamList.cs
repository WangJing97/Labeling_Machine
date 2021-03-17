using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机改
{
    public class ParamList
    {
        private static readonly Lazy<ParamList> lazy = new Lazy<ParamList>(() => new ParamList());

        public static ParamList Instance { get { return lazy.Value; } }

        private ParamList() { }

        List<define_AxisInfo> AxisInfoList = new List<define_AxisInfo>();
        List<define_AxisState> AxisStateList = new List<define_AxisState>();

        int[] AxisPlace = new int[define_AxisNum.wd_axis_count];

        int[] AxisSpeed = new int[define_AxisNum.wd_axis_count];

        public List<define_AxisInfo> returnAxisInfoList()
        {
            return AxisInfoList;
        }


        public List<define_AxisState> returnAxisStateList()
        {
            return AxisStateList;
        }

        public int[] returnAxisPlace()
        {
            return AxisPlace;
        }
        public int[] returnAxisSpeed()
        {
            return AxisSpeed;
        }

    }
}