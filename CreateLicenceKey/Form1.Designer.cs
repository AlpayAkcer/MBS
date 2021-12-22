namespace CreateLicenceKey
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lstLicenceList = new System.Windows.Forms.ListBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.lstMailList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmailAdresi = new System.Windows.Forms.Label();
            this.lblMailSonucuIletisi = new System.Windows.Forms.Label();
            this.btnSecilenitemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(983, 763);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Lisanslama";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl3.Controls.Add(this.groupBox1);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.btnCreate);
            this.groupControl3.Controls.Add(this.numericUpDown1);
            this.groupControl3.Controls.Add(this.lstLicenceList);
            this.groupControl3.Location = new System.Drawing.Point(487, 37);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(484, 714);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Create Product Licence Key";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Licence Quantity";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreate.ImageOptions.SvgImage")));
            this.btnCreate.Location = new System.Drawing.Point(329, 42);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 47);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create \r\nLicence Key";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(136, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstLicenceList
            // 
            this.lstLicenceList.FormattingEnabled = true;
            this.lstLicenceList.ItemHeight = 16;
            this.lstLicenceList.Location = new System.Drawing.Point(6, 97);
            this.lstLicenceList.Name = "lstLicenceList";
            this.lstLicenceList.Size = new System.Drawing.Size(468, 404);
            this.lstLicenceList.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSecilenitemizle);
            this.groupControl2.Controls.Add(this.btnGonder);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.txtMail);
            this.groupControl2.Controls.Add(this.lstMailList);
            this.groupControl2.Location = new System.Drawing.Point(12, 37);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(468, 714);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "E-mail Listesi";
            // 
            // btnGonder
            // 
            this.btnGonder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.Location = new System.Drawing.Point(6, 635);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(327, 74);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(374, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(5, 39);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(363, 22);
            this.txtMail.TabIndex = 1;
            // 
            // lstMailList
            // 
            this.lstMailList.FormattingEnabled = true;
            this.lstMailList.ItemHeight = 16;
            this.lstMailList.Location = new System.Drawing.Point(6, 78);
            this.lstMailList.Name = "lstMailList";
            this.lstMailList.Size = new System.Drawing.Size(457, 548);
            this.lstMailList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMailSonucuIletisi);
            this.groupBox1.Controls.Add(this.lblEmailAdresi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lisans Sonucu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lisans Gönderimi:";
            // 
            // lblEmailAdresi
            // 
            this.lblEmailAdresi.AutoSize = true;
            this.lblEmailAdresi.Location = new System.Drawing.Point(127, 74);
            this.lblEmailAdresi.Name = "lblEmailAdresi";
            this.lblEmailAdresi.Size = new System.Drawing.Size(79, 17);
            this.lblEmailAdresi.TabIndex = 1;
            this.lblEmailAdresi.Text = "Email Adresi";
            // 
            // lblMailSonucuIletisi
            // 
            this.lblMailSonucuIletisi.AutoSize = true;
            this.lblMailSonucuIletisi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailSonucuIletisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMailSonucuIletisi.Location = new System.Drawing.Point(9, 116);
            this.lblMailSonucuIletisi.Name = "lblMailSonucuIletisi";
            this.lblMailSonucuIletisi.Size = new System.Drawing.Size(0, 21);
            this.lblMailSonucuIletisi.TabIndex = 2;
            // 
            // btnSecilenitemizle
            // 
            this.btnSecilenitemizle.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.btnSecilenitemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSecilenitemizle.Location = new System.Drawing.Point(339, 635);
            this.btnSecilenitemizle.Name = "btnSecilenitemizle";
            this.btnSecilenitemizle.Size = new System.Drawing.Size(124, 74);
            this.btnSecilenitemizle.TabIndex = 4;
            this.btnSecilenitemizle.Text = "Seçileni \r\nTemizle";
            this.btnSecilenitemizle.Click += new System.EventHandler(this.btnSecilenitemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 763);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox lstLicenceList;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private System.Windows.Forms.ListBox lstMailList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMailSonucuIletisi;
        private System.Windows.Forms.Label lblEmailAdresi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSecilenitemizle;
    }
}

