namespace MedicalSystem
{
    partial class Desktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnregisteration = new System.Windows.Forms.Button();
            this.btnDoctorSee = new System.Windows.Forms.Button();
            this.btnPharmacy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(67, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 131);
            this.button1.TabIndex = 1;
            this.button1.Text = "门诊登记";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnregisteration
            // 
            this.btnregisteration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregisteration.BackgroundImage")));
            this.btnregisteration.Location = new System.Drawing.Point(67, 282);
            this.btnregisteration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnregisteration.Name = "btnregisteration";
            this.btnregisteration.Size = new System.Drawing.Size(130, 131);
            this.btnregisteration.TabIndex = 2;
            this.btnregisteration.Text = "门诊挂号";
            this.btnregisteration.UseVisualStyleBackColor = true;
            this.btnregisteration.Click += new System.EventHandler(this.btnregisteration_Click);
            // 
            // btnDoctorSee
            // 
            this.btnDoctorSee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctorSee.BackgroundImage")));
            this.btnDoctorSee.Location = new System.Drawing.Point(67, 460);
            this.btnDoctorSee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoctorSee.Name = "btnDoctorSee";
            this.btnDoctorSee.Size = new System.Drawing.Size(130, 131);
            this.btnDoctorSee.TabIndex = 3;
            this.btnDoctorSee.Text = "看诊";
            this.btnDoctorSee.UseVisualStyleBackColor = true;
            this.btnDoctorSee.Click += new System.EventHandler(this.btnDoctorSee_Click);
            // 
            // btnPharmacy
            // 
            this.btnPharmacy.Location = new System.Drawing.Point(299, 203);
            this.btnPharmacy.Name = "btnPharmacy";
            this.btnPharmacy.Size = new System.Drawing.Size(118, 120);
            this.btnPharmacy.TabIndex = 4;
            this.btnPharmacy.Text = "药房";
            this.btnPharmacy.UseVisualStyleBackColor = true;
            this.btnPharmacy.Click += new System.EventHandler(this.btnPharmacy_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.btnPharmacy);
            this.Controls.Add(this.btnDoctorSee);
            this.Controls.Add(this.btnregisteration);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Desktop";
            this.Text = "主页面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnregisteration;
        private System.Windows.Forms.Button btnDoctorSee;
        private System.Windows.Forms.Button btnPharmacy;
    }
}