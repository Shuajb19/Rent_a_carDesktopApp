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
using Rent_a_carBO;
using Rent;

namespace DemoCarRent
{
    
    public partial class frmHuazimet : Form
    {
        public static DataTable lista;
        HuazimetBO huazimetBO;
        HuazimetBLL huazimetBLL;
        

        public frmHuazimet()
        {
            InitializeComponent();
        }

        int selectedRow;
        SqlConnection con = new SqlConnection(Conn.GetConnectionString());

        private void fillComboBoxVetura()
        {
            using (SqlConnection con = new SqlConnection(Conn.GetConnectionString()))
            {
                con.Open();
                string query = "select Regjistrimi from Veturat";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Regjistrimi", typeof(string));
                dt.Load(rdr);
                cbRegjistrimi.ValueMember = "Regjistrimi";
                cbRegjistrimi.DataSource = dt;
                con.Close();
            }
        }
        
        private void fillComboBoxKlienti()
        {
            using (SqlConnection con = new SqlConnection(Conn.GetConnectionString()))
            {
                con.Open();
                string query = "select Emri from Klientat";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Emri", typeof(string));
                dt.Load(rdr);
                cbEmri_Klientit.ValueMember = "Emri";
                cbEmri_Klientit.DataSource = dt;
                con.Close();
            }
        }

        private void RegjistrimiVetures()
        {
            using (SqlConnection con = new SqlConnection(Conn.GetConnectionString()))
            {
                con.Open();
                string query = "select * from Veturat where Regjistrimi = '" + cbRegjistrimi.SelectedValue +"' ";
                SqlCommand cmd = new SqlCommand(query, con);              
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);     
                da.Fill(dt); 
                foreach (DataRow dr in dt.Rows)
                {
                    txtVetura_Id.Text = dr["Vetura_Id"].ToString();
                    txtPagesa.Text = dr["Cmimi_Per_Day"].ToString();
                }   
                con.Close();
            }
        }

        private void cbRegjistrimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegjistrimiVetures();
        }

        private void emriKlientit()
        {
            using (SqlConnection con = new SqlConnection(Conn.GetConnectionString()))
            {
                con.Open();
                string query = "select * from Klientat where Emri = '" + cbEmri_Klientit.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(query, con);               
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);             
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtKlienti_Id.Text = dr["Klienti_ID"].ToString();
                }              
                con.Close();
            }
        }

        private void cbEmri_Klientit_SelectedIndexChanged(object sender, EventArgs e)
        {
            emriKlientit();
        }

        private void RentalUpdate()
        {
            try
            {

                con.Open();
                string query = "UPDATE Veturat set Disponueshmeria = '" + 0 + "' where Vetura_Id = '" + txtVetura_Id.Text + "'";
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

        public void PopulateHuazimet()
        {
            HuazimetBLL huazimet = new HuazimetBLL();
            lista = huazimet.ShowAllHuazimet();
            dgvHuazimet.DataSource = lista;
        }

        private void frmHuazimet_Load(object sender, EventArgs e)
        {
            
            PopulateHuazimet();
            fillComboBoxVetura();
            RegjistrimiVetures();
            fillComboBoxKlienti();
            emriKlientit();


        }

        public HuazimetBO InsertHuazimet()
        {
            huazimetBO = new HuazimetBO(int.Parse(txtVetura_Id.Text), cbRegjistrimi.SelectedValue.ToString(), int.Parse(txtKlienti_Id.Text), cbEmri_Klientit.SelectedValue.ToString(), dtpData_Huazimit.Value, int.Parse(txtPagesa.Text));
            return huazimetBO;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtpData_Huazimit.Text == "" || txtPagesa.Text == "")
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
                        huazimetBLL = new HuazimetBLL();

                        bool inserted = huazimetBLL.insertHuazimet(InsertHuazimet());

                        if (inserted)
                        {
                            MessageBox.Show("Vetura u huazua me sukses");
                            RentalUpdate();
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


        public HuazimetBO UpdateHuazimet()
        {
            huazimetBO = new HuazimetBO(int.Parse(txtHuazimi_Id.Text), int.Parse(txtVetura_Id.Text), cbRegjistrimi.SelectedValue.ToString(), int.Parse(txtKlienti_Id.Text), cbEmri_Klientit.SelectedValue.ToString(), dtpData_Huazimit.Value, int.Parse(txtPagesa.Text));
            return huazimetBO;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtHuazimi_Id.Text == "")
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
                        huazimetBLL = new HuazimetBLL();

                        bool updated = huazimetBLL.updateHuazimet(UpdateHuazimet());
                        if (updated)
                        {
                            MessageBox.Show("Huazimi u perditesua me sukses");
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

        public HuazimetBO DeleteHuazimet()
        {
            huazimetBO = new HuazimetBO(int.Parse(txtHuazimi_Id.Text));
            return huazimetBO;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Jeni te sigurte!", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    huazimetBLL = new HuazimetBLL();
                    bool deleted = huazimetBLL.deleteHuazimet(DeleteHuazimet());
                    if (deleted)
                    {
                        MessageBox.Show("Huazimi u fshie me sukses");
                        PopulateHuazimet();
                        RentalOnDeleteUpdate();
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

        private void cbKlient_Id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //emriKlientit();
        }

        
        private void dgvHuazimet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgvHuazimet.Rows[selectedRow];
            txtHuazimi_Id.Text = row.Cells[0].Value.ToString();
            txtVetura_Id.Text = row.Cells[1].Value.ToString();
            cbRegjistrimi.SelectedValue = row.Cells[2].Value.ToString();
            txtKlienti_Id.Text = row.Cells[3].Value.ToString();
            cbEmri_Klientit.SelectedValue = row.Cells[4].Value.ToString();
            dtpData_Huazimit.Text = row.Cells[5].Value.ToString();
            txtPagesa.Text = row.Cells[6].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void FshijTeDhenat()
        {
            txtHuazimi_Id.Text = "";
            txtVetura_Id.Text = "";
            txtKlienti_Id.Text = "";
            cbEmri_Klientit.SelectedValue = "0";
            cbRegjistrimi.SelectedValue = "0";
            txtPagesa.Text = "";
            dtpData_Huazimit.Value = DateTime.Now;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FshijTeDhenat();
        }
    }
}
