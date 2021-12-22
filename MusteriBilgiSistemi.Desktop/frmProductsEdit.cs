using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriBilgiSistemi.Services;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmProductsEdit : Form
    {
        private IProductRepository _productRepository;

        public frmProductsEdit(decimal _proEditId)
        {
            _productRepository = new ProductRepository();
            InitializeComponent();
            _proId = _proEditId;}

        private decimal _proId;

        private void frmProductsEdit_Load(object sender, EventArgs e)
        {
            var edit = _productRepository.Load(Convert.ToInt32(_proId)).TransactionResult;
            lblProductName.Text = edit.ProductName;
            lblProductNumberId.Text = ((int)edit.ProductId).ToString();
            lblCategoryName.Text = edit.CategoryName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var status = _productRepository.Delete(Convert.ToInt32(_proId));
            MessageBox.Show("Kayıt Silindi.");
            this.Close();
        }
    }
}
