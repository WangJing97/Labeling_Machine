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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        MachineThread mThread = new MachineThread();

        private void btn_system_Click(object sender, EventArgs e)
        {
            this.CloseFrom();
            Form_System formSystem = new Form_System();
            this.OpenFrom(formSystem);
        }

        private void OpenFrom(Form objForm)
        {
            //将当前子窗体设置成非顶级控件
            objForm.TopLevel = false;
            //设置窗体最大化
            objForm.WindowState = FormWindowState.Maximized;
            //去掉窗体边框
            objForm.FormBorderStyle = FormBorderStyle.None;
            //指定当前子窗体显示的容器
            objForm.Parent = this.panelForm;
            //显示窗体
            objForm.Show();
        }

        private void CloseFrom()
        {
            foreach (Control item in this.panelForm.Controls)
            {
                if (item is Form objControl)
                {

                    objControl.Close();
                    this.panelForm.Controls.Remove(item);
                }

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            mThread.DoInit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            mThread.DoClose();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            mThread.DoOpen();
        }
    }
}
