namespace Study_6_Annotation
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
            this.lbox_Day = new System.Windows.Forms.ListBox();
            this.lbox_Time = new System.Windows.Forms.ListBox();
            this.btn_Result = new System.Windows.Forms.Button();
            this.tbox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbox_Day
            // 
            this.lbox_Day.FormattingEnabled = true;
            this.lbox_Day.ItemHeight = 12;
            this.lbox_Day.Location = new System.Drawing.Point(12, 12);
            this.lbox_Day.Name = "lbox_Day";
            this.lbox_Day.Size = new System.Drawing.Size(267, 316);
            this.lbox_Day.TabIndex = 0;
            // 
            // lbox_Time
            // 
            this.lbox_Time.FormattingEnabled = true;
            this.lbox_Time.ItemHeight = 12;
            this.lbox_Time.Location = new System.Drawing.Point(285, 12);
            this.lbox_Time.Name = "lbox_Time";
            this.lbox_Time.Size = new System.Drawing.Size(267, 316);
            this.lbox_Time.TabIndex = 1;
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(477, 334);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(75, 43);
            this.btn_Result.TabIndex = 2;
            this.btn_Result.Text = "결과";
            this.btn_Result.UseVisualStyleBackColor = true;
            // 
            // tbox_Result
            // 
            this.tbox_Result.Location = new System.Drawing.Point(12, 336);
            this.tbox_Result.Multiline = true;
            this.tbox_Result.Name = "tbox_Result";
            this.tbox_Result.Size = new System.Drawing.Size(459, 41);
            this.tbox_Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 381);
            this.Controls.Add(this.tbox_Result);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.lbox_Time);
            this.Controls.Add(this.lbox_Day);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Day;
        private System.Windows.Forms.ListBox lbox_Time;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.TextBox tbox_Result;
    }
}

