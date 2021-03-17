using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贴标机改
{
    public partial class Form_System : Form
    {
        public Form_System()
        {
            InitializeComponent();
        }
        MachineMotion motion = new MachineMotion();
        MachineThread thread = new MachineThread();

        private int AxisPulseX;
        private int AxisPulseY;
        private int[] AxisPulseZ = new int[define_AxisNum.wd_nozzle_count];
        private int[] AxisPulseR = new int[define_AxisNum.wd_nozzle_count];


        private void Form_System_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void Form_System_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoShowAxisPlace();
        }

        private void DoShowAxisPlace()
        {
            if (thread.PlaceX != AxisPulseX)
            {
                AxisPulseX = thread.PlaceX;
                text_axis_xx.Text = thread.PlaceX.ToString("F4");
            }
            if (thread.PlaceY != AxisPulseY)
            {
                AxisPulseY = thread.PlaceY;
                text_axis_yy.Text = thread.PlaceY.ToString("F4");
            }
            for (int head = 0; head < define_AxisNum.wd_nozzle_count; head++)
            {
                if (thread.PlaceZ(head) != AxisPulseZ[head])
                {
                    AxisPulseZ[head] = thread.PlaceZ(head);
                    switch (head)
                    {
                        case 0: text_axis_z1.Text = thread.PlaceZ(head).ToString("F3"); break;
                        case 1: text_axis_z2.Text = thread.PlaceZ(head).ToString("F3"); break;
                        case 2: text_axis_z3.Text = thread.PlaceZ(head).ToString("F3"); break;
                        case 3: text_axis_z4.Text = thread.PlaceZ(head).ToString("F3"); break;
                        case 4: text_axis_z5.Text = thread.PlaceZ(head).ToString("F3"); break;
                    }
                }
                if (thread.PlaceR(head) != AxisPulseR[head])
                {
                    AxisPulseR[head] = thread.PlaceR(head);
                    switch (head)
                    {
                        case 0: text_axis_r1.Text = thread.PlaceR(head).ToString("F3"); break;
                        case 1: text_axis_r2.Text = thread.PlaceR(head).ToString("F3"); break;
                        case 2: text_axis_r3.Text = thread.PlaceR(head).ToString("F3"); break;
                        case 3: text_axis_r4.Text = thread.PlaceR(head).ToString("F3"); break;
                        case 4: text_axis_r5.Text = thread.PlaceR(head).ToString("F3"); break;
                    }
                }
            }

        }


    }
}
