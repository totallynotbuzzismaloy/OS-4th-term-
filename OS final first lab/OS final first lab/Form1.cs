using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_final_first_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input_s = textBox1.Text;
                if (input_s == "0") textBox1.Text = "Error, необходимо ненулевое число";
                else
                {
                    double number = double.Parse(input_s);
                    number *= 2.0;
                    textBox1.Text = number.ToString();
                }
            }
            catch {}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string input_s = textBox1.Text;
                if (input_s == "0") textBox1.Text = "Error, нельзя делить на 0";
                else
                {
                    double number = double.Parse(input_s);
                    number /= 2.0;
                    textBox1.Text = number.ToString();
                }
            }
            catch {}
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "Пришел";
            button2.Text = "Ушел";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "multiply by 2";
            button2.Text = "divide by 2";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "multiply by 2";
            button2.Text = "divide by 2";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Text = "Пришел";
            button1.Text = "Ушел";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}