using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriBilgiSistemi.Services;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmMusteriEdit : Form
    {
        private IMusteriRepository _musteriRepository;
        public frmMusteriEdit(decimal _id)
        {
            InitializeComponent();
            _musteriRepository = new MusteriRepository();
            ID = _id;
        }
        private decimal ID;
        private void frmMusteriEdit_Load(object sender, EventArgs e)
        {
            var edit = _musteriRepository.Load(Convert.ToInt32(ID)).TransactionResult;
            lblRecordNumber.Text = ID.ToString();

            txtCustomerName.Text = edit.MusteriAdi;
            txtCustomerLastName.Text = edit.MusteriSoyadi;
            txtCustomerCompany.Text = edit.FirmaAdi;
            txtCompanyPhone.Text = edit.Telefon;
            txtCompanyddress.Text = edit.Adres;
            ckOnay.Checked = edit.Onay;
            dtTarih.Text = edit.Tarih.ToString();

        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var status = _musteriRepository.Delete(Convert.ToInt32(ID));
            MessageBox.Show("Kayıt Silindi.");
            this.Close();
        }
        }
}