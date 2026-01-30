using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Data_Type_Overflow
{
    public partial class lbl_Double_Title : Form
    {
        public lbl_Double_Title()
        {
            InitializeComponent();
            intitEventHandeler();
        }

        private void intitEventHandeler()
        {
            btn_Process_Change.Click += btnChange_Click;
            btn_Process_Short.Click += btnShort_Click;
            btn_Process_Int.Click += btnInt_Click;
            btn_Process_Double.Click += btnDouble_Click;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lbl_Exception.Text = "-";
            string inputData = tbox_Input_Num.Text;
            bool isNull = isInputNull(inputData);

            List<string> ok = new List<string>();
            List<string> fail = new List<string>();


            if (!isNull)
            {
                lbl_Exception.Text = "Input is null or empty.";
                return;
            }
            else
            {
                if (short.TryParse(inputData, out short shortResult))
                {
                    lbl_Short.Text = shortResult.ToString();
                    ok.Add("Short");
                }
                else
                {
                    fail.Add("Short");
                }

                if (int.TryParse(inputData, out int intResult))
                {
                    lbl_Int.Text = intResult.ToString();
                    ok.Add("Int");
                }
                else
                {
                    fail.Add("Int");
                }

                if (double.TryParse(inputData, out double doubleResult))
                {
                    lbl_Double.Text = doubleResult.ToString();
                    ok.Add("Double");
                }
                else
                {
                    fail.Add("Double");
                }

                if (ok.Count == 0)
                {
                    lbl_Exception.Text = "Input cannot be converted to any data type.";
                }
                else if(fail.Count > 0)
                {
                    lbl_Exception.Text = "Failed to convert to: " + string.Join(", ", fail) + ".";
                }
                else
                {
                    lbl_Exception.Text = "-";
                }

            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            lbl_Exception.Text = "-";
            string inputData = tbox_Input_Num.Text;
            bool isNull = isInputNull(inputData);

            if (!isNull)
            {
                lbl_Exception.Text = "Input is null or empty.";
                return;
            }
            else
            {
                try
                {
                    if(short.TryParse(inputData, out short shortResult))
                    {
                        lbl_Short.Text = shortResult.ToString();
                    }
                    else
                    {
                        throw new Exception("Input cannot be converted to Short.");
                    }
                }
                catch (Exception ex)
                {
                    lbl_Exception.Text = ex.Message;
                }
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            lbl_Exception.Text = "-";
            string inputData = tbox_Input_Num.Text;
            bool isNull = isInputNull(inputData);

            if (!isNull)
            {
                lbl_Exception.Text = "Input is null or empty.";
                return;
            }
            else
            {
                try
                {
                    if (int.TryParse(inputData, out int intResult))
                    {
                        lbl_Int.Text = intResult.ToString();
                    }
                    else
                    {
                        throw new Exception("Input cannot be converted to Int.");
                    }
                }
                catch (Exception ex)
                {
                    lbl_Exception.Text = ex.Message;
                }
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            lbl_Exception.Text = "-";
            string inputData = tbox_Input_Num.Text;
            bool isNull = isInputNull(inputData);

            if (!isNull)
            {
                lbl_Exception.Text = "Input is null or empty.";
                return;
            }
            else
            {
                try
                {
                    if (double.TryParse(inputData, out double doubleResult))
                    {
                        lbl_Double.Text = doubleResult.ToString();
                    }
                    else
                    {
                        throw new Exception("Input cannot be converted to Double.");
                    }
                }
                catch (Exception ex)
                {
                    lbl_Exception.Text = ex.Message;
                }
            }
        }

        private bool isInputNull(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
