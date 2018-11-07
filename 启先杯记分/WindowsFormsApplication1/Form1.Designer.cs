namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.sserial = new System.Windows.Forms.ComboBox();
            this.openbutton = new System.Windows.Forms.Button();
            this.findbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sparity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sstop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sdatebits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sbaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.receive = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.send = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.接收数据导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能键设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupbox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.智能车控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupbox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口选择：";
            // 
            // sserial
            // 
            this.sserial.FormattingEnabled = true;
            this.sserial.Location = new System.Drawing.Point(94, 36);
            this.sserial.Name = "sserial";
            this.sserial.Size = new System.Drawing.Size(63, 20);
            this.sserial.TabIndex = 1;
            // 
            // openbutton
            // 
            this.openbutton.Location = new System.Drawing.Point(254, 35);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(77, 21);
            this.openbutton.TabIndex = 2;
            this.openbutton.Text = "打开串口";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(172, 35);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(76, 21);
            this.findbutton.TabIndex = 3;
            this.findbutton.Text = "检测串口";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sparity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sstop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sdatebits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sbaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // sparity
            // 
            this.sparity.FormattingEnabled = true;
            this.sparity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.sparity.Location = new System.Drawing.Point(57, 111);
            this.sparity.Name = "sparity";
            this.sparity.Size = new System.Drawing.Size(63, 20);
            this.sparity.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "校验：";
            // 
            // sstop
            // 
            this.sstop.FormattingEnabled = true;
            this.sstop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.sstop.Location = new System.Drawing.Point(57, 50);
            this.sstop.Name = "sstop";
            this.sstop.Size = new System.Drawing.Size(63, 20);
            this.sstop.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "停止位：";
            // 
            // sdatebits
            // 
            this.sdatebits.FormattingEnabled = true;
            this.sdatebits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.sdatebits.Location = new System.Drawing.Point(57, 82);
            this.sdatebits.Name = "sdatebits";
            this.sdatebits.Size = new System.Drawing.Size(63, 20);
            this.sdatebits.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "数据位：";
            // 
            // sbaudrate
            // 
            this.sbaudrate.FormattingEnabled = true;
            this.sbaudrate.Items.AddRange(new object[] {
            "1382400",
            "921600",
            "460800",
            "256000",
            "230400",
            "128000",
            "115200",
            "76800",
            "57600",
            "43000",
            "38400",
            "19200",
            "9600",
            "4800",
            "2400",
            "1200"});
            this.sbaudrate.Location = new System.Drawing.Point(57, 18);
            this.sbaudrate.Name = "sbaudrate";
            this.sbaudrate.Size = new System.Drawing.Size(63, 20);
            this.sbaudrate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(106, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "字符串";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "HEX（16进制）";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.receive);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.refreshbutton);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(362, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 163);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收窗口";
            // 
            // receive
            // 
            this.receive.Location = new System.Drawing.Point(6, 20);
            this.receive.Multiline = true;
            this.receive.Name = "receive";
            this.receive.ReadOnly = true;
            this.receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receive.Size = new System.Drawing.Size(524, 133);
            this.receive.TabIndex = 0;
            this.receive.TextChanged += new System.EventHandler(this.receive_TextChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(548, 70);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 16);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "字符串";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Location = new System.Drawing.Point(536, 113);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(77, 30);
            this.refreshbutton.TabIndex = 9;
            this.refreshbutton.Text = "清空";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(557, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "HEX";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(9, 39);
            this.send.Multiline = true;
            this.send.Name = "send";
            this.send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.send.Size = new System.Drawing.Size(170, 51);
            this.send.TabIndex = 7;
            this.send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.send_KeyPress);
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(47, 118);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(79, 25);
            this.sendbutton.TabIndex = 8;
            this.sendbutton.Text = "发送";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(987, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接收数据导出ToolStripMenuItem,
            this.功能键设置ToolStripMenuItem,
            this.智能车控制ToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem.Text = "功能";
            // 
            // 接收数据导出ToolStripMenuItem
            // 
            this.接收数据导出ToolStripMenuItem.Name = "接收数据导出ToolStripMenuItem";
            this.接收数据导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.接收数据导出ToolStripMenuItem.Text = "接收数据导出";
            this.接收数据导出ToolStripMenuItem.Click += new System.EventHandler(this.接收数据导出ToolStripMenuItem_Click);
            // 
            // 功能键设置ToolStripMenuItem
            // 
            this.功能键设置ToolStripMenuItem.Name = "功能键设置ToolStripMenuItem";
            this.功能键设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.功能键设置ToolStripMenuItem.Text = "功能键设置";
            this.功能键设置ToolStripMenuItem.Click += new System.EventHandler(this.功能键设置ToolStripMenuItem_Click);
            // 
            // groupbox4
            // 
            this.groupbox4.Controls.Add(this.radioButton2);
            this.groupbox4.Controls.Add(this.checkBox1);
            this.groupbox4.Controls.Add(this.radioButton1);
            this.groupbox4.Controls.Add(this.sendbutton);
            this.groupbox4.Controls.Add(this.send);
            this.groupbox4.Location = new System.Drawing.Point(163, 66);
            this.groupbox4.Name = "groupbox4";
            this.groupbox4.Size = new System.Drawing.Size(183, 148);
            this.groupbox4.TabIndex = 12;
            this.groupbox4.TabStop = false;
            this.groupbox4.Text = "发送";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "16进制自动添加回车换行";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-30, -45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(27, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(319, 191);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "调试（HEX）";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 155);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(292, 22);
            this.textBox7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "当前数据(hex)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "值（10进制）";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "名称";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(242, 73);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(51, 21);
            this.textBox11.TabIndex = 14;
            this.textBox11.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(242, 43);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(51, 21);
            this.textBox10.TabIndex = 13;
            this.textBox10.Text = "0";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(160, 73);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(66, 21);
            this.textBox9.TabIndex = 12;
            this.textBox9.Text = "变量5(1位)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(160, 43);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 21);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "变量4(1位)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(95, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(51, 21);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 21);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "变量3(2位)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 21);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 21);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "变量2(2位)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "值（10进制）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "名称";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "100";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "变量1(2位)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.textBox16);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(362, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 211);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自定义发送";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "循环发送，周期";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(182, 176);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 21);
            this.button8.TabIndex = 27;
            this.button8.Text = "开始";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "ms";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(103, 177);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(50, 21);
            this.textBox17.TabIndex = 25;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 153);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 23;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(28, 150);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(191, 21);
            this.textBox16.TabIndex = 22;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(225, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 21);
            this.button7.TabIndex = 21;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 126);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 20;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(28, 123);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(191, 21);
            this.textBox15.TabIndex = 19;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 21);
            this.button6.TabIndex = 18;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 99);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(28, 96);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(191, 21);
            this.textBox14.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(225, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 21);
            this.button5.TabIndex = 15;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 72);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(28, 69);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(191, 21);
            this.textBox13.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 21);
            this.button4.TabIndex = 12;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(149, 21);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(59, 16);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.Text = "字符串";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(61, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(41, 16);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.Text = "HEX";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(28, 42);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(191, 21);
            this.textBox12.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 21);
            this.button3.TabIndex = 0;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button15);
            this.groupBox6.Controls.Add(this.button16);
            this.groupBox6.Controls.Add(this.button17);
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Controls.Add(this.button13);
            this.groupBox6.Controls.Add(this.button14);
            this.groupBox6.Controls.Add(this.button11);
            this.groupBox6.Controls.Add(this.button9);
            this.groupBox6.Controls.Add(this.button10);
            this.groupBox6.Location = new System.Drawing.Point(642, 204);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(333, 210);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "功能键(左上角进行设置)";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(228, 154);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(94, 50);
            this.button15.TabIndex = 9;
            this.button15.Text = "功能键9";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(228, 90);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(94, 50);
            this.button16.TabIndex = 8;
            this.button16.Text = "功能键6";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(228, 25);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(94, 50);
            this.button17.TabIndex = 7;
            this.button17.Text = "功能键3";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(117, 154);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 50);
            this.button12.TabIndex = 6;
            this.button12.Text = "功能键8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(117, 90);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 50);
            this.button13.TabIndex = 5;
            this.button13.Text = "功能键5";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(117, 25);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(94, 50);
            this.button14.TabIndex = 4;
            this.button14.Text = "功能键2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 154);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 50);
            this.button11.TabIndex = 3;
            this.button11.Text = "功能键7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 90);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 50);
            this.button9.TabIndex = 2;
            this.button9.Text = "功能键4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 25);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 50);
            this.button10.TabIndex = 1;
            this.button10.Text = "功能键1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 智能车控制ToolStripMenuItem
            // 
            this.智能车控制ToolStripMenuItem.Name = "智能车控制ToolStripMenuItem";
            this.智能车控制ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.智能车控制ToolStripMenuItem.Text = "智能车控制";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 421);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupbox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.openbutton);
            this.Controls.Add(this.sserial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "串口通信实验（默认回车换行结尾）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupbox4.ResumeLayout(false);
            this.groupbox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sserial;
        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sbaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sparity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sstop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sdatebits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox receive;
        private System.Windows.Forms.TextBox send;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Button refreshbutton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupbox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem 接收数据导出ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ToolStripMenuItem 功能键设置ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 智能车控制ToolStripMenuItem;
    }
}

