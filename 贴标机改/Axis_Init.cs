using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机改
{
    public class Axis_Init
    {
        private const string wp_axis_xsafe = "X轴安全位置";
        private const string wp_axis_ysafe = "Y轴安全位置";
        private const string wp_axis_zsafe = "Z轴安全位置";
        private const string wp_axis_dcc = "轴减速时间";
        private const string wp_axis_type = "轴复位类型";


        private const string wp_axis_card = "轴卡号";
        private const string wp_axis_code = "轴编号";
        private const string wp_axis_scale = "轴比例尺";
        private const string wp_axis_limit = "轴限位";
        private const string wp_axis_servo = "轴伺服";
        private const string wp_axis_slow = "轴慢动速度";
        private const string wp_axis_home = "轴复位速度";
        private const string wp_axis_fast = "轴快动速度";
        private const string wp_axis_work = "轴工作速度";
        private const string wp_axis_acc = "轴加速时间";
        private const string wp_axis_ppneg = "轴负限位置";
        private const string wp_axis_pppos = "轴正限位置";
        private const string wp_axis_ogoff = "轴原点偏移";
        private const string wp_axis_ormov = "轴原点回退";


        List<define_AxisInfo> AxisInfoList = ParamList.Instance.returnAxisInfoList();

        /// <summary>
        /// 轴数据初始化
        /// </summary>
        /// <param name="reader"></param>
        public void DoAxisRead(define_system.TConfigReader reader)
        {
            for (int axis = 0; axis < define_AxisNum.wd_axis_count; axis++)
            {
                AxisInfoList.Add(new define_AxisInfo()
                {
                    AxisCard = reader.GetUshort(wp_axis_card + axis.ToString()),
                    AxisCode = reader.GetUshort(wp_axis_code + axis.ToString()),
                    AxisMask = (uint)1 << axis,           //相应轴位置为1,取轴状态
                    isLimit = reader.GetBool(wp_axis_limit + axis.ToString()),
                    isServo = reader.GetBool(wp_axis_servo + axis.ToString()),
                    AxisScale = reader.GetInt(wp_axis_scale + axis.ToString()),
                    SlowSpeed = reader.GetInt(wp_axis_slow + axis.ToString()),
                    HomeSpeed = reader.GetInt(wp_axis_home + axis.ToString()),
                    FastSpeed = reader.GetInt(wp_axis_fast + axis.ToString()),
                    WorkSpeed = reader.GetInt(wp_axis_work + axis.ToString()),
                    AccTime = reader.GetDouble(wp_axis_acc + axis.ToString()),
                    OrginOff = reader.GetInt(wp_axis_ogoff + axis.ToString()),
                    OrginMov = reader.GetInt(wp_axis_ormov + axis.ToString()),
                    LimitNeg = reader.GetInt(wp_axis_ppneg + axis.ToString()),
                    LimitPos = reader.GetInt(wp_axis_pppos + axis.ToString()),
                });
            }
        }

        public void DoAxisSave(define_system.TConfigWriter writer)
        {
            for (int axis = 0; axis < define_AxisNum.wd_axis_count; axis++)
            {
                Console.WriteLine("[轴卡" + axis.ToString() + "]");

                writer.WriteInt(wp_axis_card + axis.ToString(), AxisInfoList[axis].AxisCard);
                writer.WriteInt(wp_axis_code + axis.ToString(), AxisInfoList[axis].AxisCode);
                writer.WriteBool(wp_axis_limit + axis.ToString(), AxisInfoList[axis].isLimit);
                writer.WriteBool(wp_axis_servo + axis.ToString(), AxisInfoList[axis].isServo);
                writer.WriteInt(wp_axis_scale + axis.ToString(), AxisInfoList[axis].AxisScale);
                writer.WriteInt(wp_axis_slow + axis.ToString(), AxisInfoList[axis].SlowSpeed);
                writer.WriteInt(wp_axis_home + axis.ToString(), AxisInfoList[axis].HomeSpeed);
                writer.WriteInt(wp_axis_fast + axis.ToString(), AxisInfoList[axis].FastSpeed);
                writer.WriteInt(wp_axis_work + axis.ToString(), AxisInfoList[axis].WorkSpeed);
                writer.WriteDouble(wp_axis_acc + axis.ToString(), AxisInfoList[axis].AccTime);
                writer.WriteInt(wp_axis_ogoff + axis.ToString(), AxisInfoList[axis].OrginOff);
                writer.WriteInt(wp_axis_ormov + axis.ToString(), AxisInfoList[axis].OrginMov);
                writer.WriteInt(wp_axis_ppneg + axis.ToString(), AxisInfoList[axis].LimitNeg);
                writer.WriteInt(wp_axis_pppos + axis.ToString(), AxisInfoList[axis].LimitPos);

                Console.WriteLine("");
            }

        }



    }
}
