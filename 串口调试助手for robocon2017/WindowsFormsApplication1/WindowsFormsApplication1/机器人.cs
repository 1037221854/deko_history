using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class 机器人 : Form
    {
        机器人设置 robotset = new 机器人设置();
        private Bitmap buffer;
        public 机器人()
        {
            InitializeComponent();
            buffer = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void 机器人_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
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
                string data3 = Convert.ToString(Convert.ToInt32(textBox10.Text), 16);
                for (s = data3.Length; s < 4; s++)
                    data3 = "0" + data3;
                string data4 = Convert.ToString(Convert.ToInt32(textBox11.Text), 16);
                for (s = data4.Length; s < 4; s++)
                    data4 = "0" + data4;
                textBox7.Text = data1 + data2 + data3 + data4 + "0d0a";
                string dataa = data1 + data2 + data3 + data4 + "0d0a";
                for (s = 0; s < (dataa.Length * 3 / 2); s = s + 3)
                    textBox7.Text = textBox7.Text.Insert(s, " ");
                textBox7.Text = textBox7.Text.Substring(1);
                ((Form1)Application.OpenForms["Form1"]).sendhex(textBox7.Text);
            }
            catch (System.Exception ex)//若发生错误
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }


        private void 机器人_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void 机器人_FormClosed(object sender, FormClosedEventArgs e)
        {
            robotset.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox2.Text.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            robotset.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox3.Text.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox5.Text.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox7.Text.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox9.Text.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox11.Text.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox13.Text.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox15.Text.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox19.Text.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).sendhex(robotset.textBox21.Text.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("机器人1检测信息.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine("漏洞个数:" + label13.Text);
            sw.WriteLine("漏洞位置:" + textBox5.Text);
            sw.Close();
            fs1.Close();
        }
        int kk = 0;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            kk++;
            label13.Text = kk.ToString();
            label2.Text = "●";
            textBox5.SelectionStart = textBox5.TextLength;
            textBox5.ScrollToCaret();
            Graphics g = Graphics.FromImage(buffer);
            g.FillEllipse(new SolidBrush(Color.Red), v1, v2-3, 6, 6);
            pictureBox1.Image = buffer;
        }
        float v1 = 0, v2 = 440, v3 = 0, v4 = 440;

        private void 机器人_Shown(object sender, EventArgs e)
        {
            robotset.Show();
        }

        private void 机器人_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            buffer.Dispose();
            buffer = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = buffer;
        }

        private void 机器人_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (e.KeyCode == Keys.W)
                    button1_Click(null, null);
                if (e.KeyCode == Keys.S)
                    button4_Click(null, null);
                if (e.KeyCode == Keys.A)
                    button2_Click(null, null);
                if (e.KeyCode == Keys.D)
                    button3_Click(null, null);
                if (e.KeyCode == Keys.NumPad1)
                    button10_Click(null, null);
                if (e.KeyCode == Keys.NumPad4)
                    button6_Click(null, null);
                if (e.KeyCode == Keys.NumPad7)
                    button5_Click(null, null);
                if (e.KeyCode == Keys.NumPad2)
                    button11_Click(null, null);
                if (e.KeyCode == Keys.NumPad5)
                    button8_Click(null, null);
                if (e.KeyCode == Keys.NumPad8)
                    button7_Click(null, null);
            }
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
                v1 = v3;
                v2 = v4;
                int ik = label4.Text.IndexOf(",");
            if(ik!=-1 && label4.Text.Substring(ik + 1)!="")
            {
                v3 = Convert.ToSingle(label4.Text.Substring(0, ik))*4/10;
                v4 = 440 - Convert.ToSingle(label4.Text.Substring(ik + 1))*4/10;
                if(v1==0 && v2==440)
                {
                    v1 = v3;
                    v2 = v4;
                }
                Graphics g = Graphics.FromImage(buffer);
                g.DrawLine(new Pen(Color.Blue, 3), v1, v2, v3, v4);
                pictureBox1.Image = buffer;
                //g.Dispose();
            }
        }

    }
}
