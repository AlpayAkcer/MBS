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
    public partial class frmMusteriListesi : Form
    {
        private IMusteriRepository _musteriRepository;

        public frmMusteriListesi()
        {
            _musteriRepository = new MusteriRepository();
            InitializeComponent();
        }

        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            grdMusteriList.DataSource = _musteriRepository.ListOf().TransactionResult;
            }
    }
}
