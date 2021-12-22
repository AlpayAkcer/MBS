using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriBilgiSistemi.Orm;

namespace CreateLicenceKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                lstLicenceList.Items.Add(Guid.NewGuid());
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMail.Text))
            {
                lstMailList.Items.Add(txtMail.Text);
                txtMail.Text = "";
            }
            else
            {
                lblMailSonucuIletisi.Text = "Geçerli Mail adresi giriniz.!!";
            }

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Credentials = new System.Net.NetworkCredential("demo@alpayakcer.com", "123456");
                sc.Host = "mail.alpayakcer.com";
                sc.Port = 587;
                MailMessage msg = new MailMessage();
                foreach (string item in lstMailList.Items)
                {
                    msg.To.Add(item);
                }
                msg.From = new MailAddress("demo@alpayakcer.com", "Lisans Kodunuz");
                msg.Subject = " Yeni Lisans Kodu ";
                msg.IsBodyHtml = true;
                StringBuilder sb = new StringBuilder("<h2> Yeni Lisans Kodu </h2>");

                LicenceDbDataContext db = new LicenceDbDataContext();
                foreach (Guid item in lstLicenceList.Items)
                {
                    Licence l = new Licence();
                    l.ProductKey = item;
                    db.Licences.InsertOnSubmit(l);
                    db.SubmitChanges();
                    sb.Append("<br>");
                    sb.Append(item.ToString());
                    sb.Append("</br>");
                }
                lblEmailAdresi.Text = msg.To.ToString();
                lblMailSonucuIletisi.Text = "Lisans kodunuz mail adresinize gönderilmiştir.";
                sb.Append("/r" + "Programınızı iyi günlerde kullanın" + "/r" + DateTime.Now.ToShortDateString());
                msg.Body = sb.ToString();
                msg.Priority = MailPriority.High;
                sc.Send(msg);
            }
            catch (Exception ex)
            {
                string error = ex.Message + ex.HelpLink;
            }
            finally
            {
                txtMail.Text = "";
                lstMailList.Items.Clear();
                lstLicenceList.Items.Clear();
                lblMailSonucuIletisi.Text = "";
            }
        }

        private void btnSecilenitemizle_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstMailList);
            selectedItems = lstMailList.SelectedItems;

            if (lstMailList.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lstMailList.Items.Remove(selectedItems[i]);
                lblMailSonucuIletisi.Text = "";
            }
            else
                lblMailSonucuIletisi.Text = "Bir e-posta seçmelisiniz";
        }
    }
}