namespace MusteriBilgiSistemi.Desktop
{
    partial class frmMusteri
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ckOnay = new DevExpress.XtraEditors.CheckEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.lblSonuc = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriTelefon = new DevExpress.XtraEditors.TextEdit();
            this.btnMusteriEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtMusteriAdres = new DevExpress.XtraEditors.MemoEdit();
            this.txtMusteriFirmaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtMusteriSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdMusteriListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriFirmaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.dtTarih);
            this.groupControl1.Controls.Add(this.ckOnay);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.lblSonuc);
            this.groupControl1.Controls.Add(this.txtMusteriTelefon);
            this.groupControl1.Controls.Add(this.btnMusteriEkle);
            this.groupControl1.Controls.Add(this.txtMusteriAdres);
            this.groupControl1.Controls.Add(this.txtMusteriFirmaAdi);
            this.groupControl1.Controls.Add(this.txtMusteriSoyadi);
            this.groupControl1.Controls.Add(this.txtMusteriAdi);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(627, 727);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Yeni Müşteri Kayıt Alanı";
            // 
            // ckOnay
            // 
            this.ckOnay.Location = new System.Drawing.Point(21, 579);
            this.ckOnay.Name = "ckOnay";
            this.ckOnay.Properties.Caption = "Aktif Edilsinmi.?";
            this.ckOnay.Size = new System.Drawing.Size(133, 20);
            this.ckOnay.TabIndex = 13;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(368, 661);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(116, 34);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Location = new System.Drawing.Point(21, 42);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 11;
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(21, 541);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(284, 22);
            this.txtMusteriTelefon.TabIndex = 10;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(490, 661);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(116, 34);
            this.btnMusteriEkle.TabIndex = 9;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(21, 345);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(516, 138);
            this.txtMusteriAdres.TabIndex = 8;
            // 
            // txtMusteriFirmaAdi
            // 
            this.txtMusteriFirmaAdi.Location = new System.Drawing.Point(21, 272);
            this.txtMusteriFirmaAdi.Name = "txtMusteriFirmaAdi";
            this.txtMusteriFirmaAdi.Size = new System.Drawing.Size(516, 22);
            this.txtMusteriFirmaAdi.TabIndex = 7;
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(21, 189);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(417, 22);
            this.txtMusteriSoyadi.TabIndex = 6;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(21, 127);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(417, 22);
            this.txtMusteriAdi.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 513);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Telefon";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 313);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Adres";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 238);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Firma Bilgileri";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 166);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Müşteri Soyadı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 100);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Müşteri Adı";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.grdMusteriListesi);
            this.groupControl2.Location = new System.Drawing.Point(646, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(505, 726);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Kayıtlı Müşteri Listesi";
            // 
            // grdMusteriListesi
            // 
            this.grdMusteriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMusteriListesi.Location = new System.Drawing.Point(2, 23);
            this.grdMusteriListesi.MainView = this.gridView1;
            this.grdMusteriListesi.Name = "grdMusteriListesi";
            this.grdMusteriListesi.Size = new System.Drawing.Size(501, 701);
            this.grdMusteriListesi.TabIndex = 0;
            this.grdMusteriListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdMusteriListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtTarih
            // 
            this.dtTarih.EditValue = null;
            this.dtTarih.Location = new System.Drawing.Point(21, 622);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Size = new System.Drawing.Size(194, 22);
            this.dtTarih.TabIndex = 14;
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 751);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmMusteri";
            this.ShowIcon = false;
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriFirmaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtMusteriAdres;
        private DevExpress.XtraEditors.TextEdit txtMusteriFirmaAdi;
        private DevExpress.XtraEditors.TextEdit txtMusteriSoyadi;
        private DevExpress.XtraEditors.TextEdit txtMusteriAdi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grdMusteriListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtMusteriTelefon;
        private DevExpress.XtraEditors.SimpleButton btnMusteriEkle;
        private DevExpress.XtraEditors.LabelControl lblSonuc;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.CheckEdit ckOnay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.DateEdit dtTarih;
    }
}