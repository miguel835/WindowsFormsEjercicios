﻿using System;
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
            
            MessageBox.Show(this.textBox2.Text + this.textBox3.Text);
        }
    }
}
