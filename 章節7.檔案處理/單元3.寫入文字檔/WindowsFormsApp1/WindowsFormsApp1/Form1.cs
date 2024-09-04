using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>
            {
                "鉛筆",
                "鉛筆盒",
                "橡皮擦",
                "墊板"
            };

        string path = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.檔案處理\temp\文具2.txt";


        private void button1_Click(object sender, EventArgs e)
        {
            string p = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.檔案處理\temp\文具.txt";


            File.Create(p);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.檔案處理\temp\文具2.txt";

            File.WriteAllText(x, textBox1.Text);

        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            string x = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.檔案處理\temp\文具2.txt";

            File.WriteAllText(x, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.檔案處理\temp\文具2.txt";


            File.AppendAllText(x, textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string x = string.Empty;

            for (int i = 0; i < list.Count; i++)
            {
                x += list[i] + "\r\n";
            }

            File.WriteAllText(path, x);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string x2 = "";

            foreach (var item in list)
            {
                x2 += item + Environment.NewLine;
            }

            File.WriteAllText(path, x2);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //陣列轉字串的語法
            string y = string.Join("\n", list);

            File.WriteAllText(path, y);

        }
    }
}
