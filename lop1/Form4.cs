using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lop1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gtribut_Click(object sender, EventArgs e)
        {
            long a = 1;
            long b = 1;
            long S1 = 0 ;
            long S2 = 0;
            double S3= 0;
            int t1 = int.Parse(txta.Text);
            int t2 = int.Parse(txtb.Text);
            for (int i = 1; i <= t1;i++)
            {
                a = a * i;
                
            }
            for (int i = 1; i <= t2; i++)
            {
                b = b * i;

            }
            for(int i = 0;i <= t1;i++)
            {
                S1 += i;
            }
            for (int i = 0; i <= t2; i++)
            {
                S2 += i;
            }
            for (int i = 1; i<=t2;i++)
            {
                S3 = S3 + Math.Pow(t1, i);

            }
            txtkq.Text = "A = "+ a +  "                        " +"B = "+ b+  
                   "\n"+"S1= 1+2+3+4+.....+A=  "+ S1 +
                   "\n"+"S2 = 1+2+3+4+...+B=   "+ S2 
                 + "\n"+"S3 = A^1+A^2+A^3+A^4+....+A^B = " + S3;

        }

        private void escbut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xoabut_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtkq.Text = "";
        }
    }
}
