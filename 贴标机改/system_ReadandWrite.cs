using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机改
{
    public class system_ReadandWrite
    {
        Axis_Init AxisParam = new Axis_Init();

        public string mSysPath;
        public string mSysFile;
        public string mImgPath;
        public string mLogPath;
        public string mIniPath;
        public string mIniFile;
        public string mIniName;
        public string mIniStat;
        public bool isSystemOnline;
        public bool isSystemValid;
        public bool isConfigOnline;
        public bool isConfigValid;



        public void DoSystemRead(string filepath)
        {
            mSysPath = Path.GetDirectoryName(filepath) + "\\";
            mSysFile = mSysPath + "轴初始参数.cfg";

            define_system.TConfigReader reader = new define_system.TConfigReader();
            try
            {
                reader.DoOpen(mSysFile);
                AxisParam.DoAxisRead(reader);
                reader.DoClose();
                isSystemOnline = true;
            }
            catch
            {
                isSystemOnline = false;
            }
        }

        public void DoSystemSave()
        {
            define_system.TConfigWriter writer = new define_system.TConfigWriter();
            try
            {
                writer.DoOpen(mSysFile);
                AxisParam.DoAxisSave(writer);
                writer.DoClose();
                isSystemOnline = true;
            }
            catch
            {
                isSystemOnline = false;
            }
        }
    }
}
