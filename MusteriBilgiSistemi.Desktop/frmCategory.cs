using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriBilgiSistemi.Dto.Categories;
using MusteriBilgiSistemi.Services;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmCategory : Form
    {
        private ICategoryRepository _categoryRepository;
        public frmCategory()
        {
            _categoryRepository = new CategoryRepository();
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            grdKategoriListesi.DataSource = _categoryRepository.ListOf().TransactionResult;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == String.Empty)
            {
                MessageBox.Show("Kategori Adını Boş Bırakmayınız...");
            }
            else
            {
                var saveCategory = _categoryRepository.Save(new CategoryAddDto()
                {
                    CategoryName = txtCategoryName.Text,
                    Description = txtAciklama.Text,
                    Onay = ckOnay.CheckState == CheckState.Checked
                });
                grdKategoriListesi.DataSource = _categoryRepository.ListOf().TransactionResult;
                MessageBox.Show("Kayıt Edildi...");
            }
        }

        public void TextTemizle()
        {
            txtCategoryName.Text = "";
            txtAciklama.Text = "";

        }

    }
}
