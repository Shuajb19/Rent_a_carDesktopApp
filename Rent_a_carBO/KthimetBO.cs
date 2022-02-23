using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_carBO
{
    public class KthimetBO
    {
        public int Return_Id { get; set; }
        public int Vetura_Id { get; set; }
        public int Klienti_Id { get; set; }

        public string Emri_Klientit { get; set; }
        public DateTime Data_Dorezimit { get; set; }

        public int Ditet_e_shfrytezimit { get; set; }
        public int Cmimi_Total { get; set; }


        

        public KthimetBO(int vetura_Id, int klienti_Id, string emri_klientit, DateTime data_dorezimit, int ditet_e_shfrytezimit, int cmimi_total)
        {
            Vetura_Id = vetura_Id;
            Klienti_Id = klienti_Id;
            Emri_Klientit = emri_klientit;
            Data_Dorezimit = data_dorezimit;
            Ditet_e_shfrytezimit = ditet_e_shfrytezimit;
            Cmimi_Total = cmimi_total;
        }

        public KthimetBO(int return_Id, int vetura_Id, int klienti_Id, string emri_klientit, DateTime data_dorezimit, int ditet_e_shfrytezimit, int cmimi_total)
        {
            Return_Id = return_Id;
            Vetura_Id = vetura_Id;
            Klienti_Id = klienti_Id;
            Emri_Klientit = emri_klientit;
            Data_Dorezimit = data_dorezimit;
            Ditet_e_shfrytezimit = ditet_e_shfrytezimit;
            Cmimi_Total = cmimi_total;
        }

        public KthimetBO(int return_Id)
        {
            Return_Id = return_Id;
        }
    }
}
