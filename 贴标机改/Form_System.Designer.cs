
namespace 贴标机改
{
    partial class Form_System
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_System));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_move = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.text_head_index = new System.Windows.Forms.ComboBox();
            this.group_speed = new System.Windows.Forms.GroupBox();
            this.text_radio_by = new System.Windows.Forms.TextBox();
            this.radio_by = new System.Windows.Forms.RadioButton();
            this.radio_dmm = new System.Windows.Forms.RadioButton();
            this.radio_mm = new System.Windows.Forms.RadioButton();
            this.radio_cm = new System.Windows.Forms.RadioButton();
            this.radio_fast = new System.Windows.Forms.RadioButton();
            this.radio_slow = new System.Windows.Forms.RadioButton();
            this.button_move_r_neg = new System.Windows.Forms.Button();
            this.button_move_r_pos = new System.Windows.Forms.Button();
            this.button_move_back_w = new System.Windows.Forms.Button();
            this.button_move_back_y = new System.Windows.Forms.Button();
            this.button_move_forw_w = new System.Windows.Forms.Button();
            this.button_move_back_x = new System.Windows.Forms.Button();
            this.button_move_stop = new System.Windows.Forms.Button();
            this.button_move_forw_x = new System.Windows.Forms.Button();
            this.button_move_forw_y = new System.Windows.Forms.Button();
            this.panel_axis = new System.Windows.Forms.Panel();
            this.text_axis_r5 = new System.Windows.Forms.TextBox();
            this.text_axis_z5 = new System.Windows.Forms.TextBox();
            this.text_axis_r4 = new System.Windows.Forms.TextBox();
            this.text_axis_z4 = new System.Windows.Forms.TextBox();
            this.text_axis_r3 = new System.Windows.Forms.TextBox();
            this.text_axis_z3 = new System.Windows.Forms.TextBox();
            this.text_axis_r2 = new System.Windows.Forms.TextBox();
            this.text_axis_z2 = new System.Windows.Forms.TextBox();
            this.text_axis_r1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_axis_z1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_axis_yy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_axis_xx = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listgrid_params = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_move.SuspendLayout();
            this.group_speed.SuspendLayout();
            this.panel_axis.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.85075F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.14925F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel_move, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_axis, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.22997F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.78746F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 531);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel_move
            // 
            this.panel_move.Controls.Add(this.label5);
            this.panel_move.Controls.Add(this.text_head_index);
            this.panel_move.Controls.Add(this.group_speed);
            this.panel_move.Controls.Add(this.button_move_r_neg);
            this.panel_move.Controls.Add(this.button_move_r_pos);
            this.panel_move.Controls.Add(this.button_move_back_w);
            this.panel_move.Controls.Add(this.button_move_back_y);
            this.panel_move.Controls.Add(this.button_move_forw_w);
            this.panel_move.Controls.Add(this.button_move_back_x);
            this.panel_move.Controls.Add(this.button_move_stop);
            this.panel_move.Controls.Add(this.button_move_forw_x);
            this.panel_move.Controls.Add(this.button_move_forw_y);
            this.panel_move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_move.Location = new System.Drawing.Point(0, 79);
            this.panel_move.Margin = new System.Windows.Forms.Padding(0);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(320, 171);
            this.panel_move.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "吸头:";
            // 
            // text_head_index
            // 
            this.text_head_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_head_index.FormattingEnabled = true;
            this.text_head_index.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.text_head_index.Location = new System.Drawing.Point(254, 2);
            this.text_head_index.Name = "text_head_index";
            this.text_head_index.Size = new System.Drawing.Size(53, 20);
            this.text_head_index.TabIndex = 21;
            // 
            // group_speed
            // 
            this.group_speed.Controls.Add(this.text_radio_by);
            this.group_speed.Controls.Add(this.radio_by);
            this.group_speed.Controls.Add(this.radio_dmm);
            this.group_speed.Controls.Add(this.radio_mm);
            this.group_speed.Controls.Add(this.radio_cm);
            this.group_speed.Controls.Add(this.radio_fast);
            this.group_speed.Controls.Add(this.radio_slow);
            this.group_speed.Location = new System.Drawing.Point(207, 17);
            this.group_speed.Name = "group_speed";
            this.group_speed.Size = new System.Drawing.Size(102, 151);
            this.group_speed.TabIndex = 22;
            this.group_speed.TabStop = false;
            this.group_speed.Tag = "0";
            // 
            // text_radio_by
            // 
            this.text_radio_by.Enabled = false;
            this.text_radio_by.Location = new System.Drawing.Point(47, 127);
            this.text_radio_by.Name = "text_radio_by";
            this.text_radio_by.Size = new System.Drawing.Size(49, 21);
            this.text_radio_by.TabIndex = 14;
            this.text_radio_by.Text = "0";
            // 
            // radio_by
            // 
            this.radio_by.AutoSize = true;
            this.radio_by.Location = new System.Drawing.Point(14, 128);
            this.radio_by.Name = "radio_by";
            this.radio_by.Size = new System.Drawing.Size(35, 16);
            this.radio_by.TabIndex = 5;
            this.radio_by.Tag = "";
            this.radio_by.Text = "移";
            this.radio_by.UseVisualStyleBackColor = true;
            // 
            // radio_dmm
            // 
            this.radio_dmm.AutoSize = true;
            this.radio_dmm.Location = new System.Drawing.Point(14, 106);
            this.radio_dmm.Name = "radio_dmm";
            this.radio_dmm.Size = new System.Drawing.Size(59, 16);
            this.radio_dmm.TabIndex = 4;
            this.radio_dmm.Tag = "";
            this.radio_dmm.Text = "0.01mm";
            this.radio_dmm.UseVisualStyleBackColor = true;
            // 
            // radio_mm
            // 
            this.radio_mm.AutoSize = true;
            this.radio_mm.Location = new System.Drawing.Point(14, 84);
            this.radio_mm.Name = "radio_mm";
            this.radio_mm.Size = new System.Drawing.Size(59, 16);
            this.radio_mm.TabIndex = 3;
            this.radio_mm.Tag = "";
            this.radio_mm.Text = "0.10mm";
            this.radio_mm.UseVisualStyleBackColor = true;
            // 
            // radio_cm
            // 
            this.radio_cm.AutoSize = true;
            this.radio_cm.Location = new System.Drawing.Point(14, 62);
            this.radio_cm.Name = "radio_cm";
            this.radio_cm.Size = new System.Drawing.Size(59, 16);
            this.radio_cm.TabIndex = 2;
            this.radio_cm.Tag = "";
            this.radio_cm.Text = "1.00mm";
            this.radio_cm.UseVisualStyleBackColor = true;
            // 
            // radio_fast
            // 
            this.radio_fast.AutoSize = true;
            this.radio_fast.Location = new System.Drawing.Point(14, 40);
            this.radio_fast.Name = "radio_fast";
            this.radio_fast.Size = new System.Drawing.Size(71, 16);
            this.radio_fast.TabIndex = 1;
            this.radio_fast.Tag = "";
            this.radio_fast.Text = "快速点动";
            this.radio_fast.UseVisualStyleBackColor = true;
            // 
            // radio_slow
            // 
            this.radio_slow.AutoSize = true;
            this.radio_slow.Checked = true;
            this.radio_slow.Location = new System.Drawing.Point(14, 18);
            this.radio_slow.Name = "radio_slow";
            this.radio_slow.Size = new System.Drawing.Size(71, 16);
            this.radio_slow.TabIndex = 0;
            this.radio_slow.TabStop = true;
            this.radio_slow.Tag = "";
            this.radio_slow.Text = "慢速点动";
            this.radio_slow.UseVisualStyleBackColor = true;
            // 
            // button_move_r_neg
            // 
            this.button_move_r_neg.BackColor = System.Drawing.Color.Transparent;
            this.button_move_r_neg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_move_r_neg.BackgroundImage")));
            this.button_move_r_neg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_move_r_neg.Location = new System.Drawing.Point(102, 116);
            this.button_move_r_neg.Name = "button_move_r_neg";
            this.button_move_r_neg.Size = new System.Drawing.Size(45, 45);
            this.button_move_r_neg.TabIndex = 19;
            this.button_move_r_neg.Tag = "";
            this.button_move_r_neg.UseVisualStyleBackColor = false;
            // 
            // button_move_r_pos
            // 
            this.button_move_r_pos.BackColor = System.Drawing.Color.Transparent;
            this.button_move_r_pos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_move_r_pos.BackgroundImage")));
            this.button_move_r_pos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_move_r_pos.Location = new System.Drawing.Point(152, 116);
            this.button_move_r_pos.Name = "button_move_r_pos";
            this.button_move_r_pos.Size = new System.Drawing.Size(45, 45);
            this.button_move_r_pos.TabIndex = 20;
            this.button_move_r_pos.Tag = "";
            this.button_move_r_pos.UseVisualStyleBackColor = false;
            // 
            // button_move_back_w
            // 
            this.button_move_back_w.BackColor = System.Drawing.Color.Transparent;
            this.button_move_back_w.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_move_back_w.BackgroundImage")));
            this.button_move_back_w.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_move_back_w.Location = new System.Drawing.Point(152, 17);
            this.button_move_back_w.Name = "button_move_back_w";
            this.button_move_back_w.Size = new System.Drawing.Size(45, 45);
            this.button_move_back_w.TabIndex = 17;
            this.button_move_back_w.TabStop = false;
            this.button_move_back_w.Tag = "";
            this.button_move_back_w.UseVisualStyleBackColor = false;
            // 
            // button_move_back_y
            // 
            this.button_move_back_y.BackColor = System.Drawing.Color.Transparent;
            this.button_move_back_y.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_move_back_y.BackgroundImage")));
            this.button_move_back_y.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_move_back_y.Location = new System.Drawing.Point(57, 21);
            this.button_move_back_y.Name = "button_move_back_y";
            this.button_move_back_y.Size = new System.Drawing.Size(45, 45);
            this.button_move_back_y.TabIndex = 16;
            this.button_move_back_y.TabStop = false;
            this.button_move_back_y.Tag = "";
            this.button_move_back_y.UseVisualStyleBackColor = false;
            // 
            // button_move_forw_w
            // 
            this.button_move_forw_w.BackColor = System.Drawing.Color.Transparent;
            this.button_move_forw_w.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_move_forw_w.BackgroundImage")));
            this.button_move_forw_w.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_move_forw_w.Location = new System.Drawing.Point(152, 67);
            this.button_move_forw_w.Name = "button_move_forw_w";
            this.button_move_forw_w.Size = new System.Drawing.Size(45, 45);
            this.button_move_forw_w.TabIndex = 18;
            this.button_move_forw_w.TabStop = false;
            this.button_move_forw_w.Tag = "";
            this.button_move_forw_w.UseVisualStyleBackColor = false;
            // 
            // button_move_back_x
            // 
            this.button_move_back_x.BackColor = System.Drawing.Color.Transparent;
            this.button_move_back_x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_move_back_x.BackgroundImage")));
            this.button_move_back_x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_move_back_x.Location = new System.Drawing.Point(10, 67);
            this.button_move_back_x.Name = "button_move_back_x";
            this.button_move_back_x.Size = new System.Drawing.Size(45, 45);
            this.button_move_back_x.TabIndex = 13;
            this.button_move_back_x.TabStop = false;
            this.button_move_back_x.Tag = "";
            this.button_move_back_x.UseVisualStyleBackColor = false;
            // 
            // button_move_stop
            // 
            this.button_move_stop.BackColor = System.Drawing.Color.Transparent;
            this.button_move_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_move_stop.Location = new System.Drawing.Point(56, 67);
            this.button_move_stop.Name = "button_move_stop";
            this.button_move_stop.Size = new System.Drawing.Size(45, 45);
            this.button_move_stop.TabIndex = 12;
            this.button_move_stop.TabStop = false;
            this.button_move_stop.Tag = "";
            this.button_move_stop.Text = "停止";
            this.button_move_stop.UseVisualStyleBackColor = false;
            // 
            // button_move_forw_x
            // 
            this.button_move_forw_x.BackColor = System.Drawing.Color.Transparent;
            this.button_move_forw_x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_move_forw_x.BackgroundImage")));
            this.button_move_forw_x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_move_forw_x.Location = new System.Drawing.Point(102, 67);
            this.button_move_forw_x.Name = "button_move_forw_x";
            this.button_move_forw_x.Size = new System.Drawing.Size(45, 45);
            this.button_move_forw_x.TabIndex = 14;
            this.button_move_forw_x.TabStop = false;
            this.button_move_forw_x.Tag = "";
            this.button_move_forw_x.UseVisualStyleBackColor = false;
            // 
            // button_move_forw_y
            // 
            this.button_move_forw_y.BackColor = System.Drawing.Color.Transparent;
            this.button_move_forw_y.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_move_forw_y.BackgroundImage")));
            this.button_move_forw_y.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_move_forw_y.Location = new System.Drawing.Point(56, 116);
            this.button_move_forw_y.Name = "button_move_forw_y";
            this.button_move_forw_y.Size = new System.Drawing.Size(45, 45);
            this.button_move_forw_y.TabIndex = 15;
            this.button_move_forw_y.TabStop = false;
            this.button_move_forw_y.Tag = "";
            this.button_move_forw_y.UseVisualStyleBackColor = false;
            // 
            // panel_axis
            // 
            this.panel_axis.Controls.Add(this.text_axis_r5);
            this.panel_axis.Controls.Add(this.text_axis_z5);
            this.panel_axis.Controls.Add(this.text_axis_r4);
            this.panel_axis.Controls.Add(this.text_axis_z4);
            this.panel_axis.Controls.Add(this.text_axis_r3);
            this.panel_axis.Controls.Add(this.text_axis_z3);
            this.panel_axis.Controls.Add(this.text_axis_r2);
            this.panel_axis.Controls.Add(this.text_axis_z2);
            this.panel_axis.Controls.Add(this.text_axis_r1);
            this.panel_axis.Controls.Add(this.label10);
            this.panel_axis.Controls.Add(this.label3);
            this.panel_axis.Controls.Add(this.text_axis_z1);
            this.panel_axis.Controls.Add(this.label2);
            this.panel_axis.Controls.Add(this.text_axis_yy);
            this.panel_axis.Controls.Add(this.label4);
            this.panel_axis.Controls.Add(this.text_axis_xx);
            this.panel_axis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_axis.Location = new System.Drawing.Point(0, 0);
            this.panel_axis.Margin = new System.Windows.Forms.Padding(0);
            this.panel_axis.Name = "panel_axis";
            this.panel_axis.Size = new System.Drawing.Size(320, 79);
            this.panel_axis.TabIndex = 0;
            // 
            // text_axis_r5
            // 
            this.text_axis_r5.Location = new System.Drawing.Point(262, 53);
            this.text_axis_r5.Name = "text_axis_r5";
            this.text_axis_r5.ReadOnly = true;
            this.text_axis_r5.Size = new System.Drawing.Size(48, 21);
            this.text_axis_r5.TabIndex = 47;
            this.text_axis_r5.TabStop = false;
            this.text_axis_r5.Text = "0";
            this.text_axis_r5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_axis_z5
            // 
            this.text_axis_z5.Location = new System.Drawing.Point(262, 28);
            this.text_axis_z5.Name = "text_axis_z5";
            this.text_axis_z5.ReadOnly = true;
            this.text_axis_z5.Size = new System.Drawing.Size(48, 21);
            this.text_axis_z5.TabIndex = 46;
            this.text_axis_z5.TabStop = false;
            this.text_axis_z5.Text = "0";
            this.text_axis_z5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_axis_r4
            // 
            this.text_axis_r4.Location = new System.Drawing.Point(208, 54);
            this.text_axis_r4.Name = "text_axis_r4";
            this.text_axis_r4.ReadOnly = true;
            this.text_axis_r4.Size = new System.Drawing.Size(48, 21);
            this.text_axis_r4.TabIndex = 45;
            this.text_axis_r4.TabStop = false;
            this.text_axis_r4.Text = "0";
            this.text_axis_r4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_axis_z4
            // 
            this.text_axis_z4.Location = new System.Drawing.Point(208, 29);
            this.text_axis_z4.Name = "text_axis_z4";
            this.text_axis_z4.ReadOnly = true;
            this.text_axis_z4.Size = new System.Drawing.Size(48, 21);
            this.text_axis_z4.TabIndex = 44;
            this.text_axis_z4.TabStop = false;
            this.text_axis_z4.Text = "0";
            this.text_axis_z4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_axis_r3
            // 
            this.text_axis_r3.Location = new System.Drawing.Point(151, 53);
            this.text_axis_r3.Name = "text_axis_r3";
            this.text_axis_r3.ReadOnly = true;
            this.text_axis_r3.Size = new System.Drawing.Size(48, 21);
            this.text_axis_r3.TabIndex = 43;
            this.text_axis_r3.TabStop = false;
            this.text_axis_r3.Text = "0";
            this.text_axis_r3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_axis_z3
            // 
            this.text_axis_z3.Location = new System.Drawing.Point(151, 28);
            this.text_axis_z3.Name = "text_axis_z3";
            this.text_axis_z3.ReadOnly = true;
            this.text_axis_z3.Size = new System.Drawing.Size(48, 21);
            this.text_axis_z3.TabIndex = 42;
            this.text_axis_z3.TabStop = false;
            this.text_axis_z3.Text = "0";
            this.text_axis_z3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_axis_r2
            // 
            this.text_axis_r2.Location = new System.Drawing.Point(94, 53);
            this.text_axis_r2.Name = "text_axis_r2";
            this.text_axis_r2.ReadOnly = true;
            this.text_axis_r2.Size = new System.Drawing.Size(48, 21);
            this.text_axis_r2.TabIndex = 41;
            this.text_axis_r2.TabStop = false;
            this.text_axis_r2.Text = "0";
            this.text_axis_r2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_axis_z2
            // 
            this.text_axis_z2.Location = new System.Drawing.Point(94, 28);
            this.text_axis_z2.Name = "text_axis_z2";
            this.text_axis_z2.ReadOnly = true;
            this.text_axis_z2.Size = new System.Drawing.Size(48, 21);
            this.text_axis_z2.TabIndex = 40;
            this.text_axis_z2.TabStop = false;
            this.text_axis_z2.Text = "0";
            this.text_axis_z2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_axis_r1
            // 
            this.text_axis_r1.Location = new System.Drawing.Point(37, 53);
            this.text_axis_r1.Name = "text_axis_r1";
            this.text_axis_r1.ReadOnly = true;
            this.text_axis_r1.Size = new System.Drawing.Size(48, 21);
            this.text_axis_r1.TabIndex = 39;
            this.text_axis_r1.TabStop = false;
            this.text_axis_r1.Text = "0";
            this.text_axis_r1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "Z:";
            // 
            // text_axis_z1
            // 
            this.text_axis_z1.Location = new System.Drawing.Point(37, 28);
            this.text_axis_z1.Name = "text_axis_z1";
            this.text_axis_z1.ReadOnly = true;
            this.text_axis_z1.Size = new System.Drawing.Size(48, 21);
            this.text_axis_z1.TabIndex = 38;
            this.text_axis_z1.TabStop = false;
            this.text_axis_z1.Text = "0";
            this.text_axis_z1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "X:";
            // 
            // text_axis_yy
            // 
            this.text_axis_yy.Location = new System.Drawing.Point(115, 3);
            this.text_axis_yy.Name = "text_axis_yy";
            this.text_axis_yy.ReadOnly = true;
            this.text_axis_yy.Size = new System.Drawing.Size(48, 21);
            this.text_axis_yy.TabIndex = 37;
            this.text_axis_yy.TabStop = false;
            this.text_axis_yy.Text = "0";
            this.text_axis_yy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "Y:";
            // 
            // text_axis_xx
            // 
            this.text_axis_xx.Location = new System.Drawing.Point(37, 3);
            this.text_axis_xx.Name = "text_axis_xx";
            this.text_axis_xx.ReadOnly = true;
            this.text_axis_xx.Size = new System.Drawing.Size(48, 21);
            this.text_axis_xx.TabIndex = 36;
            this.text_axis_xx.TabStop = false;
            this.text_axis_xx.Text = "0";
            this.text_axis_xx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 250);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 281);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listgrid_params);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "参数";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listgrid_params
            // 
            this.listgrid_params.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listgrid_params.Location = new System.Drawing.Point(3, 3);
            this.listgrid_params.Name = "listgrid_params";
            this.listgrid_params.Size = new System.Drawing.Size(306, 249);
            this.listgrid_params.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "标定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_System";
            this.Text = "系统参数";
            this.Load += new System.EventHandler(this.Form_System_Load);
            this.Shown += new System.EventHandler(this.Form_System_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_move.ResumeLayout(false);
            this.panel_move.PerformLayout();
            this.group_speed.ResumeLayout(false);
            this.group_speed.PerformLayout();
            this.panel_axis.ResumeLayout(false);
            this.panel_axis.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox text_head_index;
        private System.Windows.Forms.GroupBox group_speed;
        private System.Windows.Forms.TextBox text_radio_by;
        private System.Windows.Forms.RadioButton radio_by;
        private System.Windows.Forms.RadioButton radio_dmm;
        private System.Windows.Forms.RadioButton radio_mm;
        private System.Windows.Forms.RadioButton radio_cm;
        private System.Windows.Forms.RadioButton radio_fast;
        private System.Windows.Forms.RadioButton radio_slow;
        private System.Windows.Forms.Button button_move_r_neg;
        private System.Windows.Forms.Button button_move_r_pos;
        private System.Windows.Forms.Button button_move_back_w;
        private System.Windows.Forms.Button button_move_back_y;
        private System.Windows.Forms.Button button_move_forw_w;
        private System.Windows.Forms.Button button_move_back_x;
        private System.Windows.Forms.Button button_move_stop;
        private System.Windows.Forms.Button button_move_forw_x;
        private System.Windows.Forms.Button button_move_forw_y;
        private System.Windows.Forms.Panel panel_axis;
        private System.Windows.Forms.TextBox text_axis_r5;
        private System.Windows.Forms.TextBox text_axis_z5;
        private System.Windows.Forms.TextBox text_axis_r4;
        private System.Windows.Forms.TextBox text_axis_z4;
        private System.Windows.Forms.TextBox text_axis_r3;
        private System.Windows.Forms.TextBox text_axis_z3;
        private System.Windows.Forms.TextBox text_axis_r2;
        private System.Windows.Forms.TextBox text_axis_z2;
        private System.Windows.Forms.TextBox text_axis_r1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_axis_z1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_axis_yy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_axis_xx;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PropertyGrid listgrid_params;
    }
}