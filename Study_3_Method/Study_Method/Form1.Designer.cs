namespace Study_Method
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbox_Result = new System.Windows.Forms.TextBox();
            this.tbox_Input_Num1 = new System.Windows.Forms.TextBox();
            this.tbox_Input_Num2 = new System.Windows.Forms.TextBox();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_Result
            // 
            this.tbox_Result.Location = new System.Drawing.Point(12, 12);
            this.tbox_Result.Name = "tbox_Result";
            this.tbox_Result.Size = new System.Drawing.Size(304, 21);
            this.tbox_Result.TabIndex = 0;
            this.tbox_Result.Text = "0";
            this.tbox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Input_Num1
            // 
            this.tbox_Input_Num1.Location = new System.Drawing.Point(12, 39);
            this.tbox_Input_Num1.Name = "tbox_Input_Num1";
            this.tbox_Input_Num1.Size = new System.Drawing.Size(150, 21);
            this.tbox_Input_Num1.TabIndex = 1;
            this.tbox_Input_Num1.Text = "0";
            this.tbox_Input_Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Input_Num2
            // 
            this.tbox_Input_Num2.Location = new System.Drawing.Point(168, 39);
            this.tbox_Input_Num2.Name = "tbox_Input_Num2";
            this.tbox_Input_Num2.Size = new System.Drawing.Size(150, 21);
            this.tbox_Input_Num2.TabIndex = 2;
            this.tbox_Input_Num2.Text = "0";
            this.tbox_Input_Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(12, 66);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(70, 50);
            this.btn_Plus.TabIndex = 3;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            // 
            // btn_Minus
            // 
            this.btn_Minus.Location = new System.Drawing.Point(92, 66);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(70, 50);
            this.btn_Minus.TabIndex = 4;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            // 
            // btn_Division
            // 
            this.btn_Division.Location = new System.Drawing.Point(248, 66);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(70, 50);
            this.btn_Division.TabIndex = 6;
            this.btn_Division.Text = "/";
            this.btn_Division.UseVisualStyleBackColor = true;
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.Location = new System.Drawing.Point(168, 66);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(70, 50);
            this.btn_Multiply.TabIndex = 5;
            this.btn_Multiply.Text = "*";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 127);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.tbox_Input_Num2);
            this.Controls.Add(this.tbox_Input_Num1);
            this.Controls.Add(this.tbox_Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Result;
        private System.Windows.Forms.TextBox tbox_Input_Num1;
        private System.Windows.Forms.TextBox tbox_Input_Num2;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Multiply;
    }
}

