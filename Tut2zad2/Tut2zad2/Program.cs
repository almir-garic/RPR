using System;


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
namespace Tut2zad2
{
    enum Lokacija { Gradsko = 1, Prigradsko = 2 };

    class Program
    {
        


        static void Main(string[] args)
        {
            Datum datum1 = new Datum(12, 10, 2015);
            Datum datum2 = new Datum(13, 10, 2015);
            Datum datum3 = new Datum(15, 10, 2015);

            Uposlenik Batler = new Batler("batlerIme", "batlerPrezime", datum1, 1200, 15);
            Uposlenik Vrtlar = new Vrtlar("vrtlarIme", "vrtlarPrezime", datum2, 800);
            Uposlenik Kuhar = new Kuhar("kuharIme", "kuharPrezime", datum3, 1600);

            Stan[] stanovi = new Stan[7];
            stanovi[0] = new NenamjestenStan(50, Lokacija.Gradsko, true);
            stanovi[1] = new NenamjestenStan(80, Lokacija.Prigradsko, true);
            stanovi[2] = new NamjestenStan(40, Lokacija.Prigradsko, true, 2000, 2);
            stanovi[3] = new NamjestenStan(80, Lokacija.Gradsko, false, 3000, 6);
            stanovi[4] = new LuksuzniStan(200, Lokacija.Gradsko, true, Batler);
            stanovi[5] = new LuksuzniStan(250, Lokacija.Gradsko, true, Kuhar);
            stanovi[6] = new LuksuzniStan(300, Lokacija.Gradsko, true, Vrtlar);
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

            //zaustavlja konzolu
            Console.ReadLine();

        }
    }
    
}
