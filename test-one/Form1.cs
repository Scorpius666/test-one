using System;
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
                int op2Number = int.Parse(this.textBoxOP2.Text);//将文本框中的text转为int以进行数学运算
                int result = op1Number + op2Number;
                this.labelResult.Text = result.ToString();

            }
            catch(Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
          
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            try
            {
                int opNumber1 = int.Parse(this.textBoxOP1.Text);
                int opNumber2 = int.Parse(this.textBoxOP2.Text);
                int result = opNumber1 - opNumber2;
                this.labelResult.Text = result.ToString();
            }
            catch(Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            try
            {
                int opNumber1 = int.Parse(this.textBoxOP1.Text);
                int opNumber2 = int.Parse(this.textBoxOP2.Text);
                int result = opNumber1 * opNumber2;
                this.labelResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            try
            {
                int opNumber1 = int.Parse(this.textBoxOP1.Text);
                int opNumber2 = int.Parse(this.textBoxOP2.Text);
                int result = opNumber1 / opNumber2;
                this.labelResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
        }
    }
}
