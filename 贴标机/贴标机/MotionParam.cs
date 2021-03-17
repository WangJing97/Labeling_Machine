using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机
{
    public class MotionParam
    {
        public define_motion.MotionItem[] Items = new define_motion.MotionItem[define_motion.wd_axis_count];

        public MotionParam()
        {
            for (int axis = 0; axis < Items.Length; axis++)
            {
                Items[axis] = new define_motion.MotionItem();
            }
        }

        private const string wp_axis_xsafe = "X轴安全位置";
        private const string wp_axis_ysafe = "Y轴安全位置";
        private const string wp_axis_zsafe = "Z轴安全位置";
        private const string wp_axis_dcc = "轴减速时间";
        private const string wp_axis_type = "轴复位类型";


        private const string wp_axis_card = "轴卡号";
        private const string wp_axis_code = "轴编号";
        //private const string wp_axis_scale = "轴比例尺";
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

        public void DoSystemRead(define_system.TConfigReader reader)
        {
            //控制位置

            //控制轴
            for (int axis = 0; axis < Items.Length; axis++)
            {
                define_motion.MotionItem item = Items[axis];
                item.AxisCard = reader.GetUshort(wp_axis_card + axis.ToString());
                item.AxisCode = reader.GetUshort(wp_axis_code + axis.ToString());
                item.AxisMask = (uint)1 << axis;//相应轴位置为1,取轴状态
                item.isLimit = reader.GetBool(wp_axis_limit + axis.ToString());
                item.isServo = reader.GetBool(wp_axis_servo + axis.ToString());
                item.AxisCode = reader.GetUshort(wp_axis_code + axis.ToString());
                //item.AxisScale = reader.GetFloat(wp_axis_scale + axis.ToString());
                item.SlowSpeed = reader.GetInt(wp_axis_slow + axis.ToString());
                item.HomeSpeed = reader.GetInt(wp_axis_home + axis.ToString());
                item.FastSpeed = reader.GetInt(wp_axis_fast + axis.ToString());
                item.WorkSpeed = reader.GetInt(wp_axis_work + axis.ToString());
                item.AccTime = reader.GetInt(wp_axis_acc + axis.ToString());
                item.OrginOff = reader.GetInt(wp_axis_ogoff + axis.ToString());
                item.OrginMov = reader.GetInt(wp_axis_ormov + axis.ToString());
                item.LimitNeg = reader.GetInt(wp_axis_ppneg + axis.ToString());
                item.LimitPos = reader.GetInt(wp_axis_pppos + axis.ToString());
            }
        }

    }
}
