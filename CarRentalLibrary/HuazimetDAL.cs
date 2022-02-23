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
    public class HuazimetDAL
    {
        public DataTable getAllHuazimet()
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.da = new SqlDataAdapter("usp_showAllHuazimet", Conn.conn);
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

        public bool insertHuazimet(HuazimetBO huazimetBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_insertHuazimet", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Vetura_Id", huazimetBO.Vetura_Id);
                    cmd.Parameters.AddWithValue("@Regjistrimi_Vetures", huazimetBO.Regjistrimi_Vetures);
                    cmd.Parameters.AddWithValue("@Klienti_Id", huazimetBO.Klienti_Id);
                    cmd.Parameters.AddWithValue("@Emri_Klientit", huazimetBO.Emri_Klientit);
                    cmd.Parameters.AddWithValue("@Data_Huazimit", huazimetBO.Data_Huazimit);
                    cmd.Parameters.AddWithValue("@Cmimi", huazimetBO.Cmimi);

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

        public bool updateHuazimet(HuazimetBO huazimetBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_updateHuazimet", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Rental_Id", huazimetBO.Rental_Id);
                    cmd.Parameters.AddWithValue("@Vetura_Id", huazimetBO.Vetura_Id);
                    cmd.Parameters.AddWithValue("@Regjistrimi_Vetures", huazimetBO.Regjistrimi_Vetures);
                    cmd.Parameters.AddWithValue("@Klienti_Id", huazimetBO.Klienti_Id);
                    cmd.Parameters.AddWithValue("@Emri_Klientit", huazimetBO.Emri_Klientit);
                    cmd.Parameters.AddWithValue("@Data_Huazimit", huazimetBO.Data_Huazimit);
                    cmd.Parameters.AddWithValue("@Cmimi", huazimetBO.Cmimi);

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



        public bool deleteHuazimet(HuazimetBO huazimetBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_deleteHuazimet", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Rental_Id", huazimetBO.Rental_Id);

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
