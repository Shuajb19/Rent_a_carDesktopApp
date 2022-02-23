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
using Dapper;
using System.Data.SqlClient;
using CarRentalLibrary.DAL;

namespace DemoCarRent
{
    public partial class frmLogin : Form
    {
        

        public frmLogin()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(Conn.GetConnectionString());

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string query = "Select * from dbo.Users Where Email = '" + txtEmail.Text + "' and Password = '" + txtPassword.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Email or Password are incorrent");
            }

            

            
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "INSERT into dbo.Users (Emri, Mbiemri, Email, Password) Values('" + txtName.Text + "', '" + txtMbiemri.Text + "', '" + txtEmaili.Text + "', '" + txtPasswordi.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("U regjistruat me sukses");
                con.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
            }
            
            
        }
    }
}
