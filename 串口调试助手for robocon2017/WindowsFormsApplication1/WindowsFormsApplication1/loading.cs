using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class loading : Form
    {
        int i = 0;
        public loading()
        {
            InitializeComponent();
            label1.Text = "正在加载.";
            timer1.Start();
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text += ".";
            if (i == 2)
                label1.Text = "初始化界面";
            if (i == 4)
                label1.Text = "正在启动";
            if (i == 5)
            {
                this.Close();
            }
        }

        private void loading_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
