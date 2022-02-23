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
    public class KthimetDAL
    {
        public DataTable getAllKthimet()
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.da = new SqlDataAdapter("usp_showAllKthimet", Conn.conn);
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

        public bool insertKthimet(KthimetBO kthimetBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_insertKthimet", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Vetura_Id", kthimetBO.Vetura_Id);
                    cmd.Parameters.AddWithValue("@Klienti_Id", kthimetBO.Klienti_Id);
                    cmd.Parameters.AddWithValue("@Emri_Klientit", kthimetBO.Emri_Klientit);
                    cmd.Parameters.AddWithValue("@Data_Dorezimit", kthimetBO.Data_Dorezimit);
                    cmd.Parameters.AddWithValue("@Ditet_e_shfrytezimit", kthimetBO.Ditet_e_shfrytezimit);
                    cmd.Parameters.AddWithValue("@Cmimi_Total", kthimetBO.Cmimi_Total);

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

        public bool updateKthimet(KthimetBO kthimetBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_updateKthimet", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Rental_Id", kthimetBO.Return_Id);
                    cmd.Parameters.AddWithValue("@Vetura_Id", kthimetBO.Vetura_Id);
                    cmd.Parameters.AddWithValue("@Klienti_Id", kthimetBO.Klienti_Id);
                    cmd.Parameters.AddWithValue("@Emri_Klientit", kthimetBO.Emri_Klientit);
                    cmd.Parameters.AddWithValue("@Data_Dorezimit", kthimetBO.Data_Dorezimit);
                    cmd.Parameters.AddWithValue("@Ditet_e_shfrytezimit", kthimetBO.Ditet_e_shfrytezimit);
                    cmd.Parameters.AddWithValue("@Cmimi_Total", kthimetBO.Cmimi_Total);

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



        public bool deleteKthimet(KthimetBO kthimetBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_deleteKthimet", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Return_Id", kthimetBO.Return_Id);

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
