using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tut2zad2;

namespace Tut2zad2
{

        public class Batler : Uposlenik
        {

            Datum datumUposlenja;
            int godineIskustva;
      
            public int GodineIskustva
            {
                get { return godineIskustva; }
                set { godineIskustva = value; }
            }
            decimal mjesecnaPlata;

            public decimal MjesecnaPlata
            {
                get { return mjesecnaPlata; }
                set { mjesecnaPlata = value; }
            }
            public Batler(string pime, string pprezime, Datum pDatumUposlenja, decimal mjesecnaPlata, int godineIskustva) : base(pime, pprezime)
            {
                GodineIskustva = godineIskustva;
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


