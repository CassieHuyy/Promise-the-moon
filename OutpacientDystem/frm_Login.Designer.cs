namespace OutpacientDystem
{
    partial class frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Hint = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserNo = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_UserNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Hint
            // 
            this.lbl_Hint.AutoSize = true;
            this.lbl_Hint.Location = new System.Drawing.Point(160, 198);
            this.lbl_Hint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Hint.Name = "lbl_Hint";
            this.lbl_Hint.Size = new System.Drawing.Size(226, 24);
            this.lbl_Hint.TabIndex = 18;
            this.lbl_Hint.Text = "请输入用户号、密码";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(160, 250);
            this.btn_LogIn.Margin = new System.Windows.Forms.Padding(6);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(150, 46);
            this.btn_LogIn.TabIndex = 17;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(60, 134);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(82, 24);
            this.lbl_Password.TabIndex = 16;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_UserNo
            // 
            this.lbl_UserNo.AutoSize = true;
            this.lbl_UserNo.Location = new System.Drawing.Point(42, 64);
            this.lbl_UserNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_UserNo.Name = "lbl_UserNo";
            this.lbl_UserNo.Size = new System.Drawing.Size(106, 24);
            this.lbl_UserNo.TabIndex = 15;
            this.lbl_UserNo.Text = "用户号：";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(160, 128);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(6);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(196, 35);
            this.txb_Password.TabIndex = 14;
            // 
            // txb_UserNo
            // 
            this.txb_UserNo.Location = new System.Drawing.Point(160, 58);
            this.txb_UserNo.Margin = new System.Windows.Forms.Padding(6);
            this.txb_UserNo.Name = "txb_UserNo";
            this.txb_UserNo.Size = new System.Drawing.Size(196, 35);
            this.txb_UserNo.TabIndex = 13;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 370);
            this.Controls.Add(this.lbl_Hint);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserNo);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_UserNo);
            this.Name = "frm_Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hint;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserNo;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_UserNo;
    }
}

