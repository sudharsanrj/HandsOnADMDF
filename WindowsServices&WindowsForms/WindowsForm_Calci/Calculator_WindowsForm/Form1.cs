﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        int num1 = int.Parse(textBox1.Text);
                        int num2 = int.Parse(textBox2.Text);

                        int result = num1 + num2;

                        MessageBox.Show("Addition result is: " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please fill both the fields !!");
                    }
                }
                catch(Exception e1)
                {
                    MessageBox.Show("Please enter valid details");
                }
            }
        }

        private void SubtractButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SubtractButton.Checked)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        int num1 = int.Parse(textBox1.Text);
                        int num2 = int.Parse(textBox2.Text);

                        int result = num1 - num2;

                        MessageBox.Show("Subtraction result is: " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please fill both the fields !!");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Please enter valid details");
                }
            }
        }

        private void MultiplyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiplyButton.Checked)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        int num1 = int.Parse(textBox1.Text);
                        int num2 = int.Parse(textBox2.Text);

                        int result = num1 * num2;

                        MessageBox.Show("Multiplication result is: " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please fill both the fields !!");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Please enter valid details");
                }
            }
        }

        private void DivideButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DivideButton.Checked)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        double num1 = double.Parse(textBox1.Text);
                        double num2 = double.Parse(textBox2.Text);

                        double result = num1 / num2;
                        MessageBox.Show("Division result is: " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please fill both the fields !!");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Please enter valid details");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
