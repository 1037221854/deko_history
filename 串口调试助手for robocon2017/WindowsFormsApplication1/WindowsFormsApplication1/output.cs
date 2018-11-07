using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class output : Form
    {
        public output()
        {
            InitializeComponent();
        }
        string path = null;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "excel|*.xlsx";
            ofd.ShowDialog();
            path = ofd.FileName.Replace(@"\",@"\\");
            textBox1.Text = path;
        }
        int k = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                XSSFWorkbook workbook;
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                workbook = new XSSFWorkbook(fileStream);
                ISheet sheet = workbook.GetSheetAt(0);
                IRow row;
                for (int i = 0; i < 10000; i++)  //对工作表每一行    上限10000组数据
                {
                    row = sheet.GetRow(i);   //row读入第i行数据  
                    if (row == null && k == 0)
                    {
                        sheet.CreateRow(i);
                        XSSFCell[] SheetCell = new XSSFCell[6];
                        row = sheet.GetRow(i);
                        for (int j = 0; j < 6; j++)
                            SheetCell[j] = (XSSFCell)row.CreateCell(j);
                        row = sheet.GetRow(i);
                        SheetCell[0].SetCellValue(key1w.Text);
                        SheetCell[1].SetCellValue(key2w.Text);
                        SheetCell[2].SetCellValue(key3w.Text);
                        SheetCell[3].SetCellValue(key4w.Text);
                        SheetCell[4].SetCellValue(key5w.Text);
                        SheetCell[5].SetCellValue(key6w.Text);
                        k = 1;
                    }
                    if (row == null && i != 0)
                    {
                        sheet.CreateRow(i);
                        row = sheet.GetRow(i);
                        XSSFCell[] SheetCell = new XSSFCell[6];
                        for (int j = 0; j < 6; j++)
                            SheetCell[j] = (XSSFCell)row.CreateCell(j);
                        row = sheet.GetRow(i);
                        SheetCell[0].SetCellValue(key1d.Text);
                        SheetCell[1].SetCellValue(key2d.Text);
                        SheetCell[2].SetCellValue(key3d.Text);
                        SheetCell[3].SetCellValue(key4d.Text);
                        SheetCell[4].SetCellValue(key5d.Text);
                        SheetCell[5].SetCellValue(key6d.Text);
                        break;
                    }
                }
                FileStream file = new FileStream(path, FileMode.Create);
                workbook.Write(file);
                file.Close();
                fileStream.Close();
                workbook.Close();
            }
            else
                MessageBox.Show("未浏览文件！", "Error");
        }

        bool yncheck = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if(!yncheck)
            {
                button4.Text = "停止导出";
                yncheck = !yncheck;
            }
            else
            {
                button4.Text = "连续导出";
                yncheck = !yncheck;
            }
        }

        private void datatimes_TextChanged(object sender, EventArgs e)
        {
            if (yncheck)
                button2_Click(null, null);
        }

        private void output_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void startsymbol_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
