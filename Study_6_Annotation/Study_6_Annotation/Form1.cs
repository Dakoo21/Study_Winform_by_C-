using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_6_Annotation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitEventHandeler();
        }

        private enum AnnotationDay
        {
            Monday, // 주석 1. 코드에 대한 설명을 붙일 때 사용합니다.
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        private enum AnnotationTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        private void InitEventHandeler()
        {
            this.Load += Form1_Load;
            btn_Result.Click += Btn_Result_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbox_Result.Enabled = false;

            lbox_Day.DataSource = Enum.GetNames(typeof(AnnotationDay));
            lbox_Time.DataSource = Enum.GetNames(typeof(AnnotationTime));
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            string selectedDay = lbox_Day.SelectedItem.ToString();
            string selectedTime = lbox_Time.SelectedItem.ToString();
            string result = stringFormat(selectedDay, selectedTime);

            //tbox_Result.Text = "임시로 주석을 막기"; // 주석 2. 사용하지 않는 줄을 임시로 막아 놓을 경우 사용합니다.
            tbox_Result.Text = result;
        }

        // 주석 3
        /// <summary>
        /// 메소드 및 인자에 대한 설명이 필요한 경우 사용합니다.
        /// </summary>
        /// <param name="day">인자값 1에대한 설명을 입력합니다.</param>
        /// <param name="time">인자값 2에대한 설명을 입력합니다.</param>
        /// <returns>반환값에 대한 설명을 입력합니다.</returns>
        private string stringFormat(string day, string time)
        {
            return string.Format("{0} & {1}을 선택하였습니다.", day, time);
        }

        /*private void annotationSample1()
        {
            //주석 4
            // / *
                 해당 사이에 있으면 전체 주석 처리 됩니다.
                 여러줄을 동시에 막을 겨우 사용합니다.
            // * /
        }*/
    }
}
