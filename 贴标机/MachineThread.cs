using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 贴标机
{
    /// <summary>
    /// 工作线程
    /// </summary>
    public class MachineThread
    {
        public MachineConfig mConfig = new MachineConfig();
        public MachineMotion mMotion = new MachineMotion();


        public MachineParams pParams;
        #region 线程
        private Thread mThread;
        private bool mRuning = false;
        private ManualResetEvent mEvent = new ManualResetEvent(false);

        #endregion


        #region 位置信息
        public int ppPlaceX { get { return mMotion.ppPlaceX; } }
        public int ppPlaceY { get { return mMotion.ppPlaceY; } }
        public int ppPlaceZ(int head) { return mMotion.ppPlaceZ(head); }
        public int ppPlaceR(int head) { return mMotion.ppPlaceR(head); }
        #endregion



        public void DoInit()
        {
            //开启线程 
            mThread = new Thread(new ThreadStart(Do_Thread_Work));
            mThread.Priority = ThreadPriority.Highest;

            pParams = mConfig.pParams;
            mConfig.DoOpen();

            mMotion.pConfig = pParams;
            mMotion.DoInit();
        }
        public void DoOpen()
        {
            mMotion.DoOpen(); //控制卡初始化函数,轴运动方式、限位等设定
            mRuning = true;
            mThread.Start();
        }

        public void DoClose()
        {
            mRuning = false;
            mThread.Abort();
            mThread.Join();
        }

        /// <summary>
        /// 线程工作
        /// </summary>
        public void Do_Thread_Work()
        {
            //线程初始化
            while (mRuning)
            {
                Thread.Sleep(50);
                Do_Status_Input();//检测各种信号(设备信号、IO输入信号、软件命令信号)
            }
        }

        private void Do_Status_Input()
        {
            //设备输入信号

            //检测输入信号变化，包括IO信号和轴信号变化（限位，原点等）
            Do_Signal_Iocard();
            //软件信号设定，如点运行按钮，或停止按钮

        }
        //控制卡的信号
        private void Do_Signal_Iocard()
        {
            //if (mMotion.isOnline)
            {
                mMotion.DoState();//读信号状态
                mMotion.DoInput();
            }
        }
    }
}
