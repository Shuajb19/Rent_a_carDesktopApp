using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_carBO
{
    public class HuazimetBO
    {
        public int Rental_Id { get; set; }

        public int Vetura_Id { get; set; }
        public string Regjistrimi_Vetures { get; set; }
        public int Klienti_Id { get; set; }

        public string Emri_Klientit { get; set; }

        public DateTime Data_Huazimit { get; set; }

        public int Cmimi { get; set; }



        public HuazimetBO(int vetura_Id, string regjistrimi_vetures, int klienti_Id, string emri_klientit, DateTime data_huazimit, int cmimi)
        {
            Vetura_Id = vetura_Id;
            Regjistrimi_Vetures = regjistrimi_vetures;
            Klienti_Id = klienti_Id;
            Emri_Klientit = emri_klientit;
            Data_Huazimit = data_huazimit;
            Cmimi = cmimi;
        }

        public HuazimetBO(int rental_Id ,int vetura_Id, string regjistrimi_vetures, int klienti_Id, string emri_klientit, DateTime data_huazimit, int cmimi)
        {
            Rental_Id = rental_Id;
            Vetura_Id = vetura_Id;
            Regjistrimi_Vetures = regjistrimi_vetures;
            Klienti_Id = klienti_Id;
            Emri_Klientit = emri_klientit;
            Data_Huazimit = data_huazimit;
            Cmimi = cmimi;
        }

        public HuazimetBO(int rental_Id)
        {
            Rental_Id = rental_Id;
        }
    }
}
