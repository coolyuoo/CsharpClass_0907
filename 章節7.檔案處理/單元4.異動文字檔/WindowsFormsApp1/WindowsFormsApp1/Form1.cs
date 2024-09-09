using System;
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




        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string start = textBox1.Text;

                string dest = textBox2.Text;




                if (File.Exists(start))
                {
                    MessageBox.Show("start不存在");

                    return;
                }

                if (File.Exists(dest))
                {
                    MessageBox.Show("dest不存在");

                    return;
                }

                File.Copy(start, dest, true);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string start = textBox1.Text;

                string dest = textBox2.Text;


                if (File.Exists(start))
                {
                    MessageBox.Show("start不存在");

                    return;
                }

                if (File.Exists(dest))
                {
                    MessageBox.Show("dest不存在");

                    return;
                }

                File.Move(start, dest);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(textBox3.Text);
        }
    }
}
