using System;
using System.Linq;
using System.Windows.Forms;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Desktop.LicenceService;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private frmMusteri frmmusteriForm = new frmMusteri();
        private void btnMusteriAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (frmmusteriForm != null || frmmusteriForm.IsDisposed)
                {

                    frmmusteriForm = new frmMusteri();
                    frmmusteriForm.MdiParent = this;
                    frmmusteriForm.BringToFront();
                    frmmusteriForm.Show();
                }
                else
                {
                    frmmusteriForm.MdiParent = this;
                    frmmusteriForm.BringToFront();
                    frmmusteriForm.Show();

                }
            }
            catch (Exception)
            {
                frmmusteriForm = new frmMusteri();
                frmmusteriForm.MdiParent = this;
                frmmusteriForm.BringToFront();
                frmmusteriForm.Show();
            }

        }

        frmMusteriListesi _musteriListesi = new frmMusteriListesi();
        private void btnMusteriList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_musteriListesi == null || _musteriListesi.IsDisposed)
            {
                _musteriListesi = new frmMusteriListesi();
                _musteriListesi.MdiParent = this;
                _musteriListesi.Show();
            }
            else
            {
                _musteriListesi.MdiParent = this;
                _musteriListesi.BringToFront();
                _musteriListesi.Show();
            }

        }

        frmProducts _pro = new frmProducts();
        private void btnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_pro == null || _pro.IsDisposed)
            {
                _pro = new frmProducts();
                _pro.MdiParent = this;
                _pro.Show();
            }
            else
            {
                _pro.MdiParent = this;
                _pro.BringToFront(); _pro.Show();
            }


        }

        private frmMusteri _frmMusteri;
        private void frmMain_Load(object sender, EventArgs e)
        {
            using (LicenceService.Service1SoapClient sc = new Service1SoapClient())
            {
                LcDbDataContext db = new LcDbDataContext();
                var lisans = (Licence)(db.Licences.ToList()).FirstOrDefault();
                //Licence lcn = (Licence)(db.Licences.ToList()).Take(1);
                if (lisans != null)
                {
                    LicencePack lp = new LicencePack();
                    lp.ProductKey = lisans.ProductKey;
                    lp.HddNo = Tools.GetHddNo();
                    lp.MacList = Tools.GetMacList().ToArray();
                    AuthHeader kimlik = new AuthHeader();
                    kimlik.Login = "Admin";
                    kimlik.Pwd = "123456";
                    int sonuc = sc.CheckLicence(kimlik, lp);
                    if (sonuc == 4)
                    {
                        MessageBox.Show("Programınız yönetici tarafından kilitlenmiştir.");
                        Environment.Exit(1);
                    }
                    else if (sonuc == 2)
                    {
                        MessageBox.Show("Kullandığınız Key Bir başkasına ait veya HATALI...!!");
                        Environment.Exit(1);
                    }
                    else if (sonuc == 3)
                    {
                        frmLicence frm = new frmLicence();
                        DialogResult s = frm.ShowDialog();
                        if (s == DialogResult.Cancel)
                        {
                            //Demo sürümü gibi kullanıp menulerin görünümünü kapatma

                            //foreach (RibbonControl item in ribbonControl1.Items)
                            //{
                            //    item.Enabled = false;
                            //}
                            Environment.Exit(1);
                        }
                    }
                    else if (sonuc == 0)
                    {
                        Environment.Exit(1);
                    }
                }
                else
                {
                    frmLicence frm = new frmLicence();
                    DialogResult s = frm.ShowDialog();
                    if (s == DialogResult.Cancel)
                    {
                        //Demo sürümü gibi kullanıp menulerin görünümünü kapatma

                        //foreach (RibbonControl item in ribbonControl1.Items)
                        //{
                        //    item.Enabled = false;
                        //}
                        Environment.Exit(1);
                    }
                }
            }
        }

        private frmCategory _category;
        private void btnKategoriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (_category == null || _category.IsDisposed)
            {
                _category = new frmCategory();
                _category.MdiParent = this;
                _category.Show();
            }
            else
            {
                _category.MdiParent = this;
                _category.BringToFront();
                _category.Show();
            }
        }

        private frmPersonelList _frmPersonel;
        private void btnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_frmPersonel == null || _frmPersonel.IsDisposed)
            {
                _frmPersonel = new frmPersonelList();
                _frmPersonel.MdiParent = this;
                _frmPersonel.Show();
            }
            else
            {
                _frmPersonel.MdiParent = this;
                _frmPersonel.BringToFront();
                _frmPersonel.Show();
            }
        }

        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult x = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Pencere Mesajı..", MessageBoxButtons.YesNo);
            if (x == DialogResult.No)
            {
                //e.Cancel = true;
            }
            else
            {
                Application.Exit();

            }
        }

        private frmAbout _about;
        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_about == null || _about.IsDisposed)
            {
                _about = new frmAbout();
                _about.BringToFront();
                _about.Show();
            }
            else
            {

                _about.BringToFront();
                _about.Show();
            }
        }
        private frmUrunList _frmUrunList;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (_frmUrunList == null || _frmUrunList.IsDisposed)
            {
                _frmUrunList = new frmUrunList();
                _frmUrunList.BringToFront();
                _frmUrunList.Show();
            }
            else
            {
                _frmUrunList.MdiParent = this;
                _frmUrunList.BringToFront();
                _frmUrunList.Show();
            }
        }
    }
}