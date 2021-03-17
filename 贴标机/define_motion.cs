using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机
{
    public static class define_motion
    {
        public const int wd_axis_count = 10;

        public const int wd_axis_xx = 0; //X轴
        public const int wd_axis_yy = 1; //Y轴


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


        /// <summary>
        /// 程序交互用
        /// </summary>
        public class MotionItem
        {
            public ushort AxisCard; //卡号
            public ushort AxisCode; //轴号
            public uint AxisMask; 
            //public double AxisScale;
            public int SlowSpeed;      //慢速速度
            public int HomeSpeed;      //原点速度
            public int FastSpeed;      //原点速度
            public int WorkSpeed;      //正常速度
            public int UserSpeed;      //工作速度
            public int AccTime;        //加速度
            public bool isLimit;
            public bool isServo;
            public int LimitPos;       //软限位*2
            public int LimitNeg;
            public int OrginOff;
            public int OrginMov;

            public int GetSpeedPul(int speed)
            {
                switch (speed)
                {
                    case define_motion.ws_speed_slow: return GetPP(SlowSpeed);
                    case define_motion.ws_speed_home: return GetPP(HomeSpeed);
                    case define_motion.ws_speed_fast: return GetPP(FastSpeed);
                    case define_motion.ws_speed_work: return GetPP(WorkSpeed);
                        //case define_motion.ws_speed_user: return GetPP(UserSpeed); 
                }
                return speed;
            }
            public int GetPP(double mm)
            {
                return (int)Math.Round(mm);
            }
            public int GetLimitNeg()
            {
                if (LimitNeg != 0)
                    return (int)LimitNeg;
                else
                if (isLimit)
                    return (int)(OrginMov + OrginOff);
                else
                    return int.MinValue;
            }
            public int GetLimitPos()
            {
                if (LimitPos != 0)
                    return (int)LimitPos;
                else
                    return int.MaxValue;
            }
            public int GetOrginOff()
            {
                return (int)OrginOff;
            }
            public int GetOrginMov()
            {
                return (int)OrginMov;
            }
        }

        /// <summary>
        /// 与控制卡交互用
        /// </summary>
        public class MotionAxis
        {
            public ushort AxisCard; // 控制卡
            public ushort AxisCode; // 卡上的轴序号
            public uint AxisMask;   //用于轴编码的二进制占位
            //public double AxisScale;
            public int SlowSpeed;      //慢速速度
            public int HomeSpeed;      //原点速度
            public int FastSpeed;      //原点速度
            public int WorkSpeed;      //正常速度
            public double AccTime;        //加速度
            public bool isLimit;
            public bool isServo;
            public int LimitPos;       //软限位*2
            public int LimitNeg;
            public int OrginOff;
            public int OrginMov;

            public int GetSpeed(int speed)
            {
                switch (speed)
                {
                    case define_motion.ws_speed_slow: return SlowSpeed;
                    case define_motion.ws_speed_home: return HomeSpeed;
                    case define_motion.ws_speed_fast: return FastSpeed;
                    case define_motion.ws_speed_work: return WorkSpeed;
                }
                return speed;
            }

            /// <summary>
            /// 判断参数的合法性
            /// </summary>
            /// <param name="item"></param>
            public void DoAssign(MotionItem item)
            {
                this.AxisCard = item.AxisCard;
                this.AxisCode = item.AxisCode;
                this.AxisMask = item.AxisMask;// 用于轴编码的二进制占位
                //this.AxisScale = item.AxisScale;
                this.SlowSpeed = item.GetSpeedPul(define_motion.ws_speed_slow);
                this.HomeSpeed = item.GetSpeedPul(define_motion.ws_speed_home);
                this.FastSpeed = item.GetSpeedPul(define_motion.ws_speed_fast);
                this.WorkSpeed = item.GetSpeedPul(define_motion.ws_speed_work);
                this.isLimit = item.isLimit;
                this.isServo = item.isServo;
                this.LimitNeg = item.GetLimitNeg();
                this.LimitPos = item.GetLimitPos();
                this.OrginMov = item.GetOrginMov();
                this.OrginOff = item.GetOrginOff();
                this.AccTime = item.AccTime * 0.001;

            }


        }
    }


}
