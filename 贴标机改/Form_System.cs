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
        /// <summary>
        /// 显示轴的实时位置
        /// </summary>
        private void DoShowAxisPlace()
        {
            if (motion.PlaceX != AxisPulseX)
            {
                AxisPulseX = motion.PlaceX;
                text_axis_xx.Text = motion.PlaceX.ToString("F4");
            }
            if (motion.PlaceY != AxisPulseY)
            {
                AxisPulseY = motion.PlaceY;
                text_axis_yy.Text = motion.PlaceY.ToString("F4");
            }
            for (int head = 0; head < define_AxisNum.wd_nozzle_count; head++)
            {
                if (motion.PlaceZ(head) != AxisPulseZ[head])
                {
                    AxisPulseZ[head] = motion.PlaceZ(head);
                    switch (head)
                    {
                        case 0: text_axis_z1.Text = motion.PlaceZ(head).ToString("F3"); break;
                        case 1: text_axis_z2.Text = motion.PlaceZ(head).ToString("F3"); break;
                        case 2: text_axis_z3.Text = motion.PlaceZ(head).ToString("F3"); break;
                        case 3: text_axis_z4.Text = motion.PlaceZ(head).ToString("F3"); break;
                        case 4: text_axis_z5.Text = motion.PlaceZ(head).ToString("F3"); break;
                    }
                }
                if (motion.PlaceR(head) != AxisPulseR[head])
                {
                    AxisPulseR[head] = motion.PlaceR(head);
                    switch (head)
                    {
                        case 0: text_axis_r1.Text = motion.PlaceR(head).ToString("F3"); break;
                        case 1: text_axis_r2.Text = motion.PlaceR(head).ToString("F3"); break;
                        case 2: text_axis_r3.Text = motion.PlaceR(head).ToString("F3"); break;
                        case 3: text_axis_r4.Text = motion.PlaceR(head).ToString("F3"); break;
                        case 4: text_axis_r5.Text = motion.PlaceR(head).ToString("F3"); break;
                    }
                }
            }

        }

        private static readonly int[] aposarray = { 100, 10, 1, 0 };
        private void button_move_xy_Click(object sender, EventArgs e)
        {
            if (!motion.IsAllAxisReady) return;
            int sele = int.Parse((string)group_speed.Tag);
            if (sele >= 2) 
            {
                int dist = aposarray[sele - 2];
                if (sele == 5) dist = (int)text_radio_by.Value;
                int axis;
                switch (((Button)sender).TabIndex)
                {
                    case 1:
                    case 2: axis = define_AxisNum.wd_axis_xx; break;
                    case 3:
                    case 4: axis = define_AxisNum.wd_axis_yy; break;
                    case 5:
                    case 6: axis = define_AxisNum.wd_axis_z1 + text_head_index.SelectedIndex; break;
                    case 7:
                    case 8: axis = define_AxisNum.wd_axis_r1 + text_head_index.SelectedIndex; break;
                    default: return;
                }
                //判断正负
                bool away = ((Button)sender).TabIndex % 2 == 0;

                if (Math.Abs(dist) < 10)
                    motion.DoSetSpeed(axis, define_AxisNum.ws_speed_slow);
                else
                    motion.DoSetSpeed(axis, define_AxisNum.ws_speed_fast);
                //偶数正，奇数负
                if (away)
                    motion.DoAxisMoveByMM(axis, dist);
                else
                    motion.DoAxisMoveByMM(axis, -dist);

            }

        }
        private void button_move_axis_MouseDown(object sender, MouseEventArgs e)
        {
            //1123
            if (!motion.IsAllAxisReady) return;
            //任务停止检测
            //if (!mIpc.isTaskReady) return;
            int sele = int.Parse((string)group_speed.Tag);
            if (sele < 2)
            {
                int axis;
                switch (((Button)sender).TabIndex)
                {
                    case 1:
                    case 2: axis = define_AxisNum.wd_axis_xx; break;
                    case 3:
                    case 4: axis = define_AxisNum.wd_axis_yy; break;
                    case 5:
                    case 6: axis = define_AxisNum.wd_axis_z1 + text_head_index.SelectedIndex; break;
                    case 7:
                    case 8: axis = define_AxisNum.wd_axis_r1 + text_head_index.SelectedIndex; break;
                    default: return;
                }
                bool away = ((Button)sender).TabIndex % 2 == 0;
                if (sele == 0)
                    motion.DoSetSpeed(axis, define_AxisNum.ws_speed_slow);
                else
                    motion.DoSetSpeed(axis, define_AxisNum.ws_speed_fast);
                motion.DoAxisMoveJog(axis, away);
            }

        }

        private void button_move_axis_MouseUp(object sender, MouseEventArgs e)
        {
            int sele = int.Parse((string)group_speed.Tag);
            if (sele >= 2) return;
            if (motion.IsAllAxisReady)
                motion.DoFastStopAll();
        }
        private void button_StopAxis_Click(object sender, MouseEventArgs e)
        {
            motion.DoFastStopAll();
        }
        private void radio_Click(object sender, EventArgs e)
        {
            int sele = ((RadioButton)sender).TabIndex;
            group_speed.Tag = sele.ToString();
            text_radio_by.Enabled = (sele == 5);
            if (sele == 5)
            {
                text_radio_by.Select();
            }
        }

    }
}
