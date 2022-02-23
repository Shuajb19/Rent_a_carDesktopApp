using System.Collections.Generic;
using System.Windows.Forms;
using CarRentalLibrary.DAL;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using Rent_a_carBLL;
using Rent_a_carBO;

namespace DemoCarRent
{
    public partial class frmVeturat : Form
    {
        public static DataTable lista;
        VeturatBO veturatBO;
        VeturatBLL veturatBLL;

        public frmVeturat()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Conn.GetConnectionString());
        int selectedRow;

        public void PopulateVeturat()
        {
            VeturatBLL veturat = new VeturatBLL();
            lista = veturat.ShowAllVeturat();
            dgvVeturat.DataSource = lista;
        }

        private void frmVeturat_Load(object sender, System.EventArgs e)
        {
            PopulateVeturat();
        }

        
        public VeturatBO InsertVeturat()
        {
            bool disponushem = false;
            if (chbDisponueshmeria.Checked)
            {
                disponushem = true;
            }
            else
            {
                disponushem = false;
            }
            veturatBO = new VeturatBO(txtLloji.Text, txtModeli.Text, txtRegjistrimi.Text, int.Parse(txtViti_Prodhimit.Text), int.Parse(txtKilometrazha.Text), disponushem, int.Parse(txtCmimi.Text));
            return veturatBO;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if(txtLloji.Text == "" || txtModeli.Text == "" || txtRegjistrimi.Text == "" || txtViti_Prodhimit.Text == "" || txtKilometrazha.Text == "" ||  txtCmimi.Text == "")
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
                        veturatBLL = new VeturatBLL();

                        bool inserted = veturatBLL.insertVeturat(InsertVeturat());
                        if (inserted)
                        {
                            MessageBox.Show("Veturat u regjistruan me sukses");
                            PopulateVeturat();
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


        public VeturatBO UpdateVeturat()
        {
            bool disponushem = false;
            if (chbDisponueshmeria.Checked)
            {
                disponushem = true;
            }
            else
            {
                disponushem = false;
            }
            veturatBO = new VeturatBO(int.Parse(txtVetura_Id.Text) ,txtLloji.Text, txtModeli.Text, txtRegjistrimi.Text, int.Parse(txtViti_Prodhimit.Text), int.Parse(txtKilometrazha.Text), disponushem, int.Parse(txtCmimi.Text));
            return veturatBO;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if(txtVetura_Id.Text == "")
            {
                MessageBox.Show("Te dhenat mungojne");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Jeni te sigurte!", "Confirmation", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        veturatBLL = new VeturatBLL();

                        bool updated = veturatBLL.updateVeturat(UpdateVeturat());
                        if (updated)
                        {
                            MessageBox.Show("Veturat u perditesua me sukses");
                            PopulateVeturat();
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


        public VeturatBO DeleteVeturat()
        {
            veturatBO = new VeturatBO(int.Parse(txtVetura_Id.Text));
            return veturatBO;
        }
        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Jeni te sigurte!", "Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    veturatBLL = new VeturatBLL();

                    bool deleted = veturatBLL.deleteVeturat(DeleteVeturat());
                    if (deleted)
                    {
                        MessageBox.Show("Vetura u fshie me sukses");
                        PopulateVeturat();
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

        private void dgvVeturat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgvVeturat.Rows[selectedRow];
            txtVetura_Id.Text = row.Cells[0].Value.ToString();
            txtLloji.Text = row.Cells[1].Value.ToString();
            txtModeli.Text = row.Cells[2].Value.ToString();
            txtRegjistrimi.Text = row.Cells[3].Value.ToString();
            txtViti_Prodhimit.Text = row.Cells[4].Value.ToString();
            txtKilometrazha.Text = row.Cells[5].Value.ToString();
            txtCmimi.Text = row.Cells[7].Value.ToString();
        }

        private void FshijTeDhenat()
        {
            txtVetura_Id.Text = "";
            txtLloji.Text = "";
            txtModeli.Text = "";
            txtRegjistrimi.Text = "";
            txtViti_Prodhimit.Text = "";
            txtKilometrazha.Text = "";
            chbDisponueshmeria.Checked = false;
            txtCmimi.Text = "";
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            FshijTeDhenat();
        }
    }
    
}
