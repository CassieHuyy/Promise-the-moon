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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchpatient
            // 
            this.lblSearchpatient.AutoSize = true;
            this.lblSearchpatient.Location = new System.Drawing.Point(12, 30);
            this.lblSearchpatient.Name = "lblSearchpatient";
            this.lblSearchpatient.Size = new System.Drawing.Size(106, 15);
            this.lblSearchpatient.TabIndex = 0;
            this.lblSearchpatient.Text = "拼音码(姓名):";
            // 
            // txbpingyin
            // 
            this.txbpingyin.Location = new System.Drawing.Point(134, 21);
            this.txbpingyin.Name = "txbpingyin";
            this.txbpingyin.Size = new System.Drawing.Size(100, 25);
            this.txbpingyin.TabIndex = 1;
            // 
            // btnchosen
            // 
            this.btnchosen.Location = new System.Drawing.Point(392, 20);
            this.btnchosen.Name = "btnchosen";
            this.btnchosen.Size = new System.Drawing.Size(75, 23);
            this.btnchosen.TabIndex = 2;
            this.btnchosen.Text = "选定";
            this.btnchosen.UseVisualStyleBackColor = true;
            this.btnchosen.Click += new System.EventHandler(this.btnchosen_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(520, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgv_patient
            // 
            this.dgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patient.Location = new System.Drawing.Point(13, 81);
            this.dgv_patient.Name = "dgv_patient";
            this.dgv_patient.RowTemplate.Height = 27;
            this.dgv_patient.Size = new System.Drawing.Size(760, 191);
            this.dgv_patient.TabIndex = 4;
            this.dgv_patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patient_CellContentClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(267, 21);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "查找";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // searchpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dgv_patient);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnchosen);
            this.Controls.Add(this.txbpingyin);
            this.Controls.Add(this.lblSearchpatient);
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
    }
}