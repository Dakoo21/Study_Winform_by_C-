using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitHandelEvent();
        }

        private void InitHandelEvent()
        {
            tbox_Result.TextChanged += tbox_Result_TextChanged;
            btn_shfit_Left.Click += btn_shfit_Left_Click;
            btn_Shift_Right.Click += btn_shift_Right_Click;
            btn_Add_Assign.Click += btn_Add_Assign_Click;
            btn_Sub_Assign.Click += btn_Sub_Assign_Click;
            btn_PreIncrement.Click += btn_PreIncrement_Click;
            btn_PostIncrement.Click += btn_PostIncrement_Click;
            btn_BitwiseAnd.Click += btn_BitwiseAnd_Click;
            btn_Logical_Or.Click += btn_Logical_Or_Click;
        }

        private void tbox_Result_TextChanged(object sender, EventArgs e)
        {
            if (!parseCheck(tbox_Result.Text))
            {
                return;
            }

            tbox_Result_Bit.Text = Convert.ToString(int.Parse(tbox_Result.Text), 2);
        }

        private void btn_shfit_Left_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = 0;
            int iNumber = 0;

            if (string.IsNullOrEmpty(tbox_Result.Text) && string.IsNullOrEmpty(tbox_Num.Text))
            {
                errorAlrem("Result 혹은 Num에 입력하지 않았습니다.");
                return;
            }

            if (parseCheck(tbox_Result.Text))
            {
                iTemp = convertToInt(tbox_Result.Text);
            }
            else
            {
                errorAlrem($"Result에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result.Text})");
            }

            if (parseCheck(tbox_Num.Text))
            {
                iNumber = convertToInt(tbox_Num.Text);
            }
            else
            {
                errorAlrem($"Number에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Num.Text})");
            }

            iResult = iTemp << iNumber;
            tbox_Result.Text = convertToString(iResult);
        }

        private void btn_shift_Right_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = 0;
            int iNumber = 0;
            if (string.IsNullOrEmpty(tbox_Result.Text) && string.IsNullOrEmpty(tbox_Num.Text))
            {
                errorAlrem("Result 혹은 Num에 입력하지 않았습니다.");
                return;
            }
            if (parseCheck(tbox_Result.Text))
            {
                iTemp = convertToInt(tbox_Result.Text);
            }
            else
            {
                errorAlrem($"Result에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result.Text})");
            }
            if (parseCheck(tbox_Num.Text))
            {
                iNumber = convertToInt(tbox_Num.Text);
            }
            else
            {
                errorAlrem($"Number에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Num.Text})");
            }
            iResult = iTemp >> iNumber;
            tbox_Result.Text = convertToString(iResult);
        }

        private void btn_Add_Assign_Click(object sender, EventArgs e)
        {
            int iTemp = 0;
            int iNumber = 0;

            if (string.IsNullOrEmpty(tbox_Result.Text) && string.IsNullOrEmpty(tbox_Num.Text))
            {
                errorAlrem("Result 혹은 Num에 입력하지 않았습니다.");
                return;
            }

            if (parseCheck(tbox_Result.Text))
            {
                iTemp = convertToInt(tbox_Result.Text);
            }
            else
            {
                errorAlrem($"Result에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result.Text})");
            }

            if (parseCheck(tbox_Num.Text))
            {
                iNumber = convertToInt(tbox_Num.Text);
            }
            else
            {
                errorAlrem($"Number에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Num.Text})");
            }

            iTemp += iNumber;
            tbox_Result.Text = convertToString(iTemp);
        }

        private void btn_Sub_Assign_Click(object sender, EventArgs e)
        {
            int iTemp = 0;
            int iNumber = 0;

            if (string.IsNullOrEmpty(tbox_Result.Text) && string.IsNullOrEmpty(tbox_Num.Text))
            {
                errorAlrem("Result 혹은 Num에 입력하지 않았습니다.");
                return;
            }

            if (parseCheck(tbox_Result.Text))
            {
                iTemp = convertToInt(tbox_Result.Text);
            }
            else
            {
                errorAlrem($"Result에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result.Text})");
            }

            if (parseCheck(tbox_Num.Text))
            {
                iNumber = convertToInt(tbox_Num.Text);
            }
            else
            {
                errorAlrem($"Number에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Num.Text})");
            }
            iTemp -= iNumber;
            tbox_Result.Text = convertToString(iTemp);
        }

        private void btn_PreIncrement_Click(object sender, EventArgs e)
        {
            int iTemp = 0;

            if (string.IsNullOrEmpty(tbox_Result.Text))
            {
                errorAlrem("Result에 입력하지 않았습니다.");
                return;
            }

            if (parseCheck(tbox_Result.Text))
            {
                iTemp = convertToInt(tbox_Result.Text);
            }
            else
            {
                errorAlrem($"Result에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result.Text})");
            }

            tbox_Result.Text = convertToString(++iTemp);
            tbox_Result_After.Text = convertToString(iTemp);
        }

        private void btn_PostIncrement_Click(object sender, EventArgs e)
        {
            int iTemp = 0;

            if (string.IsNullOrEmpty(tbox_Result.Text))
            {
                errorAlrem("Result에 입력하지 않았습니다.");
                return;
            }

            if (parseCheck(tbox_Result.Text))
            {
                iTemp = convertToInt(tbox_Result.Text);
            }
            else
            {
                errorAlrem($"Result에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result.Text})");
            }

            tbox_Result.Text = convertToString(iTemp++);
            tbox_Result_After.Text = convertToString(iTemp);
        }

        private void btn_BitwiseAnd_Click(object sender, EventArgs e)
        {
            int iTemp1 = 0;
            int iTemp2 = 0;
            int iNumber = 0;

            if (string.IsNullOrEmpty(tbox_Result.Text) && string.IsNullOrEmpty(tbox_Result_After.Text) && string.IsNullOrEmpty(tbox_Num.Text))
            {
                errorAlrem("Result, Result After 혹은 Num에 입력하지 않았습니다.");
                return;
            }

            if(parseCheck(tbox_Result.Text))
            {
                iTemp1 = convertToInt(tbox_Result.Text);
            }
            else
            {
                errorAlrem($"Result에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result.Text})");
            }

            if(parseCheck(tbox_Result_After.Text))
            {
                iTemp2 = convertToInt(tbox_Result_After.Text);
            }
            else
            {
                errorAlrem($"Result After에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result_After.Text})");
            }

            if(parseCheck(tbox_Num.Text))
            {
                iNumber = convertToInt(tbox_Num.Text);
            }
            else
            {
                errorAlrem($"Number에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Num.Text})");
            }

            bool bResult = (iTemp1 > iNumber && iTemp2 > iNumber);

            tbox_And_Or.Text = bResult.ToString();
        }

        private void btn_Logical_Or_Click(object sender, EventArgs e)
        {
            int iTemp1 = 0;
            int iTemp2 = 0;
            int iNumber = 0;
            if (string.IsNullOrEmpty(tbox_Result.Text) && string.IsNullOrEmpty(tbox_Result_After.Text) && string.IsNullOrEmpty(tbox_Num.Text))
            {
                errorAlrem("Result, Result After 혹은 Num에 입력하지 않았습니다.");
                return;
            }

            if (parseCheck(tbox_Result.Text))
            {
                iTemp1 = convertToInt(tbox_Result.Text);
            }
            else
            {
                errorAlrem($"Result에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result.Text})");
            }

            if (parseCheck(tbox_Result_After.Text))
            {
                iTemp2 = convertToInt(tbox_Result_After.Text);
            }
            else
            {
                errorAlrem($"Result After에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Result_After.Text})");
            }

            if (parseCheck(tbox_Num.Text))
            {
                iNumber = convertToInt(tbox_Num.Text);
            }
            else
            {
                errorAlrem($"Number에는 숫자만 입력 가능합니다.\n (입력값: {tbox_Num.Text})");
            }

            bool bResult = (iTemp1 > iNumber || iTemp2 > iNumber);
            tbox_And_Or.Text = bResult.ToString();
        }

        private bool parseCheck(string parm)
        {
            if (int.TryParse(parm, out int nValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int convertToInt(string parm)
        {
            return Convert.ToInt32(parm);
        }

        private string convertToString(int parm)
        {
            return parm.ToString();
        }

        private void errorAlrem(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
