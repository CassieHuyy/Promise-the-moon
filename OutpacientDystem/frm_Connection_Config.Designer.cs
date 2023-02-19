namespace OutpacientDystem
{
    partial class frm_Connection_Config
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
            this.gpb_Connection = new System.Windows.Forms.GroupBox();
            this.ckb_IsWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.txb_Database = new System.Windows.Forms.TextBox();
            this.txb_Server = new System.Windows.Forms.TextBox();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.gpb_Connection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(171, 333);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(150, 46);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // gpb_Connection
            // 
            this.gpb_Connection.Controls.Add(this.ckb_IsWindowsAuthentication);
            this.gpb_Connection.Controls.Add(this.txb_Database);
            this.gpb_Connection.Controls.Add(this.txb_Server);
            this.gpb_Connection.Controls.Add(this.lbl_Database);
            this.gpb_Connection.Controls.Add(this.lbl_Server);
            this.gpb_Connection.Location = new System.Drawing.Point(62, 59);
            this.gpb_Connection.Name = "gpb_Connection";
            this.gpb_Connection.Size = new System.Drawing.Size(372, 236);
            this.gpb_Connection.TabIndex = 3;
            this.gpb_Connection.TabStop = false;
            this.gpb_Connection.Text = "连接参数";
            // 
            // ckb_IsWindowsAuthentication
            // 
            this.ckb_IsWindowsAuthentication.AutoSize = true;
            this.ckb_IsWindowsAuthentication.Location = new System.Drawing.Point(85, 185);
            this.ckb_IsWindowsAuthentication.Margin = new System.Windows.Forms.Padding(6);
            this.ckb_IsWindowsAuthentication.Name = "ckb_IsWindowsAuthentication";
            this.ckb_IsWindowsAuthentication.Size = new System.Drawing.Size(174, 28);
            this.ckb_IsWindowsAuthentication.TabIndex = 6;
            this.ckb_IsWindowsAuthentication.Text = "Windows验证";
            this.ckb_IsWindowsAuthentication.UseVisualStyleBackColor = true;
            // 
            // txb_Database
            // 
            this.txb_Database.Location = new System.Drawing.Point(129, 112);
            this.txb_Database.Margin = new System.Windows.Forms.Padding(6);
            this.txb_Database.Name = "txb_Database";
            this.txb_Database.Size = new System.Drawing.Size(196, 35);
            this.txb_Database.TabIndex = 5;
            // 
            // txb_Server
            // 
            this.txb_Server.Location = new System.Drawing.Point(129, 52);
            this.txb_Server.Margin = new System.Windows.Forms.Padding(6);
            this.txb_Server.Name = "txb_Server";
            this.txb_Server.Size = new System.Drawing.Size(196, 35);
            this.txb_Server.TabIndex = 4;
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(21, 115);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(82, 24);
            this.lbl_Database.TabIndex = 1;
            this.lbl_Database.Text = "数据库";
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(17, 55);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(82, 24);
            this.lbl_Server.TabIndex = 0;
            this.lbl_Server.Text = "服务器";
            // 
            // frm_Connection_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 416);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.gpb_Connection);
            this.Name = "frm_Connection_Config";
            this.Text = "数据库连接";
            this.gpb_Connection.ResumeLayout(false);
            this.gpb_Connection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.GroupBox gpb_Connection;
        private System.Windows.Forms.CheckBox ckb_IsWindowsAuthentication;
        private System.Windows.Forms.TextBox txb_Database;
        private System.Windows.Forms.TextBox txb_Server;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.Label lbl_Server;
    }
}