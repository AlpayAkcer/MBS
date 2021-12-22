using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriBilgiSistemi.Dto.Musteriler;
using MusteriBilgiSistemi.Services;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
            _musteriRepository = new MusteriRepository();
        }

        private IMusteriRepository _musteriRepository;


        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text))
            {
                errorProvider1.SetError(txtMusteriAdi, "Müşteri Adı Boş Geçilemez!");
                // Uyarı çıkartıyor ve uyarının üzerine geldiğinde "Boş Geçilemez!" diyor.
            }
            else
            {
                errorProvider1.Clear();
                var saveCustomer = _musteriRepository.Save(new MusteriAddDto()
                {
                    MusteriAdi = txtMusteriAdi.Text,
                    MusteriSoyadi = txtMusteriSoyadi.Text,
                    FirmaAdi = txtMusteriFirmaAdi.Text,
                    Telefon = txtMusteriTelefon.Text,
                    Tarih = dtTarih.DateTime,
                    Adres = txtMusteriAdres.Text,
                    Onay = ckOnay.CheckState == CheckState.Checked
                });
                lblSonuc.Text = "Müşteri Kayıt Edilmiştir.";
                grdMusteriListesi.DataSource = _musteriRepository.ListOf().TransactionResult;
                TextTemizle();
                // Uyarı simgesini kaldırıyor.
            }

        }
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            dtTarih.Text = DateTime.Now.ToString();
            grdMusteriListesi.DataSource = _musteriRepository.ListOf().TransactionResult;
        }

        public void TextTemizle()
        {
            txtMusteriTelefon.Text = "";
            txtMusteriAdi.Text = "";
            txtMusteriAdres.Text = "";
            txtMusteriFirmaAdi.Text = "";
            txtMusteriSoyadi.Text = "";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TextTemizle();
        }

        private frmMusteriEdit _me;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (_me == null || _me.IsDisposed)
            {
                decimal row = Convert.ToDecimal(gridView1.FocusedRowHandle);
                decimal cellValue = Convert.ToDecimal(gridView1.GetRowCellValue(Convert.ToInt32(row), "MusteriId"));
                _me = new frmMusteriEdit(cellValue);
                _me.Show();
            }
            else
            {
                _me.Show();
            }
        }

    }
}
