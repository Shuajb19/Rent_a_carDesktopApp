using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_carBO
{
    public class VeturatBO
    {
        public int Vetura_Id { get; set; }

        public string Lloji { get; set; }
        public string Modeli { get; set; }
        public string Regjistrimi { get; set; }
        public int Viti_Prodhimit { get; set; }
        public int Kilometrazha { get; set; }
        public bool Disponueshmeria { get; set; }
        public int Cmimi_Per_Day { get; set; }



        //Insert
        public VeturatBO(string lloji, string modeli, string regjistrimi, int viti_prodhimit, int kilometrazha, bool disponueshmeria, int cmimi_per_day)
        {
            Lloji = lloji;
            Modeli = modeli;
            Regjistrimi = regjistrimi;
            Viti_Prodhimit = viti_prodhimit;
            Kilometrazha = kilometrazha;
            Disponueshmeria = disponueshmeria;
            Cmimi_Per_Day = cmimi_per_day;
        }


        //Update
        public VeturatBO(int vetura_Id, string lloji, string modeli, string regjistrimi, int viti_prodhimit, int kilometrazha, bool disponueshmeria, int cmimi_per_day)
        {
            Vetura_Id = vetura_Id;
            Lloji = lloji;
            Modeli = modeli;
            Regjistrimi = regjistrimi;
            Viti_Prodhimit = viti_prodhimit;
            Kilometrazha = kilometrazha;
            Disponueshmeria = disponueshmeria;
            Cmimi_Per_Day = cmimi_per_day;
        }


        //Delete
        public VeturatBO(int vetura_Id)
        {
            Vetura_Id = vetura_Id;
        }
    }
}
