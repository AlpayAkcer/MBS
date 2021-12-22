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
using DevExpress.Skins;
using MusteriBilgiSistemi.Services;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmUrunList : Form
    {
        public frmUrunList()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
        }

        SqlConnection sql = new SqlConnection("server=.; database=MusteriBilgiSistemi; trusted_connection=true;"); //bağlantıyı global tanıladık
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sql;
            cmd.CommandText = "sp_urunkayit"; // Oluşturduğumuz procedure ü burada çağırıyoruz.
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urunadi", cmbUrunAdi.Text); // "" arasına yazan değişkenleri procedure ü oluştururken yazmıştık. Buradaki olay bu değişken üzerinden parametre taşımak
            cmd.Parameters.AddWithValue("@toplamtutar", txtTeoplamTutar.Text);
            cmd.Parameters.AddWithValue("@miktar", txtMiktari.Text);
            SqlParameter prm = new SqlParameter("@fiyat", SqlDbType.Money); // money tipinde olduğu için fiyat kısmını bu şekilde yapıyoruz
            prm.Value = txtFiyati.Text;
            cmd.Parameters.Add(prm);
            sql.Open();
            int etkilenen = cmd.ExecuteNonQuery();
            sql.Close();
            if (etkilenen > 0)
            {
                MessageBox.Show("Kayıt girildi"); listviewdoldur();

            }
            else
            {
                MessageBox.Show("Ürün Eklenmedi!!!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listviewdoldur(); //form açılır açılmaz listviewi dolduryoruz
        }

        private void listviewdoldur()
        {
            listView1.Items.Clear(); //listview metod içeriği
            SqlCommand cmd = new SqlCommand("select UrunID, UrunAdi, Miktar, Fiyat, ToplamTutar FROM urunler", sql); //tabloyu ve gerekli kolonları çaığırıyoruz
            sql.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem li = new ListViewItem(); // listview içini dolduruyoruz
                li.Text = rdr[0].ToString();
                li.SubItems.Add(rdr[1].ToString());
                li.SubItems.Add(rdr[2].ToString());
                li.SubItems.Add(rdr[3].ToString());
                li.SubItems.Add(rdr[4].ToString());
                listView1.Items.Add(li);
            }
            sql.Close();
        }

        private IProductRepository _productRepository;


        private void frmUrunList_Load(object sender, EventArgs e)
        {
            cmbUrunAdi.DisplayMember = "ProductName";
            cmbUrunAdi.ValueMember = "ProductId";
            cmbUrunAdi.DataSource = _productRepository.ListOf().TransactionResult;

        }

        private void cmbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

