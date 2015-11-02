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

    Zadatak 2
Proširiti rješenje za agenciju Stan tako da se može iznajmiti i luksuzni apartman koji na osnovnu cijenu
od 1500 km dodaje još cijenu osoblja koje radi na imanju. Osoblje može biti batler, kuhar i vrtlar. Svaki
član osoblja ima svoje ime, prezime, datum uposlenja i mjesečnu platu. Kuhar ima listu jela (string) koje
je u stanju da napravi. Vrtlar sadrži i stan u kojim se stanuje, s obzirom da kompanija ima ugovor sa
vrtlarima da uz posao dobiju i nenamješten stan. Batler ima pored osnovnih još atribut godine iskustva.
Za potrebe pregleda resursa kompanije potrebno je mogude ispisati sve stanove i osoblje koje kompanija
posjeduje. Pri izradi rješenja primijeniti polimorfizam.

*/
namespace Tut2PRzad2
{
    class Program
    {
        enum Lokacija { Gradsko = 1, Prigradsko = 2 };

        /// <summary>
        /// Interface Istan
        /// </summary>
        interface IStan
        {
            // int BrojKvadrata { get; set; }
            //Lokacija Lokacija { get; set; }
            //bool ImaInternetKonekcije { get; set; }
            void Ispisi();
            double ObracunajCijenuNajma();
        }
        /// <summary>
        /// abstraktna klasa Stan
        /// </summary>
        abstract class Stan : IStan
        {
            // atributi abstraktne klase sa njihovih osobinama
            int brojKvadrata;

            public int BrojKvadrata
            {
                get { return brojKvadrata; }
                set { brojKvadrata = value; }
            }
            Lokacija lokacija;

            public Lokacija Lokacija
            {
                get { return lokacija; }
                set { lokacija = value; }
            }
            bool imaInternetKonekcije;

            public bool ImaInternetKonekcije
            {
                get { return imaInternetKonekcije; }
                set { imaInternetKonekcije = value; }
            }

            //abstraktne metode klase Stan
            public abstract void Ispisi();
            public abstract double ObracunajCijenuNajma();


        }
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
                Console.WriteLine(BrojKvadrata+" "+Lokacija+" "+" Luksuzan "+((ImaInternetKonekcije)?"Da":"Ne"));
            }
            public override double ObracunajCijenuNajma()
            {
                double cijena = 1500;//osnovna cijena luksuznog stana
                if ((ImaInternetKonekcije))
                {
                    cijena += 0.02f * cijena;
                }
                return cijena;
            }
        }

       public class Datum
        {
            int dan;
            public int Dan
            {
                get { return dan; }
                private set
                {
                    if(dan>0 && dan<=31) dan = value;
                    else
                    {
                        Console.WriteLine("Ne validan dan({0}) postavi na 1.", value);
                        dan = 1;
                    }
                } // private set-ne moze se pristupiti izvan klase
            }
            int mjesec;
            public int Mjesec
            {
                get { return mjesec; }
                private set
                {
                    if(value>0 && value <= 12)
                    {
                        mjesec = value;
                    }
                    else
                    {
                        Console.WriteLine("Ne validan mjesec({0}) postavi na 1.", value);
                        mjesec = 1;
                        
                    }
                    
                }
            }
            int godina;
           public int Godina
            {
                get { return godina; }
                private set { mjesec = value; }
            }

            // konstruktor: koristi get i set za validaciju dana,godine i mjeseca
           public Datum(int dan,int mjesec,int godina)
            {
                Dan = dan;
                Mjesec = mjesec;
                Godina = godina;
                Console.WriteLine("Datum-konstruktor {0}", this);
            }

            public string Ispis()
            {
                return string.Format("{0}/{1}/{2}", Dan, Mjesec, Godina);
            }

        }
        public abstract class Uposlenik
        {
            string ime;
            public string Ime
            {
                get { return ime; }
                set { ime = value; }
            }
            string prezime;
           public string Prezime
            {
                get { return prezime; }
                set { prezime = value; }
            }
            
           
            //konstruktor za uposlenik
            public Uposlenik(string ime,string prezime,Datum pDatumUposlenja,decimal mjesecnaPlata)
            {
                Ime = ime;
                Prezime = prezime;
                
            }
            public abstract override string ToString();
            public abstract decimal IznosPlacanja();
            

            class Batler:Uposlenik
            {
                Datum datumUposlenja;
                decimal mjesecnaPlata;
                
                public decimal MjesecnaPlata
                {
                    get { return mjesecnaPlata; }
                    set { mjesecnaPlata = value; }
                }
                public Batler(string ime,string prezime,Datum pDatumUposlenja,decimal mjesecnaPlata):base(Ime,Prezime)
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
            class Kuhar:Uposlenik
            { 

                 Datum datumUposlenja;
                decimal mjesecnaPlata;
                
                public decimal MjesecnaPlata
                {
                    get { return mjesecnaPlata; }
                    set { mjesecnaPlata = value; }
                }

                public Kuhar(string pime,string pprezime,Datum pDatumUposlenja,decimal mjesecnaPlata) : base(Ime,Prezime)
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
            class Vrtlar:Uposlenik
            {
                 Datum datumUposlenja;
                 decimal mjesecnaPlata;
                public decimal MjesecnaPlata
                {
                    get { return mjesecnaPlata; }
                    set { mjesecnaPlata = value; }
                }
                public Vrtlar(string ime,string prezime,Datum pDatumUposlenja,decimal pMjesecnaPlata) : base(Ime,Prezime)
                {
                    
                    datumUposlenja = pDatumUposlenja;
                    MjesecnaPlata = pMjesecnaPlata;
                }
                public override string ToString()
                {
                    return string.Format("{0} {1} Datum uposlenja : {2} Mjesecna plata : {3}", Prezime, Ime,datumUposlenja,MjesecnaPlata);

                }
                public override decimal IznosPlacanja()
                {
                    return MjesecnaPlata;
                }
            }
        }

        static void Main(string[] args)
{
    Stan[] stanovi = new Stan[4];
    stanovi[0] = new NenamjestenStan(50, Lokacija.Gradsko, true);
    stanovi[1] = new NenamjestenStan(80, Lokacija.Prigradsko, true);
    stanovi[2] = new NamjestenStan(40, Lokacija.Prigradsko, true, 2000, 2);
    stanovi[3] = new NamjestenStan(80, Lokacija.Gradsko, false, 3000, 6);
    Console.WriteLine("Površina Lokacija Namješten Internet Vrijednost namještaja Broj aparata");


    foreach (Stan stan in stanovi)
    {
        stan.Ispisi();
    }
    int minPovrsina = 0;
    int maxPovrsina = 0;
    Console.WriteLine("Unesite minimalnu zeljenu povrsinu");
    while (!Int32.TryParse(Console.ReadLine(), out minPovrsina) || minPovrsina < 0)
    {
        Console.WriteLine("Unos nije ispravan");
    }
    Console.WriteLine("Unesite maksimalnu zeljenu povrsinu");
    while (!Int32.TryParse(Console.ReadLine(), out maxPovrsina) || maxPovrsina < 0)
    {
        Console.WriteLine("Unos nije ispravan");
    }
    foreach (Stan stan in stanovi)
    {
        if (stan.BrojKvadrata >= minPovrsina && stan.BrojKvadrata <= maxPovrsina)
        {
            stan.Ispisi();
            Console.WriteLine("Ukupna cijena najma stana je {0:F2} ", stan.ObracunajCijenuNajma());
        }
    }
    Console.ReadLine();


}
    }
}
