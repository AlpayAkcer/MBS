namespace MusteriBilgiSistemi.Desktop
{
    partial class frmMusteriEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriEdit));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtTarih = new DevExpress.XtraEditors.DateEdit();
            this.ckOnay = new DevExpress.XtraEditors.CheckEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtCompanyPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyddress = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerCompany = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.lblRecordNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtTarih);
            this.groupControl1.Controls.Add(this.ckOnay);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.txtCompanyPhone);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtCompanyddress);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtCustomerCompany);
            this.groupControl1.Controls.Add(this.txtCustomerLastName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCustomerName);
            this.groupControl1.Controls.Add(this.lblRecordNumber);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(500, 645);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Müşteri Güncelleme Bölümü";
            // 
            // dtTarih
            // 
            this.dtTarih.EditValue = null;
            this.dtTarih.Location = new System.Drawing.Point(24, 487);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Size = new System.Drawing.Size(242, 22);
            this.dtTarih.TabIndex = 6;
            // 
            // ckOnay
            // 
            this.ckOnay.Location = new System.Drawing.Point(324, 444);
            this.ckOnay.Name = "ckOnay";
            this.ckOnay.Properties.Caption = "Müşteri Aktif mi.?";
            this.ckOnay.Size = new System.Drawing.Size(135, 20);
            this.ckOnay.TabIndex = 7;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(12, 578);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(107, 38);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(352, 578);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Müşteri Güncelle";
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Location = new System.Drawing.Point(24, 443);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(242, 22);
            this.txtCompanyPhone.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 420);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(138, 16);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Firma Telefon Numarası";
            // 
            // txtCompanyddress
            // 
            this.txtCompanyddress.Location = new System.Drawing.Point(24, 294);
            this.txtCompanyddress.Name = "txtCompanyddress";
            this.txtCompanyddress.Size = new System.Drawing.Size(435, 96);
            this.txtCompanyddress.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 268);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Firma Adresi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 186);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Müşteri Firma Ünvanı";
            // 
            // txtCustomerCompany
            // 
            this.txtCustomerCompany.Location = new System.Drawing.Point(24, 208);
            this.txtCustomerCompany.Name = "txtCustomerCompany";
            this.txtCustomerCompany.Size = new System.Drawing.Size(435, 22);
            this.txtCustomerCompany.TabIndex = 3;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(245, 121);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(214, 22);
            this.txtCustomerLastName.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(245, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Müşteri Soyadı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Müşteri Adı";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(24, 121);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(185, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblRecordNumber
            // 
            this.lblRecordNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblRecordNumber.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRecordNumber.Location = new System.Drawing.Point(175, 51);
            this.lblRecordNumber.Name = "lblRecordNumber";
            this.lblRecordNumber.Size = new System.Drawing.Size(0, 16);
            this.lblRecordNumber.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Müşteri Record Number";
            // 
            // btnSil
            // 
            this.btnSil.Image = global::MusteriBilgiSistemi.Desktop.Properties.Resources.Close_2_icon;
            this.btnSil.Location = new System.Drawing.Point(292, 578);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(54, 38);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmMusteriEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 645);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Güncelleme";
            this.Load += new System.EventHandler(this.frmMusteriEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblRecordNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCustomerCompany;
        private DevExpress.XtraEditors.TextEdit txtCustomerLastName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtCompanyPhone;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtCompanyddress;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.CheckEdit ckOnay;
        private DevExpress.XtraEditors.DateEdit dtTarih;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}