using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCarRent;
using System.Data.SqlClient;
using CarRentalLibrary.DAL;
using Rent_a_carBO;

namespace DemoCarRent
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        

        private void btnVeturat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVeturat veturat = new frmVeturat();
            veturat.Show();
        }

        

        private void btnKlientat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKlientat klientat = new frmKlientat();
            klientat.Show();
        }

        private void btnHuazimet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHuazimet huazimet = new frmHuazimet();
            huazimet.Show();
        }

        private void btnKthimet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKthimet kthimet = new frmKthimet();
            kthimet.Show();
        }

        private void btnAL_Click(object sender, EventArgs e)
        {
            var changeLang = new ChangeLanguage();
            changeLang.UpdateConfig("language", "sq");
            Application.Restart();
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            var changeLang = new ChangeLanguage();
            changeLang.UpdateConfig("language", "en");
            Application.Restart();
        }
    }
}
