using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机改
{
    public static class define_AxisNum
    {
        public const int wd_axis_count = 10;

        public const int wd_axis_xx = 0; //X轴
        public const int wd_axis_yy = 1; //Y轴

        public const int wd_nozzle_count = 3;

        public const int wd_axis_z1 = 2; //Z1轴-
        public const int wd_axis_z2 = 3; //Z1轴-
        public const int wd_axis_z3 = 4; //Z1轴-


        public const int wd_axis_r1 = 5; //R轴
        public const int wd_axis_r2 = 6; //R轴
        public const int wd_axis_r3 = 7; //R轴

        public const int wd_axis_zd = 8; //载道
        public const int wd_axis_bq = 9; //载道

        //轴位码
        public const uint wc_axis_xx = 0x0001; //X轴
        public const uint wc_axis_yy = 0x0002; //Y轴

        public const uint wc_axis_z1 = 0x0004; //Z1轴-       
        public const uint wc_axis_z2 = 0x0008; //Z2轴-
        public const uint wc_axis_z3 = 0x0010; //Z1轴-

        public const uint wc_axis_r1 = 0x0020; //R1轴-
        public const uint wc_axis_r2 = 0x0040; //R2轴-
        public const uint wc_axis_r3 = 0x0080; //R1轴-

        public const uint wc_axis_z4 = 0x0100; //载道
        public const uint wc_axis_z5 = 0x0200; //载道

        //轴速度
        public const int ws_speed_slow = 0;
        public const int ws_speed_home = 1;
        public const int ws_speed_fast = 2;
        public const int ws_speed_work = 3;
    }
}
