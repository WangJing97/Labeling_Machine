using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机改
{
    public class MachineMotion
    {
        List<define_AxisInfo> AxisInfoList = ParamList.Instance.returnAxisInfoList();
        List<define_AxisState> AxisStateList = ParamList.Instance.returnAxisStateList();



        private int[] AxisSpeed = ParamList.Instance.returnAxisSpeed(); //速度
        private int[] AxisPlace = ParamList.Instance.returnAxisPlace();


        private bool isOnline = false;
        public bool IsOnline { get { return isOnline; } }

        private bool isAllAxisReady = false;
        public bool IsAllAxisReady
        { 
            get
            {
                foreach (define_AxisState AxisState in AxisStateList)
                {
                    AxisState.isReady = true ? isAllAxisReady = true : isAllAxisReady = false;
                }
                return isAllAxisReady;
            } 
        }


        public int PlaceX { get { return AxisPlace[define_AxisNum.wd_axis_xx]; } }
        public int PlaceY { get { return AxisPlace[define_AxisNum.wd_axis_yy]; } }
        public int PlaceZ(int head) { return AxisPlace[define_AxisNum.wd_axis_z1 + head]; }
        public int PlaceR(int head) { return AxisPlace[define_AxisNum.wd_axis_r1 + head]; }



        /// <summary>
        /// 初始化轴
        /// </summary>
        /// <returns></returns>
        public bool DoOpen()
        {
            short mCardCount = LTDMC.dmc_board_init();//获取卡数量
            isOnline = (mCardCount > 0);

            if (isOnline)
            {
                for (int axis = 0; axis < define_AxisNum.wd_axis_count; axis++)
                {
                    //设置脉冲方式
                    LTDMC.dmc_set_pulse_outmode(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 1);
                    //设置减速停止时间ms                   
                    LTDMC.dmc_set_dstp_time(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 50);

                    if (AxisInfoList[axis].isLimit)
                    {
                        //设置 EL 限位信号。目前设置正负限位允许，正负限位低电平有效，正负限位立即停止
                        LTDMC.dmc_set_el_mode(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 1, 0, 0);
                        //设置轴原点信号,低有效
                        LTDMC.dmc_set_home_pin_logic(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 0, 0);
                    }
                    if (AxisInfoList[axis].isServo)
                    {
                        LTDMC.dmc_set_alm_mode(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 0, 0, 0);
                        LTDMC.dmc_write_sevon_pin(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 0);
                    }
                    else
                    {
                        LTDMC.dmc_set_alm_mode(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 1, 0, 0);
                        LTDMC.dmc_write_sevon_pin(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 1);
                    }
                    DoSoftLimit(axis, false);
                }
            }
            return isOnline;

        }
        /// <summary>
        /// 读取轴状态
        /// </summary>
        public void DoState()
        {
            bool rdy = false;
            bool alm = false;
            bool plt = false;
            bool nlt = false;
            bool org = false;
            //int place = 0;
            AxisStateList.Clear();
            for (int axis = 0; axis < define_AxisNum.wd_axis_count; axis++)
            {
                //位置
                AxisPlace[axis] = LTDMC.dmc_get_position(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode);

                //当前状态
                //轴已经停止。检测指定轴的运动状态,返回值： 0 指定轴正在运行， 1 指定轴已停止
                if (LTDMC.dmc_check_done(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode) == 0) rdy = true;
                else rdy = false;

                //轴运动状态
                uint st = LTDMC.dmc_axis_io_status(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode);//读取指定轴有关运动信号的状态

                if ((st & LTDMC.state_axis.state_org) > 0) org = true;
                else org = false;
                if ((st & LTDMC.state_axis.alarm_eln) > 0) nlt = true;
                else nlt = false;
                if ((st & LTDMC.state_axis.alarm_elp) > 0) plt = true;
                else plt = false;
                if ((st & LTDMC.state_axis.state_alm) > 0) alm = true;
                else alm = false;

                AxisStateList.Add(new define_AxisState()
                {
                    isReady = rdy,
                    isAlarm = alm,
                    isOrgin = org,
                    isNegLt = nlt,
                    isPosLt = plt,
                }) ;
            }

        }

        public void DoSoftLimit(int axis, bool enable)
        {
            if (enable & (AxisInfoList[axis].LimitNeg > 0) & (AxisInfoList[axis].LimitPos > 0))
                LTDMC.dmc_set_softlimit(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 1, 0, 1, -AxisInfoList[axis].LimitNeg, AxisInfoList[axis].LimitPos);
            else
                LTDMC.dmc_set_softlimit(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 0, 0, 1, 0, 0);
        }


        public void SetInitAxisSpeed()
        {
            for (int axis = 0; axis < define_AxisNum.wd_axis_count; axis++)
            {
                DoSetSpeed(axis, define_AxisNum.ws_speed_slow);
            }
        }
        public void DoSetSpeed(int axis, int speed)
        {
            AxisSpeed[axis] = GetSpeed(axis, speed);
        }


        private int GetSpeed(int axis, int speed)
        {
            switch (speed)
            {
                case define_AxisNum.ws_speed_slow: return AxisInfoList[axis].SlowSpeed * AxisInfoList[axis].AxisScale;
                case define_AxisNum.ws_speed_home: return AxisInfoList[axis].HomeSpeed * AxisInfoList[axis].AxisScale;
                case define_AxisNum.ws_speed_fast: return AxisInfoList[axis].FastSpeed * AxisInfoList[axis].AxisScale;
                case define_AxisNum.ws_speed_work: return AxisInfoList[axis].WorkSpeed * AxisInfoList[axis].AxisScale;
                default: return AxisInfoList[axis].SlowSpeed * AxisInfoList[axis].AxisScale;
            }

        }

        #region 控制运动
        //速度
        /// <summary>
        /// 定长运动，相对
        /// </summary>
        public void DoAxisMoveByMM(int axis, int pos)
        {
            if (AxisStateList[axis].isAlarm) return;
            LTDMC.dmc_set_profile(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 100, AxisSpeed[axis], AxisInfoList[axis].AccTime, AxisInfoList[axis].AccTime, 0);
            LTDMC.dmc_pmove(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, pos, 0);

        }
        public void DoAxisMoveJog(int axis, bool nway)
        {
            //正方向true
            if (AxisStateList[axis].isAlarm) return;
            LTDMC.dmc_set_profile(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 100, AxisSpeed[axis], AxisInfoList[axis].AccTime, AxisInfoList[axis].AccTime, 0);
            if (nway)
                LTDMC.dmc_vmove(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 1);
            else
                LTDMC.dmc_vmove(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 0);

        }

        public void DoSlowStopAll()
        {
            for (short axis = 0; axis < define_AxisNum.wd_axis_count; axis++)
            {
                DoSlowStop(axis);
            }
        }


        //慢停
        public void DoSlowStop(int axis)
        {
            LTDMC.dmc_stop(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 0);
        }
        //快停
        public void DoFastStop(int axis)
        {
            LTDMC.dmc_stop(AxisInfoList[axis].AxisCard, AxisInfoList[axis].AxisCode, 1);
        }
        #endregion



    }
}
