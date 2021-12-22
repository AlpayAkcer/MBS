using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriBilgiSistemi.Dto.Urunler;
using MusteriBilgiSistemi.Services;
using MusteriBilgiSistemi.Common;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmProducts : Form
    {
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;
        public frmProducts()
        {
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            InitializeComponent();
        }

        private frmProductsEdit _products;
        private void frmProducts_Load(object sender, EventArgs e)
        {

            urunleriGetir();
            cmbCategory.DataSource = _categoryRepository.ListOf().TransactionResult;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider1.SetError(txtProductName, "Ürün Adı Boş Geçilemez!");
                // Uyarı çıkartıyor ve uyarının üzerine geldiğinde "Boş Geçilemez!" diyor.
            }
            else
            {
                errorProvider1.RightToLeft = AutoSize;
                errorProvider1.Clear();
                var saveProduct = _productRepository.Save(new ProductAddDto()
                {
                    CategoryId = Convert.ToInt32(cmbCategory.SelectedValue.ToString()),
                    Onay = ckOnay.CheckState == CheckState.Checked,
                    ProductName = txtProductName.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtStokAdet.Text),
                    Description = txtAciklama.Text,
                    Tarih = DateTime.Now
                });
                lblSonuc.Text = "Kayıt Tamamlanmıştır.";

                urunleriGetir();
            }
        }

        private SqlConnection baglanti;
        void urunleriGetir()
        {
            listView1.Items.Clear();
            baglanti = new SqlConnection("Server=.;Database=MusteriBilgiSistemi;uid=sa;pwd=4675190;");
            SqlCommand komut = new SqlCommand("select ProductID, ProductName, UnitPrice, UnitInStock,Onay from Products",
                baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = rd[0].ToString();
                item.SubItems.Add(rd[1].ToString());
                item.SubItems.Add(rd[2].ToString());
                item.SubItems.Add(rd[3].ToString());
                item.SubItems.Add(rd[4].ToString());
                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //    if (txtUnitPrice.Text != "")
            //    {
            //        decimal fiyat;
            //        fiyat = Convert.ToDecimal(txtUnitPrice.Text);
            //        txtKdv.Text = Convert.ToString(fiyat + (100 / fiyat) * Convert.ToInt32(txtStokAdet.Text));
            //    }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //if (_products == null || _products.IsDisposed)
            //{
            //    decimal row = Convert.ToDecimal(listView1.Focused);
            //    decimal cellValue = Convert.ToDecimal(listView1.GetItemAt(Convert.ToInt32(row)));
            //    _products = new frmProductsEdit(cellValue);
            //    _products.Show();
            //}
            //else
            //{
            //    _products.Show();
            //}
        }


    }
}