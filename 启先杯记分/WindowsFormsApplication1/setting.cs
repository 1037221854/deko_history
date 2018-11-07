using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            if (File.Exists("setting.txt"))
            {
                FileStream fs = new FileStream("setting.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                readset(sr, radioButton1, radioButton2, textBox1, textBox2);
                readset(sr, radioButton4, radioButton3, textBox4, textBox3);
                readset(sr, radioButton6, radioButton5, textBox6, textBox5);
                readset(sr, radioButton12, radioButton11, textBox12, textBox11);
                readset(sr, radioButton10, radioButton9, textBox10, textBox9);
                readset(sr, radioButton8, radioButton7, textBox8, textBox7);
                readset(sr, radioButton18, radioButton17, textBox18, textBox17);
                readset(sr, radioButton16, radioButton15, textBox16, textBox15);
                readset(sr, radioButton14, radioButton13, textBox14, textBox13);
                sr.Close();
                fs.Close();
            } 
        }

        private void setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs1 = new FileStream("setting.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
            StreamWriter sw = new StreamWriter(fs1);
            set(sw, radioButton1, radioButton2, textBox1, textBox2, "1");
            set(sw, radioButton4, radioButton3, textBox4, textBox3, "2");
            set(sw, radioButton6, radioButton5, textBox6, textBox5, "3");
            set(sw, radioButton12, radioButton11, textBox12, textBox11, "4");
            set(sw, radioButton10, radioButton9, textBox10, textBox9, "5");
            set(sw, radioButton8, radioButton7, textBox8, textBox7, "6");
            set(sw, radioButton18, radioButton17, textBox18, textBox17, "7");
            set(sw, radioButton16, radioButton15, textBox16, textBox15, "8");
            set(sw, radioButton14, radioButton13, textBox14, textBox13, "9");
            sw.Close();
            fs1.Close();
        }

        private void set(StreamWriter a,RadioButton b,RadioButton c,TextBox d,TextBox e,string i)  //保存单个组数据
        {
            if (b.Checked)
                a.WriteLine("set" + i + "hex:true");
            else
                a.WriteLine("set" + i + "hex:false");
            a.WriteLine("set" + i + "name:"+d.Text);
            a.WriteLine("set" + i + "key:" + e.Text);
        }

        private void readset(StreamReader a, RadioButton b, RadioButton c, TextBox d, TextBox e)  //读取单个组数据
        {
            c.Checked = true;
            if (a.ReadLine().Substring(8) == "true")
                b.Checked = true;
            d.Text = a.ReadLine().Substring(9);
            e.Text = a.ReadLine().Substring(8);
        }
    }
}
