using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string excelPath = "";

        List<List<string>> memberList = new List<List<string>>();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (var workbook = new XLWorkbook(excelPath))
                {
                    var worksheet = workbook.Worksheet(1); // 讀取指定工作表

                    var rowCount = worksheet.LastRowUsed().RowNumber();
                    var colCount = worksheet.LastColumnUsed().ColumnNumber();

                    for (int row = 1; row <= rowCount; row++)
                    {
                        var a = new List<string>();

                        for (int col = 1; col <= colCount; col++)
                        {
                            var cellValue = worksheet.Cell(row, col).Value;

                            a.Add(cellValue.ToString());
                        }

                        memberList.Add(a);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // 設置過濾器來允許特定文件類型
            openFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";


            openFileDialog1.InitialDirectory = "D:\\"; // 更改為你的初始路徑

            // 如果用戶選擇了一個文件，則顯示其路徑
            DialogResult x = openFileDialog1.ShowDialog();

            if (x == DialogResult.OK)
            {
                excelPath = openFileDialog1.FileName;

                MessageBox.Show(excelPath);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            List<string> rowList = new List<string>();

            foreach (List<string> memberInfo in memberList)
            {

                string row = string.Empty;

                foreach (var item in memberInfo)
                {
                    row += item + ",";
                }


                rowList.Add(row);   
            }

            textBox1.Lines = rowList.ToArray();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> rowList = new List<string>();

            foreach (List<string> memberInfo in memberList)
            {

                string row = string.Join(",", memberInfo);

             
                rowList.Add(row);
            }

            textBox1.Lines = rowList.ToArray();
        }
    }
}
