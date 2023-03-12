namespace MedicalSystem
{
    partial class Pharmacy
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.dgv_Parmacy = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parmacy)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(582, 564);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(150, 46);
            this.btn_Load.TabIndex = 51;
            this.btn_Load.Text = "载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // dgv_Parmacy
            // 
            this.dgv_Parmacy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Parmacy.Location = new System.Drawing.Point(24, 44);
            this.dgv_Parmacy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgv_Parmacy.Name = "dgv_Parmacy";
            this.dgv_Parmacy.RowHeadersWidth = 82;
            this.dgv_Parmacy.RowTemplate.Height = 23;
            this.dgv_Parmacy.Size = new System.Drawing.Size(948, 448);
            this.dgv_Parmacy.TabIndex = 53;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(788, 564);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(150, 46);
            this.btn_Update.TabIndex = 52;
            this.btn_Update.Text = "更新";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 664);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.dgv_Parmacy);
            this.Controls.Add(this.btn_Update);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pharmacy";
            this.Text = "药房";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parmacy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.DataGridView dgv_Parmacy;
        private System.Windows.Forms.Button btn_Update;
    }
}