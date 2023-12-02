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
    public partial class Finalfoamcs : Form
    {
        public Finalfoamcs()
        {
            InitializeComponent();
        }
        public string ss;
        public int valc;
        public string set(string s)
        {
            ss = s;
           
            return ss;
        }
        private void Finalfoamcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss = set("ss1");
            valc = 25;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ss = "ss2";
            valc = 35;
           this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ss = "ss3";
            valc = 45;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ss = "ss4";
            valc = 55;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ss = "ss5";
            valc = 65;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ss = "ss6";
            valc = 75;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ss = "ss7";
            valc = 85;
            this.Close();
        }
    }
}
