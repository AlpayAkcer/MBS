using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Layout;
using MusteriBilgiSistemi.Orm;
using MusteriBilgiSistemi.Services;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmPersonelList : Form
    {
        private MusteriBilgiSistemiEntities _musteriBilgiSistemiEntities;

        public frmPersonelList()
        {
            _musteriBilgiSistemiEntities = new MusteriBilgiSistemiEntities();
            InitializeComponent();
        }

        private void frmPersonelList_Load(object sender, EventArgs e)
        {
            var _products = from x in _musteriBilgiSistemiEntities.Musteriler
                            where x.Onay == x.Onay
                            orderby x.MusteriAdi + x.MusteriSoyadi
                            select new
                            {
                                x.MusteriAdi,
                                x.MusteriSoyadi
                            };
            foreach (var urunAdi in _products)
            {
                Button btn = new Button();
                btn.Width = 170;
                btn.Height = 100;
                btn.Text = urunAdi.MusteriAdi + " " + urunAdi.MusteriSoyadi.ToString();
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Font = new Font("Verdana", 9, FontStyle.Regular);
                btn.Click += btn_Click;
                btn.ForeColor = Color.DarkViolet;
                flowLayoutPanel1.Controls.Add(btn);}

        }

        private frmSiparis _frmSiparisEkle;
        void btn_Click(object sender, EventArgs e)
        {
            if (_frmSiparisEkle == null || _frmSiparisEkle.IsDisposed)
            {
                _frmSiparisEkle = new frmSiparis();
                _frmSiparisEkle.BringToFront();
                _frmSiparisEkle.Show();
            }
            else
            {

                _frmSiparisEkle.BringToFront();
                _frmSiparisEkle.Show();
            }
        }
    }
}
