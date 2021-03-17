using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Globalization;
using System.Collections;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Windows.Forms;


namespace 贴标机
{
    public class define_property
    {
        public class PropertySystem
        {
            [CategoryAttribute("1.XY轴")]
            [DisplayName("XY加速度(50-300ms)")]
            public int Axis_acc_xy { get; set; }
            [CategoryAttribute("1.XY轴")]
            [DisplayName("X负限位置")]
            public int Axis_limit_nx { get; set; }
            [CategoryAttribute("1.XY轴")]
            [DisplayName("Y负限位置")]
            public int Axis_limit_ny { get; set; }
            [CategoryAttribute("1.XY轴")]
            [DisplayName("X正限位置")]
            public int Axis_limit_px { get; set; }
            [CategoryAttribute("1.XY轴")]
            [DisplayName("Y正限位置")]
            public int Axis_limit_py { get; set; }
            [CategoryAttribute("1.XY轴")]
            [DisplayName("X零点位置")]
            public int Axis_orgin_x { get; set; }
            [CategoryAttribute("1.XY轴")]
            [DisplayName("Y零点位置")]
            public int Axis_orgin_y { get; set; }



            public void DoGetParams(MachineParams src)
            {
                Axis_acc_xy = src.pMotion.Items[define_motion.wd_axis_xx].AccTime;
                Axis_limit_nx = src.pMotion.Items[define_motion.wd_axis_xx].LimitNeg;
                Axis_limit_ny = src.pMotion.Items[define_motion.wd_axis_yy].LimitNeg;
                Axis_limit_px = src.pMotion.Items[define_motion.wd_axis_xx].LimitPos;
                Axis_limit_py = src.pMotion.Items[define_motion.wd_axis_yy].LimitPos;
                Axis_orgin_x = src.pMotion.Items[define_motion.wd_axis_xx].OrginOff;
                Axis_orgin_y = src.pMotion.Items[define_motion.wd_axis_yy].OrginOff;

            }
        }
    }
}
