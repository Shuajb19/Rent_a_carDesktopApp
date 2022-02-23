using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_carBO
{
    public class KlientatBO
    {
        public int Klienti_ID { get; set; }

        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public int Tel { get; set; }
        public string Qyteti { get; set; }


        //Insert
        public KlientatBO(string emri, string mbiemri, string email, int tel, string qyteti)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            Email = email;
            Tel = tel;
            Qyteti = qyteti;

        }

        //Update
        public KlientatBO(int klienti_Id ,string emri, string mbiemri, string email, int tel, string qyteti)
        {
            Klienti_ID = klienti_Id;
            Emri = emri;
            Mbiemri = mbiemri;
            Email = email;
            Tel = tel;
            Qyteti = qyteti;

        }

        //Delete
        public KlientatBO(int klienti_Id)
        {
            Klienti_ID = klienti_Id;
        }
    }
}
