using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            textBox1.Text += "編號,姓名,電話,地址,性別" + "\r\n";
            textBox1.Text += "1,曉華,0931337938,台中市,男" + "\r\n";
            textBox1.Text += "2,小明,0955663322,台北市,女" + "\r\n";
            textBox1.Text += "3,魯夫,0955223366,台南市,男";


        }


        List<List<string>> memberList = new List<List<string>>();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // 創建一個新的 Excel 工作簿
                using (var workbook = new XLWorkbook())
                {
                    // 添加工作表
                    var worksheet = workbook.Worksheets.Add("Sample Sheet");

                    int row = 1;

                    foreach (List<string> memberInfo in memberList)
                    {
                        int column = 1;

                        foreach (string cellvalue in memberInfo)
                        {
                            worksheet.Cell(row, column).Value = cellvalue;

                            column++;
                        }

                        row++;
                    }

                    // 儲存工作簿
                    workbook.SaveAs("D:\\CodeProject\\線下教學\\student\\C# Basic Tutorial Course File\\章節7.檔案處理\\temp\\輸出\\SampleExcel.xlsx");
                }


                MessageBox.Show("匯出完畢");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }







        private void button3_Click_1(object sender, EventArgs e)
        {
            List<string> g = textBox1.Lines.ToList();

            foreach (string memberInfo in g)
            {
                List<string> ml = memberInfo.Split(',').ToList();

                memberList.Add(ml);
            }

        }

    }
}
