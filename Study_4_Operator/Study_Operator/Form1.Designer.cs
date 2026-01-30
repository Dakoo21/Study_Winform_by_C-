namespace Study_Operator
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
            this.tbox_Result_After = new System.Windows.Forms.TextBox();
            this.tbox_And_Or = new System.Windows.Forms.TextBox();
            this.tbox_Num = new System.Windows.Forms.TextBox();
            this.tbox_Result_Bit = new System.Windows.Forms.TextBox();
            this.btn_shfit_Left = new System.Windows.Forms.Button();
            this.btn_Shift_Right = new System.Windows.Forms.Button();
            this.btn_Add_Assign = new System.Windows.Forms.Button();
            this.btn_Sub_Assign = new System.Windows.Forms.Button();
            this.btn_BitwiseAnd = new System.Windows.Forms.Button();
            this.btn_Logical_Or = new System.Windows.Forms.Button();
            this.btn_PreIncrement = new System.Windows.Forms.Button();
            this.btn_PostIncrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_Result
            // 
            this.tbox_Result.Location = new System.Drawing.Point(12, 12);
            this.tbox_Result.Name = "tbox_Result";
            this.tbox_Result.Size = new System.Drawing.Size(100, 21);
            this.tbox_Result.TabIndex = 0;
            this.tbox_Result.Text = "0";
            this.tbox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Result_After
            // 
            this.tbox_Result_After.Location = new System.Drawing.Point(118, 12);
            this.tbox_Result_After.Name = "tbox_Result_After";
            this.tbox_Result_After.Size = new System.Drawing.Size(100, 21);
            this.tbox_Result_After.TabIndex = 1;
            this.tbox_Result_After.Text = "0";
            this.tbox_Result_After.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_And_Or
            // 
            this.tbox_And_Or.Enabled = false;
            this.tbox_And_Or.Location = new System.Drawing.Point(118, 93);
            this.tbox_And_Or.Name = "tbox_And_Or";
            this.tbox_And_Or.Size = new System.Drawing.Size(100, 21);
            this.tbox_And_Or.TabIndex = 0;
            this.tbox_And_Or.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Num
            // 
            this.tbox_Num.Location = new System.Drawing.Point(12, 93);
            this.tbox_Num.Name = "tbox_Num";
            this.tbox_Num.Size = new System.Drawing.Size(100, 21);
            this.tbox_Num.TabIndex = 1;
            this.tbox_Num.Text = "0";
            this.tbox_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Result_Bit
            // 
            this.tbox_Result_Bit.Enabled = false;
            this.tbox_Result_Bit.Location = new System.Drawing.Point(12, 39);
            this.tbox_Result_Bit.Name = "tbox_Result_Bit";
            this.tbox_Result_Bit.Size = new System.Drawing.Size(100, 21);
            this.tbox_Result_Bit.TabIndex = 2;
            this.tbox_Result_Bit.Text = "0";
            this.tbox_Result_Bit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_shfit_Left
            // 
            this.btn_shfit_Left.Location = new System.Drawing.Point(12, 120);
            this.btn_shfit_Left.Name = "btn_shfit_Left";
            this.btn_shfit_Left.Size = new System.Drawing.Size(47, 35);
            this.btn_shfit_Left.TabIndex = 3;
            this.btn_shfit_Left.Text = "<<";
            this.btn_shfit_Left.UseVisualStyleBackColor = true;
            // 
            // btn_Shift_Right
            // 
            this.btn_Shift_Right.Location = new System.Drawing.Point(65, 120);
            this.btn_Shift_Right.Name = "btn_Shift_Right";
            this.btn_Shift_Right.Size = new System.Drawing.Size(47, 35);
            this.btn_Shift_Right.TabIndex = 4;
            this.btn_Shift_Right.Text = ">>";
            this.btn_Shift_Right.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Assign
            // 
            this.btn_Add_Assign.Location = new System.Drawing.Point(118, 120);
            this.btn_Add_Assign.Name = "btn_Add_Assign";
            this.btn_Add_Assign.Size = new System.Drawing.Size(47, 35);
            this.btn_Add_Assign.TabIndex = 3;
            this.btn_Add_Assign.Text = "+=";
            this.btn_Add_Assign.UseVisualStyleBackColor = true;
            // 
            // btn_Sub_Assign
            // 
            this.btn_Sub_Assign.Location = new System.Drawing.Point(171, 120);
            this.btn_Sub_Assign.Name = "btn_Sub_Assign";
            this.btn_Sub_Assign.Size = new System.Drawing.Size(47, 35);
            this.btn_Sub_Assign.TabIndex = 4;
            this.btn_Sub_Assign.Text = "-=";
            this.btn_Sub_Assign.UseVisualStyleBackColor = true;
            // 
            // btn_BitwiseAnd
            // 
            this.btn_BitwiseAnd.Location = new System.Drawing.Point(118, 161);
            this.btn_BitwiseAnd.Name = "btn_BitwiseAnd";
            this.btn_BitwiseAnd.Size = new System.Drawing.Size(47, 35);
            this.btn_BitwiseAnd.TabIndex = 3;
            this.btn_BitwiseAnd.Text = "&&";
            this.btn_BitwiseAnd.UseVisualStyleBackColor = true;
            // 
            // btn_Logical_Or
            // 
            this.btn_Logical_Or.Location = new System.Drawing.Point(171, 161);
            this.btn_Logical_Or.Name = "btn_Logical_Or";
            this.btn_Logical_Or.Size = new System.Drawing.Size(47, 35);
            this.btn_Logical_Or.TabIndex = 4;
            this.btn_Logical_Or.Text = "||";
            this.btn_Logical_Or.UseVisualStyleBackColor = true;
            // 
            // btn_PreIncrement
            // 
            this.btn_PreIncrement.Location = new System.Drawing.Point(12, 161);
            this.btn_PreIncrement.Name = "btn_PreIncrement";
            this.btn_PreIncrement.Size = new System.Drawing.Size(47, 35);
            this.btn_PreIncrement.TabIndex = 3;
            this.btn_PreIncrement.Text = "++a";
            this.btn_PreIncrement.UseVisualStyleBackColor = true;
            // 
            // btn_PostIncrement
            // 
            this.btn_PostIncrement.Location = new System.Drawing.Point(65, 161);
            this.btn_PostIncrement.Name = "btn_PostIncrement";
            this.btn_PostIncrement.Size = new System.Drawing.Size(47, 35);
            this.btn_PostIncrement.TabIndex = 4;
            this.btn_PostIncrement.Text = "a++";
            this.btn_PostIncrement.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 208);
            this.Controls.Add(this.btn_PostIncrement);
            this.Controls.Add(this.btn_Logical_Or);
            this.Controls.Add(this.btn_Sub_Assign);
            this.Controls.Add(this.btn_PreIncrement);
            this.Controls.Add(this.btn_BitwiseAnd);
            this.Controls.Add(this.btn_Add_Assign);
            this.Controls.Add(this.btn_Shift_Right);
            this.Controls.Add(this.btn_shfit_Left);
            this.Controls.Add(this.tbox_Result_Bit);
            this.Controls.Add(this.tbox_Num);
            this.Controls.Add(this.tbox_Result_After);
            this.Controls.Add(this.tbox_And_Or);
            this.Controls.Add(this.tbox_Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Result;
        private System.Windows.Forms.TextBox tbox_Result_After;
        private System.Windows.Forms.TextBox tbox_And_Or;
        private System.Windows.Forms.TextBox tbox_Num;
        private System.Windows.Forms.TextBox tbox_Result_Bit;
        private System.Windows.Forms.Button btn_shfit_Left;
        private System.Windows.Forms.Button btn_Shift_Right;
        private System.Windows.Forms.Button btn_Add_Assign;
        private System.Windows.Forms.Button btn_Sub_Assign;
        private System.Windows.Forms.Button btn_BitwiseAnd;
        private System.Windows.Forms.Button btn_Logical_Or;
        private System.Windows.Forms.Button btn_PreIncrement;
        private System.Windows.Forms.Button btn_PostIncrement;
    }
}

