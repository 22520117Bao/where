using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lop1
{
    public partial class lab1 : Form
    {
        public lab1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2 , num3;
            long ln = 0;
            long nh = 0;
            num1 = Int32.Parse(textBox1.Text.Trim());
            num2 = Int32.Parse(textBox2.Text.Trim());
            num3 = Int32.Parse(textBox3.Text.Trim());
            if(num1 > num2 && num1 > num3)
            {
                ln = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                ln = num2;
            }
            else
            {
                ln = num3;
            }
            if (num1 < num2 && num1 < num3)
            {
                nh = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                nh = num2;
            }
            else
            {
                nh = num3;
            }
            textBox6.Text = ln.ToString();
            textBox7.Text = nh.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
