using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalLibrary.DAL;
using System.Data.SqlClient;
using Rent;
using Rent_a_carBO;

namespace DemoCarRent
{
    public partial class frmKthimet : Form
    {
        public static DataTable listaHuazimet;
        public static DataTable listaKthimet;
        KthimetBO kthimetBO;
        KthimetBLL kthimetBLL;

        public frmKthimet()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Conn.GetConnectionString());
        int selectedRow;

        public void PopulateHuazimet()
        {
            HuazimetBLL huazimet = new HuazimetBLL();
            listaHuazimet = huazimet.ShowAllHuazimet();
            dgvHuazimet.DataSource = listaHuazimet;
        }
        public void PopulateKthimet()
        {
            KthimetBLL kthimet = new KthimetBLL();
            listaKthimet = kthimet.ShowAllKthimet();
            dgvKthimet.DataSource = listaKthimet;
        }
        private void frmKthimet_Load(object sender, EventArgs e)
        {
            PopulateHuazimet();
            PopulateKthimet();
        }

        private void RentalOnDeleteUpdate()
        {
            try
            {

                con.Open();
                string query = "UPDATE Veturat set Disponueshmeria = '" + 1 + "' where Vetura_Id = '" + txtVetura_Id.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error:";
                msg += ex.Message;
            }
        }

        private void ReturnUpdate()
        {
            try
            {

                con.Open();
                string query = "UPDATE Rental set I_Kthyer = '" + 1 + "' where Vetura_Id = '"+ txtVetura_Id.Text +"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Update Error:";
                msg += ex.Message;
            }
        }

        public KthimetBO InsertKthimet()
        {
            kthimetBO = new KthimetBO(int.Parse(txtVetura_Id.Text), int.Parse(txtKlienti_Id.Text), txtEmriKlientit.Text, dtpData_Dorezimit.Value, int.Parse(lblDitetE_Shfrytezimit_Rezultati.Text), int.Parse(lblCmimiTotal_Rezultati.Text));
            return kthimetBO;
        }

        public HuazimetBO DeleteHuazimet()
        {
            HuazimetBO huazimetBO = new HuazimetBO(int.Parse(txtRent_Id.Text));
            return huazimetBO;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVetura_Id.Text == "" || txtEmriKlientit.Text == "" || dtpData_Dorezimit.Text == "")
            {
                MessageBox.Show("Te dhenat mungojne");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Jeni te sigurte!", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        kthimetBLL = new KthimetBLL();
                        HuazimetBLL huazimetBLL = new HuazimetBLL();

                        bool inserted = kthimetBLL.insertKthimet(InsertKthimet());

                        if (inserted)
                        {
                            MessageBox.Show("Vetura u shtua ne listen e kthimit me sukses");
                            RentalOnDeleteUpdate();
                            ReturnUpdate();
                            PopulateKthimet();
                            
                            huazimetBLL.deleteHuazimet(DeleteHuazimet());
                            PopulateHuazimet();
                        }
                        else
                        {
                            MessageBox.Show("Oooppss, diqka shkoi gabim");
                        }
                        FshijTeDhenat();
                    }


                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string msg = "Insert Error:";
                    msg += ex.Message;
                }
            }
        }

        public KthimetBO UpdateKthimet()
        {
            kthimetBO = new KthimetBO(int.Parse(txtReturn_Id.Text), int.Parse(txtVetura_Id.Text), int.Parse(txtKlienti_Id.Text), txtEmriKlientit.Text, dtpData_Dorezimit.Value, int.Parse(lblDitetE_Shfrytezimit_Rezultati.Text), int.Parse(lblCmimiTotal_Rezultati.Text));
            return kthimetBO;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtReturn_Id.Text == "")
            {
                MessageBox.Show("Te dhenat mungojne");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Jeni te sigurte!", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        kthimetBLL = new KthimetBLL();

                        bool updated = kthimetBLL.updateKthimet(UpdateKthimet());
                        if (updated)
                        {
                            MessageBox.Show("Kthimi u perditesua me sukses");
                            PopulateHuazimet();
                        }
                        else
                        {
                            MessageBox.Show("Ooopss diqka shkoi gabim");
                        }

                        FshijTeDhenat();
                    }

                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string msg = "Update Error:";
                    msg += ex.Message;
                }
            }
        }

        public KthimetBO DeleteKthimet()
        {
            kthimetBO = new KthimetBO(int.Parse(txtReturn_Id.Text));
            return kthimetBO;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Jeni te sigurte!", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kthimetBLL = new KthimetBLL();
                    bool deleted = kthimetBLL.deleteKthimet(DeleteKthimet());
                    if (deleted)
                    {
                        MessageBox.Show("Vetura e kthyer u fshie me sukses");
                        PopulateKthimet();
                        RentalOnDeleteUpdate();
                        FshijTeDhenat();
                    }
                    else
                    {
                        MessageBox.Show("Ooopss diqka shkoi gabim");
                    }  
                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Delete Error:";
                msg += ex.Message;
            }
        }

        private void FshijTeDhenat()
        {
            txtReturn_Id.Text = "";
            txtRent_Id.Text = "";
            txtVetura_Id.Text = "";
            txtKlienti_Id.Text = "";
            txtEmriKlientit.Text = "";
            dtpData_Huazimit.Text = "";
            dtpData_Dorezimit.Text = "";
            lblCmimiTotal_Rezultati.Text = "0";
            lblCmimiVetures_Rezultati.Text = "0";
            lblDitetE_Shfrytezimit_Rezultati.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void dgvHuazimet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgvHuazimet.Rows[selectedRow];
            txtRent_Id.Text = row.Cells[0].Value.ToString();
            txtVetura_Id.Text = row.Cells[1].Value.ToString();
            txtKlienti_Id.Text = row.Cells[3].Value.ToString();
            txtEmriKlientit.Text = row.Cells[4].Value.ToString();
            dtpData_Huazimit.Text = row.Cells[5].Value.ToString();
            lblCmimiVetures_Rezultati.Text = row.Cells[6].Value.ToString();
            lblDitetE_Shfrytezimit_Rezultati.Text = "0";
            txtReturn_Id.Text = "";
        }

        private void dgvKthimet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgvKthimet.Rows[selectedRow];
            txtReturn_Id.Text = row.Cells[0].Value.ToString();
            txtVetura_Id.Text = row.Cells[1].Value.ToString();
            txtKlienti_Id.Text = row.Cells[2].Value.ToString();
            txtEmriKlientit.Text = row.Cells[3].Value.ToString();
            dtpData_Dorezimit.Text = row.Cells[4].Value.ToString();
            lblCmimiVetures_Rezultati.Text = "0";
            lblDitetE_Shfrytezimit_Rezultati.Text = row.Cells[5].Value.ToString();
            lblCmimiTotal_Rezultati.Text = row.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = dtpData_Huazimit.Value.Date;
            DateTime d2 = dtpData_Dorezimit.Value.Date;
            TimeSpan t = d2 - d1;
            int nr_i_diteve_te_shfrytezuara = Convert.ToInt32(t.TotalDays);
            string cmimi = lblCmimiVetures_Rezultati.Text;
            int cmimiTotal = nr_i_diteve_te_shfrytezuara * Convert.ToInt32(cmimi);
            if (nr_i_diteve_te_shfrytezuara <= 0)
            {
                lblDitetE_Shfrytezimit_Rezultati.Text = "0";

            }
            else
            {
                lblDitetE_Shfrytezimit_Rezultati.Text = "" + nr_i_diteve_te_shfrytezuara;
                lblCmimiTotal_Rezultati.Text = "" + cmimiTotal;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FshijTeDhenat();
        }
    }
}
