using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lop1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txttien.Text);
            if (txtcb1.SelectedItem == "USD" && txtcb2.SelectedItem == "VND")
            {
                long c = i * 22772;
                string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", c);
                txtkq.Text = c.ToString();
               
            }

            if (txtcb1.SelectedItem == "EUR" && txtcb2.SelectedItem == "VND")
            {
                long c = i * 28132;
                string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", c);
                txtkq.Text = c.ToString();
              
            }

            if (txtcb1.SelectedItem == "GBP" && txtcb2.SelectedItem == "VND")
            {
                long c = i * 31538;
                string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", c);
                txtkq.Text = c.ToString();
                
            }

            if (txtcb1.SelectedItem == "SGD" && txtcb2.SelectedItem == "VND")
            {
                long c = i * 17286;
                string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", c);
                txtkq.Text = c.ToString();
               
            }

            if (txtcb1.SelectedItem == "JPY" && txtcb2.SelectedItem == "VND")
            {
                long c = i * 214;
                string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", c);
                txtkq.Text = c.ToString();
               
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
