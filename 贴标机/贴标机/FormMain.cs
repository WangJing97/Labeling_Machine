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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public MachineThread machineThread;

        public Form_System mFormSystem;

        /// <summary>
        /// 窗体加载的时候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            machineThread = new MachineThread();
            machineThread.DoInit();
        }
        /// <summary>
        /// 窗体显示的时候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Shown(object sender, EventArgs e)
        {
            machineThread.DoOpen();
        }

        private void btn_system_Click(object sender, EventArgs e)
        {
            if (mFormSystem == null) mFormSystem = (Form_System)LoadMdiChild(typeof(Form_System));
            ShowMdiChild(mFormSystem);
        }


        private Form LoadMdiChild(Type formclass)
        {
            Form nForm = null;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == formclass)
                {
                    nForm = frm;
                    break;
                }
            }
            if (nForm == null)
            {
                nForm = (Form)(Activator.CreateInstance(formclass));
                //nForm.Owner = this;
                nForm.MdiParent = this;
                nForm.Left = 0;
                nForm.Top = 0;
                nForm.Dock = System.Windows.Forms.DockStyle.Fill;
                nForm.FormBorderStyle = FormBorderStyle.None;
                nForm.MaximizeBox = false;
                nForm.MinimizeBox = false;
                nForm.ControlBox = false;
            }
            return nForm;
        }
        private void ShowMdiChild(Form formobject)
        {
            if (this.ActiveMdiChild == formobject) return;
            //if (DoCheckActiveForm())
            {
                formobject.Show();
                formobject.BringToFront();
                formobject.Activate();
            }
        }
        //public bool DoCheckActiveForm()
        //{
        //    if (this.ActiveMdiChild is Form_Config)
        //    {
        //        return mFormConfig.DoEventLeave();
        //    }
        //    return true;
        //}


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            machineThread.DoClose();
        }
    }
}
