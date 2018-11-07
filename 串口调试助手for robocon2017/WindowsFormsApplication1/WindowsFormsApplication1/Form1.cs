using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string bz1, bz2;
        output op = new output();
        setting st = new setting();
        机器人 robot= new 机器人();
        bool[] settinghex = new bool[9];
        string[] settingkey = new string[9];
        public Form1()
        {
            InitializeComponent();  
            readconfig();
            readconfig();//装载配置
            reset() ;//加载自定义按键
            bz1 = op.startsymbol.Text;//检测开始标志
            bz2 = op.stopsymbol.Text;//检测停止标志
            enable();//防止错按按钮
        }
        SerialPort sp1 = new SerialPort();
        
        private int dtimes = 0;//记录数据组数
        private void button2_Click(object sender, EventArgs e)
        {
            sserial.Items.Clear();
            string[] str = SerialPort.GetPortNames();//检查是否含有串口 
            if (str == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())   //添加串口
            {
                sserial.Items.Add(s);          //获取有多少个COM口，添加到控件里
                sserial.SelectedIndex = 0;
            }
            Control.CheckForIllegalCrossThreadCalls = false;//跨线程
            sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);//订阅委托
            //sp1.DataReceived += sp1_DataReceived;
        }

        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp1.IsOpen)//确保打开
            {
                byte[] byteRead = new byte[sp1.BytesToRead];//接收字符个数BytesToRead
                if(radioButton4.Checked)//字符串发送
                {
                    string casualdata = sp1.ReadLine();
                    receive.Text += casualdata + "\r\n";//回车换行
                    translate(casualdata);//读取当前值处理并输出到输出窗口
                    sp1.DiscardInBuffer();//清空缓存区
                }
                else//二进制发送
                {
                    try
                    {
                        byte[] receivedData = new byte[sp1.BytesToRead];//创建接收数组
                        sp1.Read(receivedData, 0, receivedData.Length);//不偏移读取所有数据
                        sp1.DiscardInBuffer();//清空缓存区
                        string strRcv = null;//16进制数据
                        for (int i = 0; i < receivedData.Length; i++) //窗体显示 
                        {
                            strRcv += receivedData[i].ToString("X2"); //16进制(两位数)显示 
                            strRcv += " ";//加空格便于查看
                        }
                        receive.Text += strRcv + "\r\n";
                    }
                    catch (System.Exception ex)//若发生错误
                    {
                        MessageBox.Show(ex.Message, "出错提示");
                        send.Text = "";
                    }
                }
              //  Application.DoEvents();
            }
            else
            {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
            DateTime dt = DateTime.Now;
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            receive.Clear();
        }

        private void openbutton_Click(object sender, EventArgs e)
        {
            if(!sp1.IsOpen)
            {
                try
                {
                    string serialname = sserial.SelectedItem.ToString();
                    sp1.PortName = serialname;
                    sp1.Encoding = System.Text.Encoding.GetEncoding("GB2312");//编码
                    sp1.NewLine = "\r\n";

                    string Baudrate = sbaudrate.Text;
                    string Datebits = sdatebits.Text;
                    string Stopbits = sstop.Text;
                    Int32 iBaudrate = Convert.ToInt32(Baudrate);
                    Int32 iDatebits = Convert.ToInt32(Datebits);

                    sp1.BaudRate = iBaudrate;//波特率
                    sp1.DataBits = iDatebits;//数据位
                    switch (sstop.Text)//停止位
                    {
                        case "1":
                            sp1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            sp1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            sp1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    switch (sparity.Text)
                    {
                        case "无":
                            sp1.Parity = Parity.None;
                            break;
                        case "奇校验":
                            sp1.Parity = Parity.Odd;
                            break;
                        case "偶校验":
                            sp1.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }

                    if (sp1.IsOpen == true)//如果打开状态，则先关闭一下 
                    {
                        sp1.Close();
                    }

                    sp1.Open();
                    openbutton.Text = "关闭串口";
                    able();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }

            }

            else
            {
                sp1.DiscardInBuffer();
                sp1.Close();
                openbutton.Text = "打开串口";
                enable();
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            sp1.Close();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (!sp1.IsOpen) //如果没打开 
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }

            if (checkBox1.Checked && radioButton1.Checked && send.Text.IndexOf(" 0D 0A")==-1)
                send.Text += " 0D 0A";

            if (radioButton1.Checked == true)//16进制发送
            {
                sendhex(send.Text);
            }
            else //字符串发送
            {
                sp1.WriteLine(send.Text); //写入数据 
            }
        }

        private void receive_TextChanged(object sender, EventArgs e)
        {
            receive.SelectionStart = receive.TextLength;
            receive.ScrollToCaret();
        }

        private void 接收数据导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op.Show();
        }

        private void translate(string a)//窗口传递输出信息 查找关键字
        {
            bz1 = op.startsymbol.Text;
            bz2 = op.stopsymbol.Text;
            robot.textBox6.Text = "";
            findkeyandoutput(a, "1p" ,robot.textBox6);
            if (robot.textBox6.Text != "")
            {
                robot.label4.Text = robot.textBox6.Text;
                robot.textBox6.Text = "";
            }
            findkeyandoutput(a, "1v", robot.textBox6);
            if (robot.textBox6.Text != "")
            {
                robot.label16.Text = robot.textBox6.Text;
                robot.textBox6.Text = "";
            }
            findkeyandoutput(a, "1h", robot.textBox6);
            if (robot.textBox6.Text != "")
            {
                robot.textBox5.Text += "(" + robot.textBox6.Text + ") ";
                robot.textBox6.Text = "";
            }  
            findkeyandoutput(a, op.key1w.Text, op.key1d);
            findkeyandoutput(a, op.key2w.Text, op.key2d);
            findkeyandoutput(a, op.key3w.Text, op.key3d);
            findkeyandoutput(a, op.key4w.Text, op.key4d);
            findkeyandoutput(a, op.key5w.Text, op.key5d);
            findkeyandoutput(a, op.key6w.Text, op.key6d);
            dtimes++;
            op.datatimes.Text = dtimes.ToString();
        }



        private void findkeyandoutput(string a, string key, TextBox output) //截取关键字$:XXX$中的XXX并输出
        {
            if (key != "")
            {
                int i;
                string casualstr;
                i = a.IndexOf(key + bz1) + key.Length + 2;
                if (a.IndexOf(key + bz1) != -1)
                {
                    casualstr = a.Substring(i);
                    i = casualstr.IndexOf(bz2);
                    if (i != -1)
                    {
                        string recheck = casualstr.Substring(0, i);
                        if (recheck.IndexOf(bz1) == -1)                   //避免发送不必要的$:
                            output.Text = recheck;
                        else
                            output.Text = "数据格式错误";
                    }
                    else
                        output.Text = "数据格式错误";
                }
                else
                    ;
                // output.Text = "None";
            }
            else
                ;
                //output.Text = "None";
        }

        private void send_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                sendbutton_Click(null, null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveconfig();
            op.Close();
            st.Close();
        }

        private void readconfig()//读取配置文件
        {
            if (!File.Exists("config.txt"))
            {
                FileStream fs1 = new FileStream("config.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine("baudrate:115200");
                sw.WriteLine("databits:8");
                sw.WriteLine("stopbits:1");
                sw.WriteLine("sparity:无");
                sw.WriteLine("key1:");
                sw.WriteLine("key2:");
                sw.WriteLine("key3:");
                sw.WriteLine("key4:");
                sw.WriteLine("key5:");
                sw.WriteLine("key6:");
                sw.WriteLine("sendstring:true");
                sw.WriteLine("readstring:true");
                sw.WriteLine("0D 0A:true");
                sw.WriteLine("startsymbol:$:");
                sw.WriteLine("stopsymbol:$$");
                sw.WriteLine("variable1:变量1(2位)");
                sw.WriteLine("variable2:变量2(2位)");
                sw.WriteLine("variable3:变量3(2位)");
                sw.WriteLine("variable4:变量4(2位)");
                sw.WriteLine("variable5:变量5(2位)");
                sw.WriteLine("v1value:0");
                sw.WriteLine("v2value:0");
                sw.WriteLine("v3value:0");
                sw.WriteLine("v4value:0");
                sw.WriteLine("v5value:0");
                sw.WriteLine("customvalue1:0D 0A");
                sw.WriteLine("customvalue2:0D 0A");
                sw.WriteLine("customvalue3:0D 0A");
                sw.WriteLine("customvalue4:0D 0A");
                sw.WriteLine("customvalue5:0D 0A");
                sw.WriteLine("cycle:1000");
                sw.WriteLine("customhex:true");
                sw.WriteLine("checked1:false");
                sw.WriteLine("checked2:false");
                sw.WriteLine("checked3:false");
                sw.WriteLine("checked4:false");
                sw.WriteLine("checked5:false");
                sw.Close();
                fs1.Close();
            }
            else
            {
                FileStream fs = new FileStream("config.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                sbaudrate.Text= sr.ReadLine().Substring(9);
                sdatebits.Text = sr.ReadLine().Substring(9);
                sstop.Text = sr.ReadLine().Substring(9);
                sparity.Text = sr.ReadLine().Substring(8);
                op.key1w.Text = sr.ReadLine().Substring(5);
                op.key2w.Text = sr.ReadLine().Substring(5);
                op.key3w.Text = sr.ReadLine().Substring(5);
                op.key4w.Text = sr.ReadLine().Substring(5);
                op.key5w.Text = sr.ReadLine().Substring(5);
                op.key6w.Text = sr.ReadLine().Substring(5);
                radioButton1.Checked = true;
                radioButton3.Checked = true;
                if (sr.ReadLine().Substring(11) == "true")
                    radioButton2.Checked = true;
                if (sr.ReadLine().Substring(11) == "true")
                    radioButton4.Checked = true;
                if (sr.ReadLine().Substring(6) == "true")
                    checkBox1.Checked = true;
                else
                    checkBox1.Checked = false;
                op.startsymbol.Text = sr.ReadLine().Substring(12);
                op.stopsymbol.Text = sr.ReadLine().Substring(11);
                textBox1.Text = sr.ReadLine().Substring(10);
                textBox3.Text = sr.ReadLine().Substring(10);
                textBox5.Text = sr.ReadLine().Substring(10);
                textBox8.Text = sr.ReadLine().Substring(10);
                textBox9.Text = sr.ReadLine().Substring(10);
                textBox2.Text = sr.ReadLine().Substring(8);
                textBox4.Text = sr.ReadLine().Substring(8);
                textBox6.Text = sr.ReadLine().Substring(8);
                textBox10.Text = sr.ReadLine().Substring(8);
                textBox11.Text = sr.ReadLine().Substring(8);
                textBox12.Text = sr.ReadLine().Substring(13);
                textBox13.Text = sr.ReadLine().Substring(13);
                textBox14.Text = sr.ReadLine().Substring(13);
                textBox15.Text = sr.ReadLine().Substring(13);
                textBox16.Text = sr.ReadLine().Substring(13);
                textBox17.Text = sr.ReadLine().Substring(6);
                radioButton6.Checked = true;
                if (sr.ReadLine().Substring(10) == "true")
                    radioButton5.Checked = true;
                if (sr.ReadLine().Substring(9) == "true")
                    checkBox2.Checked = true;
                if (sr.ReadLine().Substring(9) == "true")
                    checkBox3.Checked = true;
                if (sr.ReadLine().Substring(9) == "true")
                    checkBox4.Checked = true;
                if (sr.ReadLine().Substring(9) == "true")
                    checkBox5.Checked = true;
                if (sr.ReadLine().Substring(9) == "true")
                    checkBox6.Checked = true;
                sr.Close();
                fs.Close();
            }
        }

        private void saveconfig()//储存配置文件
        {
            FileStream fs1 = new FileStream("config.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine("baudrate:" + sbaudrate.Text);
            sw.WriteLine("databits:" + sdatebits.Text);
            sw.WriteLine("stopbits:" + sstop.Text);
            sw.WriteLine("sparity:" + sparity.Text);
            sw.WriteLine("key1:" + op.key1w.Text);
            sw.WriteLine("key2:" + op.key2w.Text);
            sw.WriteLine("key3:" + op.key3w.Text);
            sw.WriteLine("key4:" + op.key4w.Text);
            sw.WriteLine("key5:" + op.key5w.Text);
            sw.WriteLine("key6:" + op.key6w.Text);
            if (radioButton2.Checked == true)
                sw.WriteLine("sendstring:true");
            else
                sw.WriteLine("sendstring:false");
            if (radioButton4.Checked == true)
                sw.WriteLine("readstring:true");
            else
                sw.WriteLine("readstring:false");
            if (checkBox1.Checked == true)
                sw.WriteLine("0D 0A:true");
            else
                sw.WriteLine("0D 0A:false");
            sw.WriteLine("startsymbol:" + op.startsymbol.Text);
            sw.WriteLine("stopsymbol:" + op.stopsymbol.Text);
            sw.WriteLine("variable1:" + textBox1.Text);
            sw.WriteLine("variable2:" + textBox3.Text);
            sw.WriteLine("variable3:" + textBox5.Text);
            sw.WriteLine("variable4:" + textBox8.Text);
            sw.WriteLine("variable5:" + textBox9.Text);
            sw.WriteLine("v1value:" + textBox2.Text);
            sw.WriteLine("v2value:" + textBox4.Text);
            sw.WriteLine("v3value:" + textBox6.Text);
            sw.WriteLine("v4value:" + textBox10.Text);
            sw.WriteLine("v5value:" + textBox11.Text);
            sw.WriteLine("customvalue1:" + textBox12.Text);
            sw.WriteLine("customvalue2:" + textBox13.Text);
            sw.WriteLine("customvalue3:" + textBox14.Text);
            sw.WriteLine("customvalue4:" + textBox15.Text);
            sw.WriteLine("customvalue5:" + textBox16.Text);
            sw.WriteLine("cycle:" + textBox17.Text);
            if (radioButton5.Checked == true)
                sw.WriteLine("customhex:true");
            else
                sw.WriteLine("customhex:false");
            if (checkBox2.Checked == true)
                sw.WriteLine("checked1:true");
            else
                sw.WriteLine("checked1:false");
            if (checkBox3.Checked == true)
                sw.WriteLine("checked2:true");
            else
                sw.WriteLine("checked2:false");
            if (checkBox4.Checked == true)
                sw.WriteLine("checked3:true");
            else
                sw.WriteLine("checked3:false");
            if (checkBox5.Checked == true)
                sw.WriteLine("checked4:true");
            else
                sw.WriteLine("checked4:false");
            if (checkBox6.Checked == true)
                sw.WriteLine("checked5:true");
            else
                sw.WriteLine("checked5:false");
            sw.Close();
            fs1.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int s;
                string data1 = Convert.ToString(Convert.ToInt32(textBox2.Text), 16);
                for (s = data1.Length; s < 4; s++)
                    data1 = "0" + data1;
                string data2 = Convert.ToString(Convert.ToInt32(textBox4.Text), 16);
                for (s = data2.Length; s < 4; s++)
                    data2 = "0" + data2;
                string data3 = Convert.ToString(Convert.ToInt32(textBox6.Text), 16);
                for (s = data3.Length; s < 4; s++)
                    data3 = "0" + data3;
                string data4 = Convert.ToString(Convert.ToInt32(textBox10.Text), 16);
                for (s = data4.Length; s < 4; s++)
                    data4 = "0" + data4;
                string data5 = Convert.ToString(Convert.ToInt32(textBox11.Text), 16);
                for (s = data5.Length; s < 4; s++)
                    data5 = "0" + data5;
                textBox7.Text = data1 + data2 + data3 + data4 + data5 + "0d0a";
                string dataa = data1 + data2 + data3 + data4 + data5 + "0d0a";
                for (s = 0; s < (dataa.Length * 3 / 2); s = s + 3)
                    textBox7.Text = textBox7.Text.Insert(s, " ");
                textBox7.Text = textBox7.Text.Substring(1);
                sendhex(textBox7.Text);
            }
            catch (System.Exception ex)//若发生错误
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                sendhex(textBox12.Text);
            else
                sp1.WriteLine(textBox12.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                sendhex(textBox13.Text);
            else
                sp1.WriteLine(textBox13.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                sendhex(textBox14.Text);
            else
                sp1.WriteLine(textBox14.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                sendhex(textBox15.Text);
            else
                sp1.WriteLine(textBox15.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                sendhex(textBox16.Text);
            else
                sp1.WriteLine(textBox16.Text);
        }
        bool istime = true;
        int[] wei = new int[5];
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (istime)
                {
                    wei[0] = 0;
                    wei[1] = 0;
                    wei[2] = 0;
                    wei[3] = 0;
                    wei[4] = 0;
                    timer1.Interval = Convert.ToInt32(textBox17.Text);
                    timer1.Start();
                    istime = !istime;
                    button8.Text = "停止";
                    openbutton.Enabled = false;
                }
                else
                {
                    timer1.Stop();
                    istime = !istime;
                    button8.Text = "开始";
                    openbutton.Enabled = true;
                }
            }
            catch (System.Exception ex)//若发生错误
            {
                timer1.Stop();
                MessageBox.Show(ex.Message, "出错提示");
                send.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                button3_Click(null, null);
                checkBox2.Checked = false;
                wei[0] = 1;
            }
            else if (checkBox3.Checked)
            {
                button4_Click(null, null);
                checkBox3.Checked = false;
                wei[1] = 1;
            }
            else if (checkBox4.Checked)
            {
                button5_Click(null, null);
                checkBox4.Checked = false;
                wei[2] = 1;
            }
            else if (checkBox5.Checked)
            {
                button6_Click(null, null);
                checkBox5.Checked = false;
                wei[3] = 1;
            }
            else if (checkBox6.Checked)
            {
                button7_Click(null, null);
                checkBox6.Checked = false;
                wei[4] = 1;
            }
            else
            {
                if (wei[0] == 1) checkBox2.Checked = true;
                if (wei[1] == 1) checkBox3.Checked = true;
                if (wei[2] == 1) checkBox4.Checked = true;
                if (wei[3] == 1) checkBox5.Checked = true;
                if (wei[4] == 1) checkBox6.Checked = true;
                if (checkBox2.Checked == true)
                {
                    button3_Click(null, null);
                    checkBox2.Checked = false;
                    wei[0] = 1;
                }
                else if (checkBox3.Checked)
                {
                    button4_Click(null, null);
                    checkBox3.Checked = false;
                    wei[1] = 1;
                }
                else if (checkBox4.Checked)
                {
                    button5_Click(null, null);
                    checkBox4.Checked = false;
                    wei[2] = 1;
                }
                else if (checkBox5.Checked)
                {
                    button6_Click(null, null);
                    checkBox5.Checked = false;
                    wei[3] = 1;
                }
                else if (checkBox6.Checked)
                {
                    button7_Click(null, null);
                    checkBox6.Checked = false;
                    wei[4] = 1;
                }
            }
        }

        private void 功能键设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            st.ShowDialog();
            reset();
        }

        public void sendhex(string a)
        {
            try
            { 
            string sendBuf = a;
            string sendnoNull = sendBuf.Trim();
            string sendNOComma = sendnoNull.Replace(',', ' '); //去掉英文逗号 
            string sendNOComma1 = sendNOComma.Replace('，', ' '); //去掉中文逗号 
            string strSendNoComma2 = sendNOComma1.Replace("0x", ""); //去掉0x 
            strSendNoComma2.Replace("0X", ""); //去掉0X 
            string[] strArray = strSendNoComma2.Split(' ');
            int byteBufferLength = strArray.Length;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] == "")
                {
                    byteBufferLength--;
                }
            }

            byte[] byteBuffer = new byte[byteBufferLength];
            int ii = 0;
            for (int i = 0; i < strArray.Length; i++) //对获取的字符做相加运算 
            {
                Byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]);
                int decNum = 0;
                if (strArray[i] == "")
                {
                    continue;
                }
                else
                {
                    decNum = Convert.ToInt32(strArray[i], 16);
                }
                try //防止输错，使其只能输入一个字节的字符，即只能在txtSend里输入 “eb 90”等字符串，不能输入“123 2345”等超出字节范围的数字 
                {
                    byteBuffer[ii] = Convert.ToByte(decNum);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("字节越界，请逐个字节输入！", "Error");
                    return;
                }
                ii++;
            }
            sp1.Write(byteBuffer, 0, byteBuffer.Length);
            }
            catch (System.Exception ex)//若发生错误
            {
                MessageBox.Show(ex.Message, "出错提示");
                send.Text = "";
            }
        }
        private void readsetting(StreamReader a,Button b)
        {
            b.Text = a.ReadLine().Substring(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (settinghex[0])
                sendhex(settingkey[0]);
            else
                sp1.WriteLine(settingkey[0]);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (settinghex[1])
                sendhex(settingkey[1]);
            else
                sp1.WriteLine(settingkey[1]);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (settinghex[2])
                sendhex(settingkey[2]);
            else
                sp1.WriteLine(settingkey[2]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (settinghex[3])
                sendhex(settingkey[3]);
            else
                sp1.WriteLine(settingkey[3]);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (settinghex[4])
                sendhex(settingkey[4]);
            else
                sp1.WriteLine(settingkey[4]);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (settinghex[5])
                sendhex(settingkey[5]);
            else
                sp1.WriteLine(settingkey[5]);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (settinghex[6])
                sendhex(settingkey[6]);
            else
                sp1.WriteLine(settingkey[6]);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (settinghex[7])
                sendhex(settingkey[7]);
            else
                sp1.WriteLine(settingkey[7]);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (settinghex[8])
                sendhex(settingkey[8]);
            else
                sp1.WriteLine(settingkey[8]);
        }

        public void reset()//装载自定义按键
        {
            if (File.Exists("setting.txt"))
            {
                FileStream fs = new FileStream("setting.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[0] = true;
                button10.Text = sr.ReadLine().Substring(9);
                settingkey[0]= sr.ReadLine().Substring(8);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[1] = true;
                button14.Text = sr.ReadLine().Substring(9);
                settingkey[1] = sr.ReadLine().Substring(8);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[2] = true;
                button17.Text = sr.ReadLine().Substring(9);
                settingkey[2] = sr.ReadLine().Substring(8);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[3] = true;
                button9.Text = sr.ReadLine().Substring(9);
                settingkey[3] = sr.ReadLine().Substring(8);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[4] = true;
                button13.Text = sr.ReadLine().Substring(9);
                settingkey[4] = sr.ReadLine().Substring(8);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[5] = true;
                button16.Text = sr.ReadLine().Substring(9);
                settingkey[5] = sr.ReadLine().Substring(8);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[6] = true;
                button11.Text = sr.ReadLine().Substring(9);
                settingkey[6] = sr.ReadLine().Substring(8);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[7] = true;
                button12.Text = sr.ReadLine().Substring(9);
                settingkey[7] = sr.ReadLine().Substring(8);

                if (sr.ReadLine().Substring(8) == "true")
                    settinghex[8] = true;
                button15.Text = sr.ReadLine().Substring(9);
                settingkey[8] = sr.ReadLine().Substring(8);

                sr.Close();
                fs.Close();
            }     
        }
        public void able()
        {
            sendbutton.Enabled = true;
            refreshbutton.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
        }

        private void 机器人1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            loading ld = new loading();
            if (ld.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                ld.Close();
            }
        }

        public void enable()
        {
            sendbutton.Enabled = false;
            refreshbutton.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
        }
    }

    }
