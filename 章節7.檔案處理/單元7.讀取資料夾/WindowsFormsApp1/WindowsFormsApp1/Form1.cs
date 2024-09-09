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

        string directoryPath = @"D:\CodeProject\線下教學\student\C# Basic Tutorial Course File\章節7.檔案處理\temp\百貨資料";

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("資料夾不存在");
            }
            else
            {
                MessageBox.Show("資料夾存在");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directoryPath))
            {
                List<string> files = Directory.GetFiles(directoryPath).ToList();

                foreach (string item in files)
                {
                    textBox1.Text += item + "\r\n";
                }
            }
            else
            {
                MessageBox.Show("資料夾不存在");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directoryPath))
            {
                List<string> directories = Directory.GetDirectories(directoryPath).ToList();

                foreach (string path in directories)
                {
                    textBox1.Text += path + "\r\n";
                }
            }
            else
            {
                MessageBox.Show("資料夾不存在");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directoryPath))
            {
                List<string> files = Directory.GetFiles(directoryPath).ToList();

                foreach (string item in files)
                {
                    if (item.Contains("具"))
                    {
                        textBox1.Text += item + "\r\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("資料夾不存在");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(directoryPath))
            {
                List<string> directories = Directory.GetDirectories(directoryPath).ToList();

                foreach (string path in directories)
                {
                    if (path.Contains("123"))
                    { 
                        textBox1.Text += path + "\r\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("資料夾不存在");
            }

        }
    }
}
