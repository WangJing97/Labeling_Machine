using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机
{
    public class MachineMotion
    {
        public MachineParams pConfig;
        private define_motion.MotionAxis[] pAxis = new define_motion.MotionAxis[define_motion.wd_axis_count];

        private AxisStatus[] sAxis = new AxisStatus[define_motion.wd_axis_count];

        /// <summary>
        /// 初始化
        /// </summary>
        public void DoInit()
        {
            for (int axis = 0; axis < define_motion.wd_axis_count; axis++)
            {
                pAxis[axis] = new define_motion.MotionAxis();
            }
            DoLoadSystemParam();
        }

        public void DoLoadSystemParam()
        {
            MotionParam pParams = pConfig.pMotion;
            for (int axis = 0; axis < define_motion.wd_axis_count; axis++)
            {
                pAxis[axis].DoAssign(pParams.Items[axis]);
                DoSetSpeed(axis, define_motion.ws_speed_slow);
            }
            //当产品文件导入后就导入工作速度的文件
        }

        //控制卡初始化程序
        public bool DoOpen()     //控制卡初始化函数
        {
            short mCardCount = LTDMC.dmc_board_init();//获取卡数量
            isOnline = (mCardCount > 0);

            if (isOnline)
            {
                for (int axis = 0; axis < 8; axis++)
                {
                    //设置脉冲方式
                    LTDMC.dmc_set_pulse_outmode(pAxis[axis].AxisCard, pAxis[axis].AxisCode, 1);
                    //设置减速停止时间ms                   
                    LTDMC.dmc_set_dstp_time(pAxis[axis].AxisCard, pAxis[axis].AxisCode, 50);
                    
                    if (pAxis[axis].isLimit)
                    {
                        //设置 EL 限位信号。目前设置正负限位允许，正负限位低电平有效，正负限位立即停止
                        LTDMC.dmc_set_el_mode(pAxis[axis].AxisCard, pAxis[axis].AxisCode, 1, 0, 0);
                        //设置轴原点信号,低有效
                        LTDMC.dmc_set_home_pin_logic(pAxis[axis].AxisCard, pAxis[axis].AxisCode, 0, 0);
                    }
                    if (pAxis[axis].isServo)
                        LTDMC.dmc_set_alm_mode(pAxis[axis].AxisCard, pAxis[axis].AxisCode, 0, 0, 0);

                    else
                        LTDMC.dmc_set_alm_mode(pAxis[axis].AxisCard, pAxis[axis].AxisCode, 1, 0, 0);
                    DoSoftLimit(axis, false);
                }
            }
            return isOnline;
        }




        #region 轴状态
        public bool isOnline = false;

        public uint IoInput;        //输入
        public uint IoOutput;       //输出


        public bool isAlarm(int axis) { return (sAxis[axis].IoAlarm & pAxis[axis].AxisMask) != 0; }
        public bool isReady(int axis) { return (sAxis[axis].IoReady & pAxis[axis].AxisMask) != 0; }
        public bool isOrgin(int axis) { return (sAxis[axis].IoOrgin & pAxis[axis].AxisMask) != 0; }
        public bool isNegtive(int axis) { return (sAxis[axis].IoNegLt & pAxis[axis].AxisMask) != 0; }
        public bool isPostive(int axis) { return (sAxis[axis].IoPosLt & pAxis[axis].AxisMask) != 0; }


        //轴位置
        public int ppPlaceX { get { return mAxisPlace[define_motion.wd_axis_xx]; } }
        public int ppPlaceY { get { return mAxisPlace[define_motion.wd_axis_yy]; } }
        public int ppPlaceZ(int head) { return mAxisPlace[define_motion.wd_axis_z1 + head]; }
        public int ppPlaceR(int head) { return mAxisPlace[define_motion.wd_axis_r1 + head]; }
        #endregion

        List<AxisStatus> list = new List<AxisStatus>();

        #region 控制信号(状态、输入、输出)
        public void DoState()
        {
            uint rdy = 0;
            uint alm = 0;
            uint plt = 0;
            uint nlt = 0;
            uint org = 0;

            for (int axis = 0; axis < define_motion.wd_axis_count; axis++)
            {
                //位置
                mAxisPlace[axis] = LTDMC.dmc_get_position(pAxis[axis].AxisCard, pAxis[axis].AxisCode);

                //当前状态
                uint mask = pAxis[axis].AxisMask;
                if (LTDMC.dmc_check_done(pAxis[axis].AxisCard, pAxis[axis].AxisCode) != 0) rdy |= mask; //轴已经停止。检测指定轴的运动状态,返回值： 0 指定轴正在运行， 1 指定轴已停止

                //轴运动状态
                uint st = LTDMC.dmc_axis_io_status(pAxis[axis].AxisCard, pAxis[axis].AxisCode);//读取指定轴有关运动信号的状态

                if ((st & LTDMC.state_axis.state_org) > 0) org |= mask;
                if ((st & LTDMC.state_axis.alarm_eln) > 0) nlt |= mask;
                if ((st & LTDMC.state_axis.alarm_elp) > 0) plt |= mask;
                if ((st & LTDMC.state_axis.state_alm) > 0) alm |= mask;

                list.Add(new AxisStatus()
                {
                    IoReady = rdy,
                    IoAlarm = alm,
                    IoOrgin = org,
                    IoNegLt = nlt,
                    IoPosLt = plt
                });

        }

        }
        //控制卡的输入端
        public uint DoInput()
        {
            uint vio1 = LTDMC.dmc_read_inport(0, 0);//读0卡IO输入
            IoInput = ~((vio1 & 0xffff));
            return IoInput;
        }

        #endregion




        private int[] mAxisSpeed = new int[define_motion.wd_axis_count]; //速度
        private int[] mAxisPlace = new int[define_motion.wd_axis_count];  //位置
        public void DoSetSpeed(int axis, int speed)
        {
            mAxisSpeed[axis] = pAxis[axis].GetSpeed(speed);//从预先设定的速度中取出speed速度
        }
        /// <summary>
        /// 设置软限位
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="enable"></param>
        public void DoSoftLimit(int axis, bool enable)
        {
            if (enable & (pAxis[axis].LimitNeg > 0) & (pAxis[axis].LimitPos > 0))
                LTDMC.dmc_set_softlimit(pAxis[axis].AxisCard, pAxis[axis].AxisCode, 1, 0, 1, -pAxis[axis].LimitNeg, pAxis[axis].LimitPos);
            else
                LTDMC.dmc_set_softlimit(pAxis[axis].AxisCard, pAxis[axis].AxisCode, 0, 0, 1, 0, 0);
        }

    }
    public class AxisStatus
    {
        public uint IoReady { get; set; }
        public uint IoAlarm { get; set; }
        public uint IoPosLt { get; set; }
        public uint IoNegLt { get; set; }
        public uint IoOrgin { get; set; }

    }
}
