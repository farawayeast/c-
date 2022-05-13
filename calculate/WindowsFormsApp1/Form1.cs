using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strNum1 = textBox1.Text;
            if (string.IsNullOrEmpty(strNum1))
            {
                strNum1 = "0";
            }
            string strNum2 = textBox2.Text;
            if (string.IsNullOrEmpty(strNum2))
            {
                strNum2 = "0";
            }
            Double flNum1 = Convert.ToSingle(strNum1);
            Double flNum2 = Convert.ToSingle(strNum2);
            Double sum = flNum1 + flNum2;
            textBox3.Text = Convert.ToString(sum);
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string strNum1 = textBox1.Text;
            if (string.IsNullOrEmpty(strNum1))
            {
                strNum1 = "0";
            }
            string strNum2 = textBox2.Text;
            if (string.IsNullOrEmpty(strNum2))
            {
                strNum2 = "0";
            }
            Double flNum1 = Convert.ToSingle(strNum1);
            Double flNum2 = Convert.ToSingle(strNum2);
            Double result = flNum1 - flNum2;
            textBox3.Text = Convert.ToString(result);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string strNum1 = textBox1.Text;
            if (string.IsNullOrEmpty(strNum1))
            {
                strNum1 = "0";
            }
            string strNum2 = textBox2.Text;
            if (string.IsNullOrEmpty(strNum2))
            {
                strNum2 = "0";
            }
            Double flNum1 = Convert.ToSingle(strNum1);
            Double flNum2 = Convert.ToSingle(strNum2);
            Double result = flNum1 * flNum2;
            textBox3.Text = Convert.ToString(result);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string strNum1 = textBox1.Text;
            if (string.IsNullOrEmpty(strNum1))
            {
                strNum1 = "0";
            }
            string strNum2 = textBox2.Text;
            if (string.IsNullOrEmpty(strNum2))
            {
                strNum2 = "0";
            }
            Double flNum1 = Convert.ToSingle(strNum1);
            Double flNum2 = Convert.ToSingle(strNum2);
            Double result = flNum1/flNum2;
            textBox3.Text = Convert.ToString(result);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
