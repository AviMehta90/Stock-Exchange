using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_exchange
{
    public partial class number : Form
    {
        public number()
        {
            InitializeComponent();
        }
        int count=2;
        private void button1_Click(object sender, EventArgs e)
        {
            count = count + 1; pl3.Visible = true;
            pln3.Visible = true;
            ad3.Visible = true;
            mn3.Visible = true;
            button1.Visible = false;
        }

        private void ad4_Click(object sender, EventArgs e)
        {
            count = count + 1; pl4.Visible = true;
            pln4.Visible = true;
            ad4.Visible = true;
            mn4.Visible = true;
            ad3.Visible = false;
            mn3.Visible = false;
        }

        private void a_Click(object sender, EventArgs e)
        {
            count = count + 1; pl5.Visible = true;
            pln5.Visible = true;
            ad5.Visible = true;
            mn5.Visible = true;
            ad4.Visible = false;
            mn4.Visible = false;
        }

        private void ad6_Click(object sender, EventArgs e)
        {
            count = count + 1; pl6.Visible = true;
            pln6.Visible = true;
            ad6.Visible = true;
            mn6.Visible = true;
            ad5.Visible = false;
            mn5.Visible = false;
        }

        private void ad7_Click(object sender, EventArgs e)
        {
            count = count + 1; pl7.Visible = true;
            pln7.Visible = true;
            ad7.Visible = true;
            mn7.Visible = true;
            ad6.Visible = false;
            mn6.Visible = false;
        }

        private void mn8_Click(object sender, EventArgs e)
        {
            count = count + 1; pl8.Visible = true;
            pln8.Visible = true;
          //  ad7.Visible = true;
            mn8.Visible = true;
           // mn7.Visible = true;
            ad7.Visible = false;
            mn7.Visible = false;
        }

        private void mn8_Click_1(object sender, EventArgs e)
        {
            count = count - 1; pl8.Visible = false;
            pln8.Visible = false;
            mn8.Visible = false;
            ad7.Visible = true;
            mn7.Visible = true;
            pln8.Text = "";
            mn8.Visible = false;
        }

        private void mn7_Click(object sender, EventArgs e)
        {
            count = count - 1; pl7.Visible = false;
            pln7.Visible = false;
            mn7.Visible = false;
            ad6.Visible = true;
            mn6.Visible = true;
            pln7.Text = "";
            mn7.Visible = false;
            ad7.Visible = false;
        }

        private void mn6_Click(object sender, EventArgs e)
        {
            count = count - 1; ad6.Visible = false; mn6.Visible = false; pl6.Visible = false;
            pln6.Visible = false;
            mn6.Visible = false;
            ad5.Visible = true;
            mn5.Visible = true;
            pln6.Text = "";
        }

        private void mn5_Click(object sender, EventArgs e)
        {
            count = count - 1; ad5.Visible = false; mn5.Visible = false; pl5.Visible = false;
            pln5.Visible = false;
            mn5.Visible = false;
            ad4.Visible = true;
            mn4.Visible = true;
            pln5.Text = "";
        }

        private void mn4_Click(object sender, EventArgs e)
        {
            count = count - 1; ad4.Visible = false; mn4.Visible = false; pl4.Visible = false;
            pln4.Visible = false;
            mn4.Visible = false;
            ad3.Visible = true;
            mn3.Visible = true;
            pln4.Text = "";
        }

        private void mn3_Click(object sender, EventArgs e)
        {
            count = count - 1; ad3.Visible = false; mn3.Visible = false; pl3.Visible = false;
            pln3.Visible = false;
            mn3.Visible = false;
            button1.Visible = true;
           
            pln3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(textBox1.Text, textBox2.Text, pln3.Text, pln4.Text, pln5.Text, pln6.Text, pln7.Text, pln8.Text, comboBox1.Text, count);
            f.Show();
            
            this.Hide();

        }

        private void number_Load(object sender, EventArgs e)
        {

        }

        private void number_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
