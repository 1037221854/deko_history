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
    public partial class 机器人设置 : Form
    {
        public 机器人设置()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button1.Text = textBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button2.Text = textBox4.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button3.Text = textBox6.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button4.Text = textBox8.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button5.Text = textBox10.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button7.Text = textBox12.Text;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button6.Text = textBox14.Text;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button8.Text = textBox16.Text;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button10.Text = textBox20.Text;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            ((机器人)Application.OpenForms["机器人"]).button11.Text = textBox22.Text;
        }

        private void 机器人设置_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs1 = new FileStream("r1set.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
            StreamWriter sw = new StreamWriter(fs1);
            set(sw, textBox1, textBox2, "1");
            set(sw, textBox4, textBox3, "2");
            set(sw, textBox6, textBox5,"3");
            set(sw, textBox8, textBox7,"4");
            set(sw, textBox10, textBox9,"5");
            set(sw, textBox12, textBox11,"6");
            set(sw, textBox14, textBox13,"7");
            set(sw, textBox16, textBox15,"8");
            set(sw, textBox20, textBox19,"9");
            set(sw, textBox22, textBox21,"10");
            sw.Close();
            fs1.Close();
            e.Cancel = true;
            this.Hide();
        }

        private void 机器人设置_Load(object sender, EventArgs e)
        {
            if (File.Exists("r1set.txt"))
            {
                FileStream fs = new FileStream("r1set.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                readset(sr, textBox1, textBox2);
                readset(sr, textBox4, textBox3);
                readset(sr, textBox6, textBox5);
                readset(sr, textBox8, textBox7);
                readset(sr, textBox10, textBox9);
                readset(sr, textBox12, textBox11);
                readset(sr, textBox14, textBox13);
                readset(sr, textBox16, textBox15);
                readset(sr, textBox20, textBox19);
                textBox22.Text = sr.ReadLine().Substring(10);
                textBox21.Text = sr.ReadLine().Substring(9);
                sr.Close();
                fs.Close();
            }
        }

        private void set(StreamWriter a, TextBox d, TextBox e, string i)  //保存单个组数据
        {
            a.WriteLine("set" + i + "name:" + d.Text);
            a.WriteLine("set" + i + "key:" + e.Text);
        }

        private void readset(StreamReader a, TextBox d, TextBox e)  //读取单个组数据
        {
            d.Text = a.ReadLine().Substring(9);
            e.Text = a.ReadLine().Substring(8);
        }
    }
}
