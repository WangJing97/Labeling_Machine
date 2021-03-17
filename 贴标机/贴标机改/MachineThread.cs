using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贴标机改
{
    public class MachineThread
    {
        system_ReadandWrite ReadandWrite = new system_ReadandWrite();
        MachineMotion motion = new MachineMotion();


        public int PlaceX { get { return motion.PlaceX; } }
        public int PlaceY { get { return motion.PlaceY; } }
        public int PlaceZ(int head) { return motion.PlaceZ(head); }
        public int PlaceR(int head) { return motion.PlaceR(head); }


        #region 线程
        private Thread mThread;
        private bool mRuning = false;
        public bool MRuning { get => mRuning; set => mRuning = value; }

        #endregion
        /// <summary>
        /// 初始化
        /// </summary>
        public void DoInit()
        {
            ReadandWrite.DoSystemRead(Application.ExecutablePath);
            mThread = new Thread(new ThreadStart(Do_Thread_Work));
            mThread.Priority = ThreadPriority.Highest;
            mThread.IsBackground = true;

        }
        public void DoOpen()
        {
            motion.DoOpen();
            motion.SetInitAxisSpeed();
            MRuning = true;
            mThread.Start();
        }
        public void DoClose()
        {
            MRuning = false;
            mThread.Abort();
            mThread.Join();
        }


        public void Do_Thread_Work()
        {
            //线程初始化
            while (MRuning)
            {
                Thread.Sleep(50);
                //检测轴的状态
                Do_Status_Input();
            }
        }
        private void Do_Status_Input()
        {
            //设备输入信号

            //检测输入信号变化，包括IO信号和轴信号变化（限位，原点等）
            Do_Signal_Iocard();
            //软件信号设定，如点运行按钮，或停止按钮
        }
        private void Do_Signal_Iocard()
        {
            if (motion.IsOnline)
            {
                motion.DoState();//读信号状态
            }
        }


    }


}

