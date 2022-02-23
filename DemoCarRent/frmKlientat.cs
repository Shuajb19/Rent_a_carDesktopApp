using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarRentalLibrary.DAL;
using Rent_a_carBO;
using Rent;

namespace DemoCarRent
{
    public partial class frmKlientat : Form
    {

        public static DataTable lista;
        KlientatBO klientatBO;
        KlientatBLL klientatBLL;
        public frmKlientat()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Conn.GetConnectionString());
        int selectedRow;


        public void PopulateKlientat()
        {
            KlientatBLL klientat = new KlientatBLL();
            lista = klientat.ShowAllKlientat();
            dgvKlientat.DataSource = lista;
        }
        private void Klientat_Load(object sender, EventArgs e)
        {
            PopulateKlientat();
        }

        public KlientatBO InsertKlientat()
        {
            klientatBO = new KlientatBO(txtEmri.Text, txtMbiemri.Text, txtEmail.Text, int.Parse(txtTelefoni.Text), txtQyteti.Text);
            return klientatBO;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmail.Text == "" || txtTelefoni.Text == "" || txtQyteti.Text == "")
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
                        klientatBLL = new KlientatBLL();

                        bool inserted = klientatBLL.insertKlientat(InsertKlientat());
                        if (inserted)
                        {
                            MessageBox.Show("Klienti u regjistrua me sukses");
                            PopulateKlientat();
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
                    string msg = "Insert Error:";
                    msg += ex.Message;
                }
            }
        }

        public KlientatBO UpdateKlientat()
        {
            klientatBO = new KlientatBO(int.Parse(txtKlient_Id.Text), txtEmri.Text, txtMbiemri.Text, txtEmail.Text, int.Parse(txtTelefoni.Text), txtQyteti.Text);
            return klientatBO;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtKlient_Id.Text == "")
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
                        klientatBLL = new KlientatBLL();

                        bool updated = klientatBLL.updateKlientat(UpdateKlientat());
                        if (updated)
                        {
                            MessageBox.Show("Klienti u perditesua me sukses");
                            PopulateKlientat();
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

        public KlientatBO DeleteKlientat()
        {
            klientatBO = new KlientatBO(int.Parse(txtKlient_Id.Text));
            return klientatBO;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Jeni te sigurte!", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    klientatBLL = new KlientatBLL();
                    bool deleted = klientatBLL.deleteKlientat(DeleteKlientat());
                    if (deleted)
                    {
                        MessageBox.Show("Klienti u fshie me sukses");
                        PopulateKlientat();
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
                string msg = "Delete Error:";
                msg += ex.Message;
            }
        }

        private void FshijTeDhenat()
        {
            txtKlient_Id.Text = "";
            txtEmri.Text = "";
            txtMbiemri.Text = "";
            txtEmail.Text = "";
            txtTelefoni.Text = "";
            txtQyteti.Text = "";           
        }

        private void dgvKlientat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgvKlientat.Rows[selectedRow];
            txtKlient_Id.Text = row.Cells[0].Value.ToString();
            txtEmri.Text = row.Cells[1].Value.ToString();
            txtMbiemri.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
            txtTelefoni.Text = row.Cells[4].Value.ToString();
            txtQyteti.Text = row.Cells[5].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FshijTeDhenat();
        }
    }
}
