using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitEventHandlers();
        }

        private void InitEventHandlers()
        {
            tbox_Input_Num1.Click += tbox_Input_Num1_Click;
            tbox_Input_Num2.Click += tbox_Input_Num2_Click;
            btn_Plus.Click += btn_Puls_Click;
            btn_Minus.Click += btn_Minus_Click;
            btn_Multiply.Click += btn_Multiply_Click;
            btn_Division.Click += btn_Division_Click;
        }

        private void tbox_Input_Num1_Click(object sender, EventArgs e)
        {
            tbox_Input_Num1.Clear();
        }

        private void tbox_Input_Num2_Click(object sender, EventArgs e)
        {
            tbox_Input_Num2.Clear();
        }

        private void btn_Puls_Click(object sender, EventArgs e)
        {
            bool isValid = InputChekc(tbox_Input_Num1.Text, tbox_Input_Num2.Text);

            if (!isValid)
            {
                MessageBox.Show("Please enter valid numbers in both input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double num1 = double.Parse(tbox_Input_Num1.Text);
                double num2 = double.Parse(tbox_Input_Num2.Text);

                double result = num1 + num2;
                tbox_Result.Text = result.ToString();
            }
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
           bool isValid = InputChekc(tbox_Input_Num1.Text, tbox_Input_Num2.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter valid numbers in both input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double num1 = double.Parse(tbox_Input_Num1.Text);
                double num2 = double.Parse(tbox_Input_Num2.Text);
                double result = num1 - num2;
                tbox_Result.Text = result.ToString();
            }
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            bool isValid = InputChekc(tbox_Input_Num1.Text, tbox_Input_Num2.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter valid numbers in both input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double num1 = double.Parse(tbox_Input_Num1.Text);
                double num2 = double.Parse(tbox_Input_Num2.Text);
                double result = num1 * num2;
                tbox_Result.Text = result.ToString();
            }
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
           bool isValid = InputChekc(tbox_Input_Num1.Text, tbox_Input_Num2.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter valid numbers in both input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double num1 = double.Parse(tbox_Input_Num1.Text);
                double num2 = double.Parse(tbox_Input_Num2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double result = num1 / num2;
                    tbox_Result.Text = result.ToString();
                }
            }
        }

        private bool InputChekc(string input1, string input2)
        {
            if (double.TryParse(input1, out double outNum1) && double.TryParse(input2, out double outNum2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
