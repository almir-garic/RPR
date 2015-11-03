using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad2
{
    /// <summary>
    /// Klasa Nenamjesten,nasljedjuje Parent klasu Stan
    /// </summary>
    class NenamjestenStan : Stan
    {
        public override void Ispisi()
        {
            Console.WriteLine(BrojKvadrata + " " + Lokacija + " " + " Nenamjesten " + ((ImaInternetKonekcije) ? "Da" : "Ne"));
        }
        public override double ObracunajCijenuNajma()
        {
            double cijena = (Lokacija == Lokacija.Gradsko) ? 200 : 150;
            cijena += BrojKvadrata;
            if (ImaInternetKonekcije)
            {
                cijena += 0.02f * cijena;
            }
            return cijena;
        }

        //Konstruktor
        public NenamjestenStan(int brojKvadrata, Lokacija lokacija, bool imaInternet)
        {
            BrojKvadrata = brojKvadrata;
            Lokacija = lokacija;
            ImaInternetKonekcije = imaInternet;
        }
    }
}
