using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_a_carDAL;
using Rent_a_carBO;

namespace Rent_a_carBLL
{
    public class VeturatBLL
    {
        VeturatDAL veturatDAL;

        public VeturatBLL()
        {
            veturatDAL = new VeturatDAL();
        }


        public DataTable ShowAllVeturat()
        {
            return veturatDAL.getAllVeturat();
        }

        public bool insertVeturat(VeturatBO veturatBO)
        {
            return veturatDAL.insertVeturat(veturatBO);
        }

        public bool updateVeturat(VeturatBO veturatBO)
        {
            return veturatDAL.updateVeturat(veturatBO);
        }

        public bool deleteVeturat(VeturatBO veturatBO)
        {
            return veturatDAL.deleteVeturat(veturatBO);
        }
    }
}
