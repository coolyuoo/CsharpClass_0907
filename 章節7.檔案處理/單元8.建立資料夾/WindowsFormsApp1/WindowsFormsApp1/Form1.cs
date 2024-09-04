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


        private void button1_Click(object sender, EventArgs e)
        {

            string folderName = textBox1.Text;

            string folderPath = "D:\\" + folderName;

            try
            {
                // 嘗試建立資料夾
                Directory.CreateDirectory(folderPath);
                MessageBox.Show("資料夾建立成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("建立資料夾失敗：" + ex.Message);
            }
        }

    }
}
