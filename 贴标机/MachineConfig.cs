using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贴标机
{
    /// <summary>
    /// 工作文件配置
    /// </summary>
    public class MachineConfig
    {
        public MachineParams pParams = new MachineParams();


        public void DoOpen()
        {
            DoLoadSystem();
        }

        private void DoLoadSystem()
        {
            pParams.DoSystemRead(Application.ExecutablePath);

        }
    }
}
