using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tut2zad2;

namespace Tut2zad2
{
    
    class LuksuzniStan : Stan
    {
        Uposlenik osoba;
        public LuksuzniStan(int brojKvadrata, Lokacija lokacija, bool imaInternet, Uposlenik pOsoba)
        {
            BrojKvadrata = brojKvadrata;
            Lokacija = lokacija;
            ImaInternetKonekcije = imaInternet;
            osoba = pOsoba;
        }

        public override void Ispisi()
        {
            Console.WriteLine(BrojKvadrata + " " + Lokacija + " " + " Luksuzan " + ((ImaInternetKonekcije) ? "Da" : "Ne"));
        }
        public override double ObracunajCijenuNajma()
        {
            double cijena = 1500 + (double)osoba.IznosPlacanja();//osnovna cijena luksuznog stana
            if ((ImaInternetKonekcije))
            {
                cijena += 0.02f * cijena;
            }
            return cijena;
        }
    }
   

}
