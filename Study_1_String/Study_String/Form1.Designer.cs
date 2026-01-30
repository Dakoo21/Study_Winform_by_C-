namespace Study_String
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
            this.lbl_Text = new System.Windows.Forms.Label();
            this.lbl_Contain_Title = new System.Windows.Forms.Label();
            this.lbl_Equals_Title = new System.Windows.Forms.Label();
            this.lbl_Replace_Title = new System.Windows.Forms.Label();
            this.lbl_Length_Title = new System.Windows.Forms.Label();
            this.lbl_Split_Title = new System.Windows.Forms.Label();
            this.lbl_Contain = new System.Windows.Forms.Label();
            this.lbl_Equals = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Replace = new System.Windows.Forms.Label();
            this.lbl_Split1 = new System.Windows.Forms.Label();
            this.lbl_Substring_Title = new System.Windows.Forms.Label();
            this.lbl_ToLower_Title = new System.Windows.Forms.Label();
            this.lbl_ToUpper_Title = new System.Windows.Forms.Label();
            this.lbl_Trim_Title = new System.Windows.Forms.Label();
            this.lbl_Substring = new System.Windows.Forms.Label();
            this.lbl_ToLower = new System.Windows.Forms.Label();
            this.lbl_ToUpper = new System.Windows.Forms.Label();
            this.lbl_Trim = new System.Windows.Forms.Label();
            this.btn_Processing = new System.Windows.Forms.Button();
            this.lbl_Split2 = new System.Windows.Forms.Label();
            this.lbl_Split3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Location = new System.Drawing.Point(34, 20);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(114, 12);
            this.lbl_Text.TabIndex = 0;
            this.lbl_Text.Text = "Sample, Test, Text";
            // 
            // lbl_Contain_Title
            // 
            this.lbl_Contain_Title.AutoSize = true;
            this.lbl_Contain_Title.Location = new System.Drawing.Point(34, 76);
            this.lbl_Contain_Title.Name = "lbl_Contain_Title";
            this.lbl_Contain_Title.Size = new System.Drawing.Size(48, 12);
            this.lbl_Contain_Title.TabIndex = 1;
            this.lbl_Contain_Title.Text = "Contain";
            // 
            // lbl_Equals_Title
            // 
            this.lbl_Equals_Title.AutoSize = true;
            this.lbl_Equals_Title.Location = new System.Drawing.Point(34, 109);
            this.lbl_Equals_Title.Name = "lbl_Equals_Title";
            this.lbl_Equals_Title.Size = new System.Drawing.Size(44, 12);
            this.lbl_Equals_Title.TabIndex = 2;
            this.lbl_Equals_Title.Text = "Equals";
            // 
            // lbl_Replace_Title
            // 
            this.lbl_Replace_Title.AutoSize = true;
            this.lbl_Replace_Title.Location = new System.Drawing.Point(34, 172);
            this.lbl_Replace_Title.Name = "lbl_Replace_Title";
            this.lbl_Replace_Title.Size = new System.Drawing.Size(51, 12);
            this.lbl_Replace_Title.TabIndex = 4;
            this.lbl_Replace_Title.Text = "Replace";
            // 
            // lbl_Length_Title
            // 
            this.lbl_Length_Title.AutoSize = true;
            this.lbl_Length_Title.Location = new System.Drawing.Point(34, 139);
            this.lbl_Length_Title.Name = "lbl_Length_Title";
            this.lbl_Length_Title.Size = new System.Drawing.Size(43, 12);
            this.lbl_Length_Title.TabIndex = 3;
            this.lbl_Length_Title.Text = "Length";
            // 
            // lbl_Split_Title
            // 
            this.lbl_Split_Title.AutoSize = true;
            this.lbl_Split_Title.Location = new System.Drawing.Point(34, 202);
            this.lbl_Split_Title.Name = "lbl_Split_Title";
            this.lbl_Split_Title.Size = new System.Drawing.Size(29, 12);
            this.lbl_Split_Title.TabIndex = 5;
            this.lbl_Split_Title.Text = "Split";
            // 
            // lbl_Contain
            // 
            this.lbl_Contain.AutoSize = true;
            this.lbl_Contain.Location = new System.Drawing.Point(100, 76);
            this.lbl_Contain.Name = "lbl_Contain";
            this.lbl_Contain.Size = new System.Drawing.Size(11, 12);
            this.lbl_Contain.TabIndex = 1;
            this.lbl_Contain.Text = "-";
            // 
            // lbl_Equals
            // 
            this.lbl_Equals.AutoSize = true;
            this.lbl_Equals.Location = new System.Drawing.Point(100, 109);
            this.lbl_Equals.Name = "lbl_Equals";
            this.lbl_Equals.Size = new System.Drawing.Size(11, 12);
            this.lbl_Equals.TabIndex = 2;
            this.lbl_Equals.Text = "-";
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(100, 139);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(11, 12);
            this.lbl_Length.TabIndex = 3;
            this.lbl_Length.Text = "-";
            // 
            // lbl_Replace
            // 
            this.lbl_Replace.AutoSize = true;
            this.lbl_Replace.Location = new System.Drawing.Point(100, 172);
            this.lbl_Replace.Name = "lbl_Replace";
            this.lbl_Replace.Size = new System.Drawing.Size(11, 12);
            this.lbl_Replace.TabIndex = 4;
            this.lbl_Replace.Text = "-";
            // 
            // lbl_Split1
            // 
            this.lbl_Split1.AutoSize = true;
            this.lbl_Split1.Location = new System.Drawing.Point(100, 202);
            this.lbl_Split1.Name = "lbl_Split1";
            this.lbl_Split1.Size = new System.Drawing.Size(11, 12);
            this.lbl_Split1.TabIndex = 5;
            this.lbl_Split1.Text = "-";
            // 
            // lbl_Substring_Title
            // 
            this.lbl_Substring_Title.AutoSize = true;
            this.lbl_Substring_Title.Location = new System.Drawing.Point(243, 76);
            this.lbl_Substring_Title.Name = "lbl_Substring_Title";
            this.lbl_Substring_Title.Size = new System.Drawing.Size(58, 12);
            this.lbl_Substring_Title.TabIndex = 1;
            this.lbl_Substring_Title.Text = "Substring";
            // 
            // lbl_ToLower_Title
            // 
            this.lbl_ToLower_Title.AutoSize = true;
            this.lbl_ToLower_Title.Location = new System.Drawing.Point(243, 109);
            this.lbl_ToLower_Title.Name = "lbl_ToLower_Title";
            this.lbl_ToLower_Title.Size = new System.Drawing.Size(55, 12);
            this.lbl_ToLower_Title.TabIndex = 2;
            this.lbl_ToLower_Title.Text = "ToLower";
            // 
            // lbl_ToUpper_Title
            // 
            this.lbl_ToUpper_Title.AutoSize = true;
            this.lbl_ToUpper_Title.Location = new System.Drawing.Point(243, 139);
            this.lbl_ToUpper_Title.Name = "lbl_ToUpper_Title";
            this.lbl_ToUpper_Title.Size = new System.Drawing.Size(53, 12);
            this.lbl_ToUpper_Title.TabIndex = 3;
            this.lbl_ToUpper_Title.Text = "ToUpper";
            // 
            // lbl_Trim_Title
            // 
            this.lbl_Trim_Title.AutoSize = true;
            this.lbl_Trim_Title.Location = new System.Drawing.Point(243, 172);
            this.lbl_Trim_Title.Name = "lbl_Trim_Title";
            this.lbl_Trim_Title.Size = new System.Drawing.Size(31, 12);
            this.lbl_Trim_Title.TabIndex = 4;
            this.lbl_Trim_Title.Text = "Trim";
            // 
            // lbl_Substring
            // 
            this.lbl_Substring.AutoSize = true;
            this.lbl_Substring.Location = new System.Drawing.Point(323, 76);
            this.lbl_Substring.Name = "lbl_Substring";
            this.lbl_Substring.Size = new System.Drawing.Size(11, 12);
            this.lbl_Substring.TabIndex = 1;
            this.lbl_Substring.Text = "-";
            // 
            // lbl_ToLower
            // 
            this.lbl_ToLower.AutoSize = true;
            this.lbl_ToLower.Location = new System.Drawing.Point(323, 109);
            this.lbl_ToLower.Name = "lbl_ToLower";
            this.lbl_ToLower.Size = new System.Drawing.Size(11, 12);
            this.lbl_ToLower.TabIndex = 2;
            this.lbl_ToLower.Text = "-";
            // 
            // lbl_ToUpper
            // 
            this.lbl_ToUpper.AutoSize = true;
            this.lbl_ToUpper.Location = new System.Drawing.Point(323, 139);
            this.lbl_ToUpper.Name = "lbl_ToUpper";
            this.lbl_ToUpper.Size = new System.Drawing.Size(11, 12);
            this.lbl_ToUpper.TabIndex = 3;
            this.lbl_ToUpper.Text = "-";
            // 
            // lbl_Trim
            // 
            this.lbl_Trim.AutoSize = true;
            this.lbl_Trim.Location = new System.Drawing.Point(323, 172);
            this.lbl_Trim.Name = "lbl_Trim";
            this.lbl_Trim.Size = new System.Drawing.Size(11, 12);
            this.lbl_Trim.TabIndex = 4;
            this.lbl_Trim.Text = "-";
            // 
            // btn_Processing
            // 
            this.btn_Processing.Location = new System.Drawing.Point(367, 15);
            this.btn_Processing.Name = "btn_Processing";
            this.btn_Processing.Size = new System.Drawing.Size(75, 23);
            this.btn_Processing.TabIndex = 6;
            this.btn_Processing.Text = "실행";
            this.btn_Processing.UseVisualStyleBackColor = true;
            // 
            // lbl_Split2
            // 
            this.lbl_Split2.AutoSize = true;
            this.lbl_Split2.Location = new System.Drawing.Point(100, 229);
            this.lbl_Split2.Name = "lbl_Split2";
            this.lbl_Split2.Size = new System.Drawing.Size(11, 12);
            this.lbl_Split2.TabIndex = 4;
            this.lbl_Split2.Text = "-";
            // 
            // lbl_Split3
            // 
            this.lbl_Split3.AutoSize = true;
            this.lbl_Split3.Location = new System.Drawing.Point(100, 259);
            this.lbl_Split3.Name = "lbl_Split3";
            this.lbl_Split3.Size = new System.Drawing.Size(11, 12);
            this.lbl_Split3.TabIndex = 5;
            this.lbl_Split3.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.btn_Processing);
            this.Controls.Add(this.lbl_Split3);
            this.Controls.Add(this.lbl_Split1);
            this.Controls.Add(this.lbl_Split_Title);
            this.Controls.Add(this.lbl_Trim);
            this.Controls.Add(this.lbl_Split2);
            this.Controls.Add(this.lbl_Trim_Title);
            this.Controls.Add(this.lbl_Replace);
            this.Controls.Add(this.lbl_Replace_Title);
            this.Controls.Add(this.lbl_ToUpper);
            this.Controls.Add(this.lbl_ToUpper_Title);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.lbl_Length_Title);
            this.Controls.Add(this.lbl_ToLower);
            this.Controls.Add(this.lbl_ToLower_Title);
            this.Controls.Add(this.lbl_Equals);
            this.Controls.Add(this.lbl_Equals_Title);
            this.Controls.Add(this.lbl_Substring);
            this.Controls.Add(this.lbl_Substring_Title);
            this.Controls.Add(this.lbl_Contain);
            this.Controls.Add(this.lbl_Contain_Title);
            this.Controls.Add(this.lbl_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.Label lbl_Contain_Title;
        private System.Windows.Forms.Label lbl_Equals_Title;
        private System.Windows.Forms.Label lbl_Replace_Title;
        private System.Windows.Forms.Label lbl_Length_Title;
        private System.Windows.Forms.Label lbl_Split_Title;
        private System.Windows.Forms.Label lbl_Contain;
        private System.Windows.Forms.Label lbl_Equals;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Replace;
        private System.Windows.Forms.Label lbl_Split1;
        private System.Windows.Forms.Label lbl_Substring_Title;
        private System.Windows.Forms.Label lbl_ToLower_Title;
        private System.Windows.Forms.Label lbl_ToUpper_Title;
        private System.Windows.Forms.Label lbl_Trim_Title;
        private System.Windows.Forms.Label lbl_Substring;
        private System.Windows.Forms.Label lbl_ToLower;
        private System.Windows.Forms.Label lbl_ToUpper;
        private System.Windows.Forms.Label lbl_Trim;
        private System.Windows.Forms.Button btn_Processing;
        private System.Windows.Forms.Label lbl_Split2;
        private System.Windows.Forms.Label lbl_Split3;
    }
}

