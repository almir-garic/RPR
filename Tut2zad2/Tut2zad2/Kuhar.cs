using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad2
{

    public class Kuhar : Uposlenik
    {
        string[] jela = new string[3] { "jelo1", "jelo2", "jelo3" };

        //indekser

        public string this[int indeks]
        {
            get { return jela[indeks]; }
            set { jela[indeks] = value; }
        }

        Datum datumUposlenja;
        decimal mjesecnaPlata;

        public decimal MjesecnaPlata
        {
            get { return mjesecnaPlata; }
            set { mjesecnaPlata = value; }
        }

        public Kuhar(string pime, string pprezime, Datum pDatumUposlenja, decimal mjesecnaPlata) : base(pime, pprezime)
        {

            datumUposlenja = pDatumUposlenja;
            MjesecnaPlata = mjesecnaPlata;

        }
        public override string ToString()
        {
            return string.Format("{0} {1} Datum uposlenja : {2} Mjesecna plata : {3}", Prezime, Ime, datumUposlenja, MjesecnaPlata);

        }
        public override decimal IznosPlacanja()
        {
            return MjesecnaPlata;
        }
    }
}
