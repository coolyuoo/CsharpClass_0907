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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string xx = @"D:\CodeProject\線下教學\C# Basic Tutorial Course File\章節7.如何讀取外部檔案\temp\水果商品.txt";

        int i = 13;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(xx);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = xx.ToLower();

            MessageBox.Show(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xx = "已被修改ABC";

            MessageBox.Show(xx);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(i.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int y = i + 100;

            MessageBox.Show(y.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = 2500;

            MessageBox.Show(i.ToString());
        }
    }
}
