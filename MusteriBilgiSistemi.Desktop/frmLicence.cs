using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Desktop.LicenceService;
using MusteriBilgiSistemi.Orm;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmLicence : Form
    {
        public frmLicence()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Service1SoapClient sc = new Service1SoapClient();
            AuthHeader kimlik = new AuthHeader();
            kimlik.Login = "Admin";
            kimlik.Pwd = "123456";

            LicencePack lp = new LicencePack();
            lp.ProductKey = Guid.Parse(txtLicenceKey.Text);
            lp.MacList = Tools.GetMacList().ToArray();
            lp.HddNo = Tools.GetHddNo();
            int sonuc = sc.RegisterLicence(kimlik, lp);

            if (sonuc == 0)
            {
                this.DialogResult = DialogResult.Ignore;
            }
            else if (sonuc == 1)
            {
                LcDbDataContext db = new LcDbDataContext();
                Licence l = new Licence();
                l.ProductKey = Guid.Parse(txtLicenceKey.Text);
                db.Licences.InsertOnSubmit(l);
                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
