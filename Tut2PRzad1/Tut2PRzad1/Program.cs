using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autor : Almir Garic (almir.garic.1992@ieee.org)
/*Zadatak 1
Razviti konzolno programsko rješenje koje de omoguditi za agenciju Stan: 1) evidenciju stanova 2)
mjesečni obračun najma stana. Stanovi mogu biti namješteni i nenamješteni. Za sve stanove se navodi
površina (broj kvadrata) stana, lokacija stana (gradsko ili prigradsko područje) i da li postoji Internet
konekcija. U slučaju da je stan namješten navodi se ukupna vrijednost namještaja i broj kudanskih
aparata u stanu.
Obračun najma se vrši tako što zainteresovana osoba (klijent agencije Stan) navede rang vrijednosti za
površinu stana koji želi iznajmiti i lokaciju stana. Nakon toga se prikažu svi stanovi koji odgovaraju
navedenim osobinama, sa dodatnim podacima o tome da li je stan namješten i da li ima Internet
konekciju. Nakon toga klijent bira stan i vrši se obračun najma za 1 mjesec. Bez obzira da li stan
nenamješten ili namješten ako pripada gradskom području osnovna cijena najma je 200 KM mjesečno, a
ako pripada prigradskom području cijena najma je 150 KM. Cijena kvadrata stana za sve stanove je 1KM.
Na osnovnu cijenu najma se dodaje broj kvadrata pomnožen sa jediničnom cijenom kvadrata stana. Za
nenamješten stan se nakon toga cijena najma povedava za 2% ukoliko stan ima Internet konekciju, a za
namješten za 1%. U slučaju da je stan namješten izračunata cijena najma se nadalje povedava tako što se
doda 1% od ukupne vrijednosti namještaja ukoliko je broj kudanskih aparata manji od 3, a ako je vedi ili
jednak 3 dodaje se 2% od ukupne vrijednosti namještaja. Obavijestiti korisnika o iznosu potrebnom za
najam.
Scenarij testiranja:
Površina Lokacija Namješten Internet Vrijednost namještaja Broj aparata
1. 50 gradsko nenamješten Da
2. 80 prigradsko nemamješten Da
3. 40 prigradsko namješten Da 2000 2
4. 80 gradsko namješten Ne 3000 6
Klijent agencije Stan unosi da želi stan čija površina je u rangu 60-90, prikazuju se stan 2 i 4. Cijena najma
za stanove je respektivno 234,6 i 640. 
*/
namespace Tut2PRzad1
{
    class Program
    {
        enum Lokacija { Gradsko=1,Prigradsko=2 };

        /// <summary>
        /// abstraktna klasa Stan
        /// </summary>
        abstract class Stan
        {
            // atributi abstraktne klase sa njihovih osobinama
            int brojKvadrata;

            public int BrojKvadrata
            {
                get { return brojKvadrata; }
                set { value = brojKvadrata; }
            }
            Lokacija lokacija;

            public Lokacija Lokacija
            {
                get { return lokacija; }
                set { value = lokacija; }
            }
            bool imaInternetKonekcije;

            public bool ImaInternetKonekcije
            {
                get { return imaInternetKonekcije; }
                set { value = imaInternetKonekcije; }
            }

            //abstraktne metode klase Stan
            public abstract void Ispisi();
            public abstract double ObracunajCijenuNajma();

            class NenamjesteStan : Stan
            {
                public override void Ispisi()
                {
                    Console.WriteLine(BrojKvadrata + " " + Lokacija + " " + " Nenamjesten " + (ImaInternetKonekcije) ? "Da" : "Ne");
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
                public NenamjesteStan(int brojKvadrata,Lokacija lokacija,bool imaInternet)
                {
                    BrojKvadrata = brojKvadrata;
                    Lokacija = lokacija;
                    ImaInternetKonekcije = imaInternet;
                }
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

                    public NamjestenStan(int brojKvadrata,Lokacija lokacija,bool imaInternet,double cijena,int brojApartmana)
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
                       ((ImaInternetKonekcija) ? "Da" : "Ne") + " " + CijenaNamjestaja + " " +
                       BrojKucanskihAparata);
                    }
                    public override double ObracunajCijenuNajma()
                    {
                        double cijena = (Lokacija == Lokacija.Gradsko) ? 200 : 150;
                        cijena += BrojKvadrata;
                        if (ImaInternetKonekcija)
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
        }
        static void Main(string[] args)
        {

        }
    }
}
