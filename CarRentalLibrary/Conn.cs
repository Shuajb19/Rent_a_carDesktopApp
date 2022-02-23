using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  

namespace CarRentalLibrary.DAL
{
    public static class Conn

    {
        public static string GetConnectionString()
        {

            return ConfigurationManager.ConnectionStrings["DemoCarRentConnectionString"].ConnectionString;

        }

        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
    }
}
