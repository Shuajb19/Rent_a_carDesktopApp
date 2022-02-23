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
    public class HuazimetBLL
    {
        HuazimetDAL huazimetDAL;

        public HuazimetBLL()
        {
            huazimetDAL = new HuazimetDAL();
        }


        public DataTable ShowAllHuazimet()
        {
            return huazimetDAL.getAllHuazimet();
        }

        public bool insertHuazimet(HuazimetBO huazimetBO)
        {
            return huazimetDAL.insertHuazimet(huazimetBO);
        }

        public bool updateHuazimet(HuazimetBO huazimetBO)
        {
            return huazimetDAL.updateHuazimet(huazimetBO);
        }

        public bool deleteHuazimet(HuazimetBO huazimetBO)
        {
            return huazimetDAL.deleteHuazimet(huazimetBO);
        }
    }
}
