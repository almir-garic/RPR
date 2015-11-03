using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad2
{
    /// <summary>
    /// Klasa Namjesten Stan
    /// </summary>
    class NamjestenStan : Stan

    {
        double cijenaNamjestana;
        public double CijenaNamjestaja
        {
            get { return cijenaNamjestana; }
            set { value = cijenaNamjestana; }
        }
        int brojKucanskihAparata;
        public double BrojKucanskihAparata
        {
            get { return brojKucanskihAparata; }
            set { value = brojKucanskihAparata; }
        }

        public NamjestenStan(int brojKvadrata, Lokacija lokacija, bool imaInternet, double cijena, int brojApartmana)
        {
            BrojKvadrata = brojKvadrata;
            Lokacija = lokacija;
            ImaInternetKonekcije = imaInternet;
            this.cijenaNamjestana = cijena;
            this.brojKucanskihAparata = brojApartmana;
        }

        public override void Ispisi()
        {
            Console.WriteLine(BrojKvadrata + " " + Lokacija + " " + " Namjesten " +
           ((ImaInternetKonekcije) ? "Da" : "Ne") + " " + CijenaNamjestaja + " " +
           BrojKucanskihAparata);
        }
        public override double ObracunajCijenuNajma()
        {
            double cijena = (Lokacija == Lokacija.Gradsko) ? 200 : 150;
            cijena += BrojKvadrata;
            if (ImaInternetKonekcije)
            {
                cijena += 0.01f * cijena;
            }
            if (brojKucanskihAparata < 3)
            {
                cijena += 0.01f * CijenaNamjestaja * BrojKucanskihAparata;
            }
            else
            {
                cijena += 0.02f * CijenaNamjestaja * BrojKucanskihAparata;
            }
            return cijena;
        }
    }

}
