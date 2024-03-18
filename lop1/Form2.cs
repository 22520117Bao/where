using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lop1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int t;
            Console.WriteLine(textBox1.Text);
            t = int.Parse(textBox1.Text);
            switch(t)
            {
                case 0:
                    textBox2.Text = "khong";
                    break;
                case 1:
                    textBox2.Text = "mot";
                    break;
                case 2:
                    textBox2.Text = "hai";
                    break;
                case 3:
                    textBox2.Text = "ba";
                    break;
                case 4:
                    textBox2.Text = "bon";
                    break;
                case 5:
                    textBox2.Text = "năm";
                    break;
                case 6:
                    textBox2.Text = "sau";
                    break;
                case 7:
                    textBox2.Text = "bay";
                    break;
                case 8:
                    textBox2.Text = "tam" ;
                    break;
                case 9:
                    textBox2.Text = "chin";
                    break;

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
