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
    public class VeturatDAL
    {
        public DataTable getAllVeturat() 
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.da = new SqlDataAdapter("usp_showAllVeturat", Conn.conn);
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

        public bool insertVeturat(VeturatBO veturatBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_insertVeturat", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Lloji", veturatBO.Lloji);
                    cmd.Parameters.AddWithValue("@Modeli", veturatBO.Modeli);
                    cmd.Parameters.AddWithValue("@Regjistrimi", veturatBO.Regjistrimi);
                    cmd.Parameters.AddWithValue("@Viti_Prodhimit", veturatBO.Viti_Prodhimit);
                    cmd.Parameters.AddWithValue("@Kilometrazha", veturatBO.Kilometrazha);
                    cmd.Parameters.AddWithValue("@Disponueshmeria", veturatBO.Disponueshmeria);
                    cmd.Parameters.AddWithValue("@Cmimi_Per_Day", veturatBO.Cmimi_Per_Day);

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

        public bool updateVeturat(VeturatBO veturatBO)
        {
            try
            {
                using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                {
                    Conn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_updateVeturat", Conn.conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Vetura_Id", veturatBO.Vetura_Id);
                    cmd.Parameters.AddWithValue("@Lloji", veturatBO.Lloji);
                    cmd.Parameters.AddWithValue("@Modeli", veturatBO.Modeli);
                    cmd.Parameters.AddWithValue("@Regjistrimi", veturatBO.Regjistrimi);
                    cmd.Parameters.AddWithValue("@Viti_Prodhimit", veturatBO.Viti_Prodhimit);
                    cmd.Parameters.AddWithValue("@Kilometrazha", veturatBO.Kilometrazha);
                    cmd.Parameters.AddWithValue("@Disponueshmeria", veturatBO.Disponueshmeria);
                    cmd.Parameters.AddWithValue("@Cmimi_Per_Day", veturatBO.Cmimi_Per_Day);

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



            public bool deleteVeturat(VeturatBO veturatBO)
            {
                try
                {
                    using (Conn.conn = new SqlConnection(Conn.GetConnectionString()))
                    {
                        Conn.conn.Open();
                        SqlCommand cmd = new SqlCommand("usp_deleteVeturat", Conn.conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Vetura_Id", veturatBO.Vetura_Id);

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
