using Rent_a_carBO;
using Rent_a_carDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    public class KlientatBLL
    {
        KlientatDAL klientatDAL;

        public KlientatBLL()
        {
            klientatDAL = new KlientatDAL();
        }


        public DataTable ShowAllKlientat()
        {
            return klientatDAL.getAllKlientat();
        }

        public bool insertKlientat(KlientatBO klientatBO)
        {
            return klientatDAL.insertKlientat(klientatBO);
        }

        public bool updateKlientat(KlientatBO klientatBO)
        {
            return klientatDAL.updateKlientat(klientatBO);
        }

        public bool deleteKlientat(KlientatBO klientatBO)
        {
            return klientatDAL.deleteKlientat(klientatBO);
        }
    }
}
