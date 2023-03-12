namespace MedicalSystem
{
    partial class searchpatient
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
            this.lblSearchpatient = new System.Windows.Forms.Label();
            this.txbpingyin = new System.Windows.Forms.TextBox();
            this.btnchosen = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgv_patient = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchpatient
            // 
            this.lblSearchpatient.AutoSize = true;
            this.lblSearchpatient.Location = new System.Drawing.Point(18, 48);
            this.lblSearchpatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchpatient.Name = "lblSearchpatient";
            this.lblSearchpatient.Size = new System.Drawing.Size(166, 24);
            this.lblSearchpatient.TabIndex = 0;
            this.lblSearchpatient.Text = "拼音码(姓名):";
            // 
            // txbpingyin
            // 
            this.txbpingyin.Location = new System.Drawing.Point(200, 34);
            this.txbpingyin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbpingyin.Name = "txbpingyin";
            this.txbpingyin.Size = new System.Drawing.Size(148, 35);
            this.txbpingyin.TabIndex = 1;
            // 
            // btnchosen
            // 
            this.btnchosen.Location = new System.Drawing.Point(588, 32);
            this.btnchosen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnchosen.Name = "btnchosen";
            this.btnchosen.Size = new System.Drawing.Size(112, 36);
            this.btnchosen.TabIndex = 2;
            this.btnchosen.Text = "选定";
            this.btnchosen.UseVisualStyleBackColor = true;
            this.btnchosen.Click += new System.EventHandler(this.btnchosen_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(780, 32);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgv_patient
            // 
            this.dgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patient.Location = new System.Drawing.Point(20, 130);
            this.dgv_patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_patient.Name = "dgv_patient";
            this.dgv_patient.RowHeadersWidth = 82;
            this.dgv_patient.RowTemplate.Height = 27;
            this.dgv_patient.Size = new System.Drawing.Size(1140, 306);
            this.dgv_patient.TabIndex = 4;
            this.dgv_patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patient_CellContentClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(400, 34);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(112, 36);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "查找";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(766, 575);
            this.btn_load.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(150, 46);
            this.btn_load.TabIndex = 8;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // searchpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dgv_patient);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnchosen);
            this.Controls.Add(this.txbpingyin);
            this.Controls.Add(this.lblSearchpatient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "searchpatient";
            this.Text = "选择病人";
            this.Load += new System.EventHandler(this.searchpatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchpatient;
        private System.Windows.Forms.TextBox txbpingyin;
        private System.Windows.Forms.Button btnchosen;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgv_patient;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btn_load;
    }
}