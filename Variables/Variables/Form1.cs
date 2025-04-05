using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg;
            msg = this.textBox1.Text;
            MessageBox.Show($"Hi {msg}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int a1 = Convert.ToInt32(this.textBox2.Text);
            //int a2 = Convert.ToInt32(this.textBox3.Text);
            int.TryParse(this.textBox2.Text, out int a1);
            int.TryParse(this.textBox3.Text, out int a2);
            int a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long.TryParse(this.textBox2.Text, out long a1);
            long.TryParse(this.textBox3.Text, out long a2);
            long a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float.TryParse(this.textBox2.Text, out float a1);
            float.TryParse(this.textBox3.Text, out float a2);
            float a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double.TryParse(this.textBox2.Text, out double a1);
            double.TryParse(this.textBox3.Text, out double a2);
            double a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal.TryParse(this.textBox2.Text, out decimal a1);
            decimal.TryParse(this.textBox3.Text, out decimal a2);
            decimal a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Boolean b;
            b = this.button6.Enabled;
            MessageBox.Show(b.ToString());
        }
    }
}
