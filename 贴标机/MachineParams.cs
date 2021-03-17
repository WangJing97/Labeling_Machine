using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贴标机
{
    public class MachineParams
    {
        public string mSysPath;
        public string mSysFile;

        //判断产品配置文件时候以及写入
        public bool isConfigOnline;


        public MotionParam pMotion = new MotionParam();


        public void DoSystemRead(string filepath)
        {
            mSysPath = Path.GetDirectoryName(filepath) + "\\";
            mSysFile = mSysPath + "系统基础参数.cfg";
            define_system.TConfigReader reader = new define_system.TConfigReader();
            try
            {
                reader.DoOpen(mSysFile);
                pMotion.DoSystemRead(reader);
                reader.DoClose();
            }
            catch 
            {
                //提醒
                MessageBox.Show("配置文件读取错误");
            }

        }
    }
}
