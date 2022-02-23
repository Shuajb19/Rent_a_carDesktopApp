using CarRentalLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Rent_a_carBO;

namespace Rent_a_carDAL
{
    public class KlientatDAL
    {
        public DataTable getAllKlientat()
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.da = new SqlDataAdapter("usp_showAllKlientat", Conn.conn);
                    DataTable dTable = new DataTable();
                    Conn.da.Fill(dTable);
                    return dTable;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool insertKlientat(KlientatBO klientatBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_insertKlientat", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Emri", klientatBO.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", klientatBO.Mbiemri);
                    cmd.Parameters.AddWithValue("@Email", klientatBO.Email);
                    cmd.Parameters.AddWithValue("@Tel", klientatBO.Tel);
                    cmd.Parameters.AddWithValue("@Qyteti", klientatBO.Qyteti);

                    cmd.ExecuteNonQuery();

                    Conn.conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool updateKlientat(KlientatBO klientatBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_updateKlientat", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Klienti_ID", klientatBO.Klienti_ID);
                    cmd.Parameters.AddWithValue("@Emri", klientatBO.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", klientatBO.Mbiemri);
                    cmd.Parameters.AddWithValue("@Email", klientatBO.Email);
                    cmd.Parameters.AddWithValue("@Tel", klientatBO.Tel);
                    cmd.Parameters.AddWithValue("@Qyteti", klientatBO.Qyteti);

                    cmd.ExecuteNonQuery();

                    Conn.conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }



        public bool deleteKlientat(KlientatBO klientatBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_deleteKlientat", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Klienti_ID", klientatBO.Klienti_ID);

                    cmd.ExecuteNonQuery();

                    Conn.conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
