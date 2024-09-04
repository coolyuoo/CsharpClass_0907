using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //請換成自己的路徑
        string xx = "D:\\CodeProject\\線下教學\\student\\C# Basic Tutorial Course File\\章節7.檔案處理\\temp\\水果商品.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            //檔案較小使用
            List<string> x = File.ReadAllLines(xx).ToList();

            foreach (var line in x)
            {
                MessageBox.Show(line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = File.ReadAllText(xx);
            
            MessageBox.Show(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool b = File.Exists(xx);

            if (b)
            {
                MessageBox.Show("有該檔案");
            }
            else
            {
                MessageBox.Show("無檔案");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(xx);

            MessageBox.Show(fileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetExtension(xx);

            MessageBox.Show(fileName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //檔案較大使用
            List<string> x = File.ReadLines(xx).ToList();

            foreach (var line in x)
            {
                MessageBox.Show(line);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //檔案較小使用
                List<string> x = File.ReadAllLines("").ToList();

                foreach (var line in x)
                {
                    MessageBox.Show(line);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string xx2 = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.檔案處理\temp\會員資料.txt";

            List<string> x = File.ReadAllLines(xx2).ToList();

            foreach (var line in x)
            {
                MessageBox.Show(line);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string xx2 = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.檔案處理\temp\會員資料.txt";

            List<string> x = File.ReadAllLines(xx2).ToList();

            int i = 0;

            foreach (var line in x)
            {
                

                if (i > 0)
                {
                    MessageBox.Show(line);
                }

                i++;
            }

        }

       
    }
}
