﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                int op1Number = int.Parse(this.textBoxOP1.Text);
                int op2Number = int.Parse(this.textBoxOP2.Text);
                this.labelResult.Text = this.textBoxOP1.Text + this.textBoxOP2.Text;
                int result = op1Number + op2Number;
                this.labelResult.Text = result.ToString();

            }
            catch(Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
          
        }
    }
}
