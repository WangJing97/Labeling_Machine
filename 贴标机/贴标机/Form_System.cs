using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贴标机
{
    public partial class Form_System : Form
    {
        #region 坐标变量定义
        private int mAxisPulseX;
        private int mAxisPulseY;
        private int[] mAxisPulseZ = new int[define_nozzle.wd_nozzle_count];
        private int[] mAxisPulseR = new int[define_nozzle.wd_nozzle_count];
        #endregion
        private MachineThread machineThread;
        private FormMain FormMain;

        private define_property.PropertySystem pParams = new define_property.PropertySystem();

        public Form_System()
        {
            InitializeComponent();
        }

        private void Form_System_Load(object sender, EventArgs e)
        {
            //machineThread = ((FormMain)(this.MdiParent)).machineThread;
        }
        private void Form_System_Shown(object sender, EventArgs e)
        {
            DoLoadParamAll();
            listgrid_params.SelectedObject = pParams;
        }
        private void DoLoadParamAll()
        {
            //pParams.DoGetParams(machineThread.pParams);
            listgrid_params.Refresh();
        }


        /// <summary>
        /// 显示轴位置
        /// </summary>
        private void DoShowAxisPlace()
        {
            if (machineThread.ppPlaceX != mAxisPulseX)
            {
                mAxisPulseX = machineThread.ppPlaceX;
                text_axis_xx.Text = machineThread.ppPlaceX.ToString("F4");
            }
            if (machineThread.ppPlaceY != mAxisPulseY)
            {
                mAxisPulseY = machineThread.ppPlaceY;
                text_axis_yy.Text = machineThread.ppPlaceY.ToString("F4");
            }
            for (int head = 0; head < define_nozzle.wd_nozzle_count; head++)
            {
                if (machineThread.ppPlaceZ(head) != mAxisPulseZ[head])
                {
                    mAxisPulseZ[head] = machineThread.ppPlaceZ(head);
                    switch (head)
                    {
                        case 0: text_axis_z1.Text = machineThread.ppPlaceZ(head).ToString("F3"); break;
                        case 1: text_axis_z2.Text = machineThread.ppPlaceZ(head).ToString("F3"); break;
                        case 2: text_axis_z3.Text = machineThread.ppPlaceZ(head).ToString("F3"); break;
                        case 3: text_axis_z4.Text = machineThread.ppPlaceZ(head).ToString("F3"); break;
                        case 4: text_axis_z5.Text = machineThread.ppPlaceZ(head).ToString("F3"); break;
                    }
                }
                if (machineThread.ppPlaceR(head) != mAxisPulseR[head])
                {
                    mAxisPulseR[head] = machineThread.ppPlaceR(head);
                    switch (head)
                    {
                        case 0: text_axis_r1.Text = machineThread.ppPlaceR(head).ToString("F3"); break;
                        case 1: text_axis_r2.Text = machineThread.ppPlaceR(head).ToString("F3"); break;
                        case 2: text_axis_r3.Text = machineThread.ppPlaceR(head).ToString("F3"); break;
                        case 3: text_axis_r4.Text = machineThread.ppPlaceR(head).ToString("F3"); break;
                        case 4: text_axis_r5.Text = machineThread.ppPlaceR(head).ToString("F3"); break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoShowAxisPlace();
        }
        /// <summary>
        /// 窗体激活时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_System_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        /// <summary>
        /// 关闭窗口时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_System_Deactivate(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }


    }
}
