namespace MusteriBilgiSistemi.Desktop
{
    partial class frmUrunList
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
            this.txtFiyati = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktari = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.cmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTeoplamTutar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktari.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(82, 141);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(119, 22);
            this.txtFiyati.TabIndex = 1;
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(82, 189);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(119, 22);
            this.txtMiktari.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(197, 256);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(124, 44);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Sepet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbUrunAdi
            // 
            this.cmbUrunAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunAdi.FormattingEnabled = true;
            this.cmbUrunAdi.Location = new System.Drawing.Point(82, 93);
            this.cmbUrunAdi.Name = "cmbUrunAdi";
            this.cmbUrunAdi.Size = new System.Drawing.Size(239, 24);
            this.cmbUrunAdi.TabIndex = 5;
            this.cmbUrunAdi.SelectedIndexChanged += new System.EventHandler(this.cmbUrunAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(443, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(555, 257);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 285;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fİyat";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tutar";
            this.columnHeader4.Width = 107;
            // 
            // txtTeoplamTutar
            // 
            this.txtTeoplamTutar.Location = new System.Drawing.Point(780, 418);
            this.txtTeoplamTutar.Name = "txtTeoplamTutar";
            this.txtTeoplamTutar.Size = new System.Drawing.Size(254, 22);
            this.txtTeoplamTutar.TabIndex = 8;
            // 
            // frmUrunList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 665);
            this.Controls.Add(this.txtTeoplamTutar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrunAdi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.txtFiyati);
            this.Name = "frmUrunList";
            this.Text = "frmUrunList";
            this.Load += new System.EventHandler(this.frmUrunList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktari.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFiyati;
        private DevExpress.XtraEditors.TextEdit txtMiktari;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ComboBox cmbUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTeoplamTutar;
    }
}