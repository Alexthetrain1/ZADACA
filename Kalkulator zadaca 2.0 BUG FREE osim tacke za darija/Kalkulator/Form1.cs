using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        double FirstNumber = 0;
        string Operation;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void bad_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
            label1.Text = "Second number";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
            label1.Text = "Second number";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
               
            FirstNumber = Convert.ToDouble(textBox1.Text);
           
            textBox1.Text = "0";
            Operation = "*";
            label1.Text = "Second number";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
            label1.Text = "Second number";
        }

        private void ndot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void nequal_Click(object sender, EventArgs e)
        {
            double SecondNumber=0;
            double Result;
            int repeat = 1;
            if (repeat!=0)
            {
                SecondNumber = Convert.ToDouble(textBox1.Text);
            }
            if (Operation == "+")
            {

                if (SecondNumber != 0 || FirstNumber!=0)
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox2.Text = Convert.ToString(Result);
                    

                    FirstNumber = 0;
                    SecondNumber = 0;
                    label1.Text = "First number";
                    textBox1.Text = "0";
                    repeat = 0;
                }
            }
            if (Operation == "-")
            {
                if (SecondNumber != 0 && FirstNumber != 0)
                {

                    Result = (FirstNumber - SecondNumber);
                    textBox2.Text = Convert.ToString(Result);
                    FirstNumber = 0;
                    SecondNumber = 0;
                    label1.Text = "First number";
                    textBox1.Text = "0";
                    repeat = 0;                
                }
                }
            if (Operation == "*")
            {
                if (SecondNumber != 0 && FirstNumber != 0)
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox2.Text = Convert.ToString(Result);
                    FirstNumber = 0;
                    SecondNumber = 0;
                    label1.Text = "First number";
                    textBox1.Text = "0";
                    repeat = 0;
                }
                }
            if (Operation == "/")
            {
                if (SecondNumber == 0 && FirstNumber ==0 )
                {
                    textBox2.Text = "Greska!";

                }
                else
                {
                    if (SecondNumber != 0 && FirstNumber != 0)
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox2.Text = Convert.ToString(Result);
                        FirstNumber = 1;
                        SecondNumber = 1;
                        label1.Text = "First number";
                        textBox1.Text = "0";
                        repeat = 0;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

