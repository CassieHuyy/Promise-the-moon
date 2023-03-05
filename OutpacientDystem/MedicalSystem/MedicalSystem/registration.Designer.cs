namespace MedicalSystem
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFresh = new System.Windows.Forms.Button();
            this.btnregisterationback = new System.Windows.Forms.Button();
            this.btnsearchpatient = new System.Windows.Forms.Button();
            this.btnCreatepatient = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnregister = new System.Windows.Forms.Button();
            this.lblregisterTime = new System.Windows.Forms.Label();
            this.txbregistermoney = new System.Windows.Forms.TextBox();
            this.cmbregisterDoctor = new System.Windows.Forms.ComboBox();
            this.cmbOffice = new System.Windows.Forms.ComboBox();
            this.lblRegisterMoney = new System.Windows.Forms.Label();
            this.lblregisterdoctor = new System.Windows.Forms.Label();
            this.lblregistertype = new System.Windows.Forms.Label();
            this.lbloffice = new System.Windows.Forms.Label();
            this.txbpinying = new System.Windows.Forms.TextBox();
            this.lblpinying = new System.Windows.Forms.Label();
            this.txbpaytype = new System.Windows.Forms.TextBox();
            this.lblpay = new System.Windows.Forms.Label();
            this.txtmedicalid = new System.Windows.Forms.TextBox();
            this.txbname = new System.Windows.Forms.TextBox();
            this.lblpatientname = new System.Windows.Forms.Label();
            this.lblMedicalID = new System.Windows.Forms.Label();
            this.txtregisterType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnregisterationback);
            this.splitContainer1.Panel1.Controls.Add(this.btnsearchpatient);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreatepatient);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtregisterType);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.btnregister);
            this.splitContainer1.Panel2.Controls.Add(this.lblregisterTime);
            this.splitContainer1.Panel2.Controls.Add(this.txbregistermoney);
            this.splitContainer1.Panel2.Controls.Add(this.cmbregisterDoctor);
            this.splitContainer1.Panel2.Controls.Add(this.cmbOffice);
            this.splitContainer1.Panel2.Controls.Add(this.lblRegisterMoney);
            this.splitContainer1.Panel2.Controls.Add(this.lblregisterdoctor);
            this.splitContainer1.Panel2.Controls.Add(this.lblregistertype);
            this.splitContainer1.Panel2.Controls.Add(this.lbloffice);
            this.splitContainer1.Panel2.Controls.Add(this.txbpinying);
            this.splitContainer1.Panel2.Controls.Add(this.lblpinying);
            this.splitContainer1.Panel2.Controls.Add(this.txbpaytype);
            this.splitContainer1.Panel2.Controls.Add(this.lblpay);
            this.splitContainer1.Panel2.Controls.Add(this.txtmedicalid);
            this.splitContainer1.Panel2.Controls.Add(this.txbname);
            this.splitContainer1.Panel2.Controls.Add(this.lblpatientname);
            this.splitContainer1.Panel2.Controls.Add(this.lblMedicalID);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(863, 460);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnFresh
            // 
            this.btnFresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFresh.BackgroundImage")));
            this.btnFresh.Location = new System.Drawing.Point(47, 215);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(75, 73);
            this.btnFresh.TabIndex = 3;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // btnregisterationback
            // 
            this.btnregisterationback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregisterationback.BackgroundImage")));
            this.btnregisterationback.Location = new System.Drawing.Point(47, 306);
            this.btnregisterationback.Name = "btnregisterationback";
            this.btnregisterationback.Size = new System.Drawing.Size(75, 73);
            this.btnregisterationback.TabIndex = 2;
            this.btnregisterationback.Text = "返回";
            this.btnregisterationback.UseVisualStyleBackColor = true;
            this.btnregisterationback.Click += new System.EventHandler(this.btnregisterationback_Click);
            // 
            // btnsearchpatient
            // 
            this.btnsearchpatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearchpatient.BackgroundImage")));
            this.btnsearchpatient.Location = new System.Drawing.Point(47, 129);
            this.btnsearchpatient.Name = "btnsearchpatient";
            this.btnsearchpatient.Size = new System.Drawing.Size(75, 74);
            this.btnsearchpatient.TabIndex = 1;
            this.btnsearchpatient.Text = "查找病人";
            this.btnsearchpatient.UseVisualStyleBackColor = true;
            this.btnsearchpatient.Click += new System.EventHandler(this.btnsearchpatient_Click);
            // 
            // btnCreatepatient
            // 
            this.btnCreatepatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreatepatient.BackgroundImage")));
            this.btnCreatepatient.Location = new System.Drawing.Point(47, 47);
            this.btnCreatepatient.Name = "btnCreatepatient";
            this.btnCreatepatient.Size = new System.Drawing.Size(75, 73);
            this.btnCreatepatient.TabIndex = 0;
            this.btnCreatepatient.Text = "建档";
            this.btnCreatepatient.UseVisualStyleBackColor = true;
            this.btnCreatepatient.Click += new System.EventHandler(this.btnCreatepatient_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 112;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(294, 344);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 111;
            this.btnregister.Text = "挂号";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // lblregisterTime
            // 
            this.lblregisterTime.AutoSize = true;
            this.lblregisterTime.Location = new System.Drawing.Point(50, 273);
            this.lblregisterTime.Name = "lblregisterTime";
            this.lblregisterTime.Size = new System.Drawing.Size(82, 15);
            this.lblregisterTime.TabIndex = 109;
            this.lblregisterTime.Text = "挂号时间：";
            // 
            // txbregistermoney
            // 
            this.txbregistermoney.Location = new System.Drawing.Point(450, 229);
            this.txbregistermoney.Name = "txbregistermoney";
            this.txbregistermoney.Size = new System.Drawing.Size(100, 25);
            this.txbregistermoney.TabIndex = 108;
            // 
            // cmbregisterDoctor
            // 
            this.cmbregisterDoctor.FormattingEnabled = true;
            this.cmbregisterDoctor.Location = new System.Drawing.Point(451, 183);
            this.cmbregisterDoctor.Name = "cmbregisterDoctor";
            this.cmbregisterDoctor.Size = new System.Drawing.Size(121, 23);
            this.cmbregisterDoctor.TabIndex = 107;
            this.cmbregisterDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbregisterDoctor_SelectedIndexChanged);
            // 
            // cmbOffice
            // 
            this.cmbOffice.FormattingEnabled = true;
            this.cmbOffice.Location = new System.Drawing.Point(131, 183);
            this.cmbOffice.Name = "cmbOffice";
            this.cmbOffice.Size = new System.Drawing.Size(121, 23);
            this.cmbOffice.TabIndex = 105;
            this.cmbOffice.SelectedIndexChanged += new System.EventHandler(this.cmbOffice_SelectedIndexChanged);
            // 
            // lblRegisterMoney
            // 
            this.lblRegisterMoney.AutoSize = true;
            this.lblRegisterMoney.Location = new System.Drawing.Point(370, 232);
            this.lblRegisterMoney.Name = "lblRegisterMoney";
            this.lblRegisterMoney.Size = new System.Drawing.Size(82, 15);
            this.lblRegisterMoney.TabIndex = 104;
            this.lblRegisterMoney.Text = "挂号费用：";
            // 
            // lblregisterdoctor
            // 
            this.lblregisterdoctor.AutoSize = true;
            this.lblregisterdoctor.Location = new System.Drawing.Point(370, 183);
            this.lblregisterdoctor.Name = "lblregisterdoctor";
            this.lblregisterdoctor.Size = new System.Drawing.Size(82, 15);
            this.lblregisterdoctor.TabIndex = 103;
            this.lblregisterdoctor.Text = "挂号医生：";
            // 
            // lblregistertype
            // 
            this.lblregistertype.AutoSize = true;
            this.lblregistertype.Location = new System.Drawing.Point(50, 229);
            this.lblregistertype.Name = "lblregistertype";
            this.lblregistertype.Size = new System.Drawing.Size(82, 15);
            this.lblregistertype.TabIndex = 102;
            this.lblregistertype.Text = "挂号类型：";
            // 
            // lbloffice
            // 
            this.lbloffice.AutoSize = true;
            this.lbloffice.Location = new System.Drawing.Point(50, 183);
            this.lbloffice.Name = "lbloffice";
            this.lbloffice.Size = new System.Drawing.Size(82, 15);
            this.lbloffice.TabIndex = 101;
            this.lbloffice.Text = "挂号科室：";
            // 
            // txbpinying
            // 
            this.txbpinying.Location = new System.Drawing.Point(435, 133);
            this.txbpinying.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbpinying.Name = "txbpinying";
            this.txbpinying.Size = new System.Drawing.Size(100, 25);
            this.txbpinying.TabIndex = 100;
            // 
            // lblpinying
            // 
            this.lblpinying.AutoSize = true;
            this.lblpinying.Location = new System.Drawing.Point(370, 143);
            this.lblpinying.Name = "lblpinying";
            this.lblpinying.Size = new System.Drawing.Size(60, 15);
            this.lblpinying.TabIndex = 99;
            this.lblpinying.Text = "拼音码:";
            // 
            // txbpaytype
            // 
            this.txbpaytype.Location = new System.Drawing.Point(131, 143);
            this.txbpaytype.Name = "txbpaytype";
            this.txbpaytype.Size = new System.Drawing.Size(100, 25);
            this.txbpaytype.TabIndex = 98;
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.Location = new System.Drawing.Point(50, 146);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(82, 15);
            this.lblpay.TabIndex = 97;
            this.lblpay.Text = "计费类型：";
            // 
            // txtmedicalid
            // 
            this.txtmedicalid.Location = new System.Drawing.Point(131, 95);
            this.txtmedicalid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmedicalid.Name = "txtmedicalid";
            this.txtmedicalid.Size = new System.Drawing.Size(100, 25);
            this.txtmedicalid.TabIndex = 96;
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(435, 85);
            this.txbname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(100, 25);
            this.txbname.TabIndex = 95;
            // 
            // lblpatientname
            // 
            this.lblpatientname.AutoSize = true;
            this.lblpatientname.Location = new System.Drawing.Point(370, 95);
            this.lblpatientname.Name = "lblpatientname";
            this.lblpatientname.Size = new System.Drawing.Size(45, 15);
            this.lblpatientname.TabIndex = 94;
            this.lblpatientname.Text = "姓名:";
            // 
            // lblMedicalID
            // 
            this.lblMedicalID.AutoSize = true;
            this.lblMedicalID.Location = new System.Drawing.Point(53, 98);
            this.lblMedicalID.Name = "lblMedicalID";
            this.lblMedicalID.Size = new System.Drawing.Size(75, 15);
            this.lblMedicalID.TabIndex = 93;
            this.lblMedicalID.Text = "医保卡号:";
            // 
            // txtregisterType
            // 
            this.txtregisterType.Location = new System.Drawing.Point(131, 226);
            this.txtregisterType.Name = "txtregisterType";
            this.txtregisterType.Size = new System.Drawing.Size(121, 25);
            this.txtregisterType.TabIndex = 113;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(863, 460);
            this.Controls.Add(this.splitContainer1);
            this.Name = "registration";
            this.Text = "看诊挂号";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnregisterationback;
        private System.Windows.Forms.Button btnsearchpatient;
        private System.Windows.Forms.Button btnCreatepatient;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label lblregisterTime;
        private System.Windows.Forms.TextBox txbregistermoney;
        private System.Windows.Forms.ComboBox cmbregisterDoctor;
        private System.Windows.Forms.ComboBox cmbOffice;
        private System.Windows.Forms.Label lblRegisterMoney;
        private System.Windows.Forms.Label lblregisterdoctor;
        private System.Windows.Forms.Label lblregistertype;
        private System.Windows.Forms.Label lbloffice;
        private System.Windows.Forms.TextBox txbpinying;
        private System.Windows.Forms.Label lblpinying;
        private System.Windows.Forms.TextBox txbpaytype;
        private System.Windows.Forms.Label lblpay;
        private System.Windows.Forms.TextBox txtmedicalid;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.Label lblpatientname;
        private System.Windows.Forms.Label lblMedicalID;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtregisterType;
    }
}