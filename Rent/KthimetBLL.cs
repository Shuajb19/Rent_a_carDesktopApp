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
    public class KthimetBLL
    {
        KthimetDAL kthimetDAL;

        public KthimetBLL()
        {
            kthimetDAL = new KthimetDAL();
        }


        public DataTable ShowAllKthimet()
        {
            return kthimetDAL.getAllKthimet();
        }

        public bool insertKthimet(KthimetBO kthimetBO)
        {
            return kthimetDAL.insertKthimet(kthimetBO);
        }

        public bool updateKthimet(KthimetBO kthimetBO)
        {
            return kthimetDAL.updateKthimet(kthimetBO);
        }

        public bool deleteKthimet(KthimetBO kthimetBO)
        {
            return kthimetDAL.deleteKthimet(kthimetBO);
        }
    }
}
