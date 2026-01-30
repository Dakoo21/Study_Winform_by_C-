using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitHandleEvents();
        }

        private enum InitLbox_Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        private enum InitLbox_Time
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        private void InitHandleEvents()
        {
            this.Load += Form1_Load;
            btn_Result.Click += Btn_Result_Click;
            btn_Result_String_Format.Click += Btn_Result_String_Format_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbox_Day.DataSource = Enum.GetNames(typeof(InitLbox_Day));
            lbox_Time.DataSource = Enum.GetNames(typeof(InitLbox_Time));

            lbox_Day.SelectedIndex = 0;
            lbox_Time.SelectedIndex = 0;
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            string strName = tbox_Name.Text.Trim();
            string strResult = string.Empty;
            string strDay = lbox_Day.SelectedItem.ToString();
            string strTime = lbox_Time.SelectedItem.ToString();

            if (IsInvalidName(strName))
            {
                MessageBox.Show("이름을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                strResult = $"{strName} 와 {strDay}(요일) {strTime} 에 만나기로 하였습니다.";
            }

            tbox_Result.Text = strResult;
        }

        private void Btn_Result_String_Format_Click(object sender, EventArgs e)
        {
            string strName = tbox_Name.Text.Trim();
            string strResult = string.Empty;
            string strDay = lbox_Day.SelectedItem.ToString();
            string strTime = lbox_Time.SelectedItem.ToString();

            if (IsInvalidName(strName))
            {
                MessageBox.Show("이름을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                strResult = GetResultString(strName, strDay, strTime);
            }

            tbox_Result.Text = strResult;
        }

        private bool IsInvalidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetResultString(string name, string day, string time)
        {
            return string.Format("String Format: {0} 와 {1}(요일) {2}에 만나기로 하였습니다.", name, day, time);
        }
    }
}
