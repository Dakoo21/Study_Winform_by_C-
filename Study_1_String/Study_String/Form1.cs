using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitLocalEventHandlers();
        }

        private void InitLocalEventHandlers()
        {
            btn_Processing.Click += Btn_Processing_Click;
        }

        private void Btn_Processing_Click(object sender, EventArgs e)
        {
            //lbl_Text 라벨의 문자열을 strText 변수에 할당
            string strText = lbl_Text.Text;

            // Contain (Test "문자" 가 문자열에 포함되어있는지 | 결과: 참 OR 거짓)
            lbl_Contain.Text = strText.Contains("Test").ToString();

            //Equeals (Test "문자열" 과 비교 문자열과 동일한지 | 결과: 참 OR 거짓)
            lbl_Equals.Text = strText.Equals("Test").ToString();

            //Length (lbl_Text 라벨에 전체 문자열 길이 반환)
            lbl_Length.Text = strText.Length.ToString();

            //Replace (lbl_Text 라벨의 문자열에 Test 문자를 I Can으로 변경)
            lbl_Replace.Text = strText.Replace("Test", "I Can").ToString();

            //Split (lbl_Text 라벨의 문자열을 ','를 기준으로 짜름)
            string[] splitText = strText.Split(',');
            Label[] labels = { lbl_Split1, lbl_Split2, lbl_Split3 };
            for (int i = 0; i < splitText.Length; i++)
            {
                labels[i].Text = splitText[i];
            }

            //Substring (lbl_Text 라벨의 문자열의 전체 길이의 3번째(0시작)부터 4개를 짤라서 출력)
            lbl_Substring.Text = strText.Substring(3, 5).ToString();

            //ToLower (lbl_Text 라벨의 문자열의 문자를 모두 대문자로 변경)
            lbl_ToLower.Text = strText.ToLower().ToString();

            //ToUpper (lbl_Text 라벨의 문자열의 문자를 모두 소문자로 변경)
            lbl_ToUpper.Text = strText.ToUpper().ToString();

            //Trim (lbl_Text 라벨의 문자열 앞, 뒤의 공백을 제거)
            lbl_Trim.Text = strText.Trim().ToString();
        }
    }
}
