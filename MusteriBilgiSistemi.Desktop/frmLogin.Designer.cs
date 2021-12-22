namespace MusteriBilgiSistemi.Desktop
{
    partial class frmLogin
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblSonuc = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSecurityCode = new DevExpress.XtraEditors.LabelControl();
            this.btnPasswordGoster = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefleshCode = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGuvenlik = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuvenlik.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImage = global::MusteriBilgiSistemi.Desktop.Properties.Resources.customer;
            this.groupControl1.Controls.Add(this.lblSonuc);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.txtKullaniciAdi);
            this.groupControl1.Controls.Add(this.lblSecurityCode);
            this.groupControl1.Controls.Add(this.btnPasswordGoster);
            this.groupControl1.Controls.Add(this.btnRefleshCode);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtGuvenlik);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(480, 336);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kullanıcı Girişi";
            // 
            // lblSonuc
            // 
            this.lblSonuc.Location = new System.Drawing.Point(175, 38);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(171, 78);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(217, 23);
            this.txtKullaniciAdi.TabIndex = 8;
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.Location = new System.Drawing.Point(175, 155);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(0, 16);
            this.lblSecurityCode.TabIndex = 7;
            // 
            // btnPasswordGoster
            // 
            this.btnPasswordGoster.Image = global::MusteriBilgiSistemi.Desktop.Properties.Resources._1468516384_icon_eye;
            this.btnPasswordGoster.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPasswordGoster.Location = new System.Drawing.Point(394, 111);
            this.btnPasswordGoster.Name = "btnPasswordGoster";
            this.btnPasswordGoster.Size = new System.Drawing.Size(40, 28);
            this.btnPasswordGoster.TabIndex = 6;
            this.btnPasswordGoster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPasswordGoster_MouseDown);
            this.btnPasswordGoster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPasswordGoster_MouseUp);
            // 
            // btnRefleshCode
            // 
            this.btnRefleshCode.Image = global::MusteriBilgiSistemi.Desktop.Properties.Resources._1468516201_Refresh;
            this.btnRefleshCode.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnRefleshCode.Location = new System.Drawing.Point(394, 148);
            this.btnRefleshCode.Name = "btnRefleshCode";
            this.btnRefleshCode.Size = new System.Drawing.Size(40, 28);
            this.btnRefleshCode.TabIndex = 6;
            this.btnRefleshCode.Click += new System.EventHandler(this.btnRefleshCode_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(76, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Güvenlik Kodu";
            // 
            // txtGuvenlik
            // 
            this.txtGuvenlik.Location = new System.Drawing.Point(256, 151);
            this.txtGuvenlik.Name = "txtGuvenlik";
            this.txtGuvenlik.Size = new System.Drawing.Size(132, 22);
            this.txtGuvenlik.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::MusteriBilgiSistemi.Desktop.Properties.Resources._1468519822_login;
            this.btnLogin.Location = new System.Drawing.Point(339, 245);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(76, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şifreniz:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kullanıcı Adınız:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 336);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuvenlik.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtGuvenlik;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefleshCode;
        private DevExpress.XtraEditors.LabelControl lblSecurityCode;
        private DevExpress.XtraEditors.SimpleButton btnPasswordGoster;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblSonuc;
    }
}