using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad2
{

    public class Vrtlar : Uposlenik
    {

        Datum datumUposlenja;
        Stan stan = new NenamjestenStan(30, Lokacija.Prigradsko, true);
        decimal mjesecnaPlata;
        public decimal MjesecnaPlata
        {
            get { return mjesecnaPlata; }
            set { mjesecnaPlata = value; }
        }
        public Vrtlar(string pime, string pprezime, Datum pDatumUposlenja, decimal pMjesecnaPlata) : base(pime, pprezime)
        {

            datumUposlenja = pDatumUposlenja;
            MjesecnaPlata = pMjesecnaPlata;
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

