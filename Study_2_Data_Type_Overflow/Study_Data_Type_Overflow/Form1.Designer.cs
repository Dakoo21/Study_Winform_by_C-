namespace Study_Data_Type_Overflow
{
    partial class lbl_Double_Title
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
            this.tbox_Input_Num = new System.Windows.Forms.TextBox();
            this.btn_Process_Change = new System.Windows.Forms.Button();
            this.lbl_Short_Title = new System.Windows.Forms.Label();
            this.lbl_Short = new System.Windows.Forms.Label();
            this.lbl_Int_Title = new System.Windows.Forms.Label();
            this.lbl_Int = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Double = new System.Windows.Forms.Label();
            this.lbl_Exception_Title = new System.Windows.Forms.Label();
            this.lbl_Exception = new System.Windows.Forms.Label();
            this.btn_Process_Short = new System.Windows.Forms.Button();
            this.btn_Process_Int = new System.Windows.Forms.Button();
            this.btn_Process_Double = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_Input_Num
            // 
            this.tbox_Input_Num.Location = new System.Drawing.Point(12, 12);
            this.tbox_Input_Num.Name = "tbox_Input_Num";
            this.tbox_Input_Num.Size = new System.Drawing.Size(400, 21);
            this.tbox_Input_Num.TabIndex = 0;
            // 
            // btn_Process_Change
            // 
            this.btn_Process_Change.Location = new System.Drawing.Point(418, 12);
            this.btn_Process_Change.Name = "btn_Process_Change";
            this.btn_Process_Change.Size = new System.Drawing.Size(90, 23);
            this.btn_Process_Change.TabIndex = 1;
            this.btn_Process_Change.Text = "알아서 변환";
            this.btn_Process_Change.UseVisualStyleBackColor = true;
            // 
            // lbl_Short_Title
            // 
            this.lbl_Short_Title.AutoSize = true;
            this.lbl_Short_Title.Location = new System.Drawing.Point(12, 74);
            this.lbl_Short_Title.Name = "lbl_Short_Title";
            this.lbl_Short_Title.Size = new System.Drawing.Size(34, 12);
            this.lbl_Short_Title.TabIndex = 2;
            this.lbl_Short_Title.Text = "Short";
            // 
            // lbl_Short
            // 
            this.lbl_Short.AutoSize = true;
            this.lbl_Short.Location = new System.Drawing.Point(116, 74);
            this.lbl_Short.Name = "lbl_Short";
            this.lbl_Short.Size = new System.Drawing.Size(11, 12);
            this.lbl_Short.TabIndex = 2;
            this.lbl_Short.Text = "0";
            // 
            // lbl_Int_Title
            // 
            this.lbl_Int_Title.AutoSize = true;
            this.lbl_Int_Title.Location = new System.Drawing.Point(12, 110);
            this.lbl_Int_Title.Name = "lbl_Int_Title";
            this.lbl_Int_Title.Size = new System.Drawing.Size(18, 12);
            this.lbl_Int_Title.TabIndex = 2;
            this.lbl_Int_Title.Text = "Int";
            // 
            // lbl_Int
            // 
            this.lbl_Int.AutoSize = true;
            this.lbl_Int.Location = new System.Drawing.Point(116, 110);
            this.lbl_Int.Name = "lbl_Int";
            this.lbl_Int.Size = new System.Drawing.Size(11, 12);
            this.lbl_Int.TabIndex = 2;
            this.lbl_Int.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Double";
            // 
            // lbl_Double
            // 
            this.lbl_Double.AutoSize = true;
            this.lbl_Double.Location = new System.Drawing.Point(116, 150);
            this.lbl_Double.Name = "lbl_Double";
            this.lbl_Double.Size = new System.Drawing.Size(11, 12);
            this.lbl_Double.TabIndex = 2;
            this.lbl_Double.Text = "0";
            // 
            // lbl_Exception_Title
            // 
            this.lbl_Exception_Title.AutoSize = true;
            this.lbl_Exception_Title.Location = new System.Drawing.Point(12, 188);
            this.lbl_Exception_Title.Name = "lbl_Exception_Title";
            this.lbl_Exception_Title.Size = new System.Drawing.Size(61, 12);
            this.lbl_Exception_Title.TabIndex = 2;
            this.lbl_Exception_Title.Text = "Exception";
            // 
            // lbl_Exception
            // 
            this.lbl_Exception.AutoSize = true;
            this.lbl_Exception.Location = new System.Drawing.Point(116, 188);
            this.lbl_Exception.Name = "lbl_Exception";
            this.lbl_Exception.Size = new System.Drawing.Size(11, 12);
            this.lbl_Exception.TabIndex = 2;
            this.lbl_Exception.Text = "-";
            // 
            // btn_Process_Short
            // 
            this.btn_Process_Short.Location = new System.Drawing.Point(322, 69);
            this.btn_Process_Short.Name = "btn_Process_Short";
            this.btn_Process_Short.Size = new System.Drawing.Size(90, 23);
            this.btn_Process_Short.TabIndex = 1;
            this.btn_Process_Short.Text = "Short 변환";
            this.btn_Process_Short.UseVisualStyleBackColor = true;
            // 
            // btn_Process_Int
            // 
            this.btn_Process_Int.Location = new System.Drawing.Point(322, 105);
            this.btn_Process_Int.Name = "btn_Process_Int";
            this.btn_Process_Int.Size = new System.Drawing.Size(90, 23);
            this.btn_Process_Int.TabIndex = 1;
            this.btn_Process_Int.Text = "Int 변환";
            this.btn_Process_Int.UseVisualStyleBackColor = true;
            // 
            // btn_Process_Double
            // 
            this.btn_Process_Double.Location = new System.Drawing.Point(322, 145);
            this.btn_Process_Double.Name = "btn_Process_Double";
            this.btn_Process_Double.Size = new System.Drawing.Size(90, 23);
            this.btn_Process_Double.TabIndex = 1;
            this.btn_Process_Double.Text = "Double 변환";
            this.btn_Process_Double.UseVisualStyleBackColor = true;
            // 
            // lbl_Double_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 221);
            this.Controls.Add(this.lbl_Exception);
            this.Controls.Add(this.lbl_Exception_Title);
            this.Controls.Add(this.lbl_Double);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Int);
            this.Controls.Add(this.lbl_Int_Title);
            this.Controls.Add(this.lbl_Short);
            this.Controls.Add(this.lbl_Short_Title);
            this.Controls.Add(this.btn_Process_Double);
            this.Controls.Add(this.btn_Process_Int);
            this.Controls.Add(this.btn_Process_Short);
            this.Controls.Add(this.btn_Process_Change);
            this.Controls.Add(this.tbox_Input_Num);
            this.Name = "lbl_Double_Title";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Input_Num;
        private System.Windows.Forms.Button btn_Process_Change;
        private System.Windows.Forms.Label lbl_Short_Title;
        private System.Windows.Forms.Label lbl_Short;
        private System.Windows.Forms.Label lbl_Int_Title;
        private System.Windows.Forms.Label lbl_Int;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Double;
        private System.Windows.Forms.Label lbl_Exception_Title;
        private System.Windows.Forms.Label lbl_Exception;
        private System.Windows.Forms.Button btn_Process_Short;
        private System.Windows.Forms.Button btn_Process_Int;
        private System.Windows.Forms.Button btn_Process_Double;
    }
}

