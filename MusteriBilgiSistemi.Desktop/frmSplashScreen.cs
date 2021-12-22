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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private frmLogin _log;
        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                if (_log == null || _log.IsDisposed)
                {
                    _log = new frmLogin();
                    _log.Show();
                }
                else{
                    _log.BringToFront();
                    _log.Show();
                }
                this.Hide();
            }
        }
    }
}