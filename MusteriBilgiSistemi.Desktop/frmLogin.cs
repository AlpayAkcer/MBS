using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriBilgiSistemi.Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string kod;
        private frmMain _frm;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
            if (txtKullaniciAdi.Text.ToLower() == "admin" && txtPassword.Text == @"123456")
            {
                if (txtGuvenlik.Text == kod)
                {
                    lblSonuc.Text = @"Giriş Başarılı";
                    this.Hide();
                    if (_frm == null || _frm.IsDisposed)
                    {
                        _frm = new frmMain();
                        _frm.BringToFront();
                        _frm.Show();
                    }
                    else
                    {
                        _frm.BringToFront();
                        _frm.Show();
                    }
                }
                else
                {
                    lblSonuc.Text = @"Kodlar Uyuşmamaktadır!!";
                }
            }
            else
            {
                lblSonuc.Text = @"Lütfen doğru giriniz!!";
            }
        }

        private void btnRefleshCode_Click(object sender, EventArgs e)
        {
            SifreOlustur();
            txtGuvenlik.Text = lblSecurityCode.Text;
        }

        private void SifreOlustur()
        {
            kod = "";
            int harf, bykharf, hangisi;
            Random Rharf = new Random();
            Random Rsayi = new Random();
            Random Rbykharf = new Random();
            Random Rhangisi = new Random();


            for (int b = 0; b < 8; b++)
            {
                int a = 0;
                hangisi = Rhangisi.Next(1, 3);
                if (hangisi == 1)
                {
                    kod += Rsayi.Next(0, 10).ToString();
                }
                if (hangisi == 2)
                {
                    harf = Rharf.Next(1, 27);
                    for (char i = 'a'; i <= 'z'; i++)
                    {
                        a++;
                        if (a == harf)
                        {
                            bykharf = Rbykharf.Next(1, 3);
                            if (bykharf == 1)
                            {
                                kod += i;
                            }
                            if (bykharf == 2)
                            {
                                kod += i.ToString().ToUpper();
                            }
                        }
                    }
                }

            }
            lblSecurityCode.Text = kod;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            SifreOlustur();
            txtPassword.PasswordChar = '*';
            txtGuvenlik.Text = lblSecurityCode.Text;
        }

        private void btnPasswordGoster_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnPasswordGoster_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';

        }

    }
}