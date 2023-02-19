namespace OutpacientDystem
{
    partial class frm_Connection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_Hint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(204, 132);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(150, 46);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_Hint
            // 
            this.lbl_Hint.AutoSize = true;
            this.lbl_Hint.Location = new System.Drawing.Point(34, 70);
            this.lbl_Hint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Hint.Name = "lbl_Hint";
            this.lbl_Hint.Size = new System.Drawing.Size(490, 24);
            this.lbl_Hint.TabIndex = 3;
            this.lbl_Hint.Text = "（数据库连接的连接字符串来自字符串变量）";
            // 
            // frm_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 248);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lbl_Hint);
            this.Name = "frm_Connection";
            this.Text = "数据库连接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_Hint;
    }
}