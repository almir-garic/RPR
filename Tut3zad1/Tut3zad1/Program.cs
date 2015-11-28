using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//autor : Almir Garic (almir.garic.1992@ieee.org)

/*ZADATAK 1
Implementirajte metodu ToSortedArray (List<string> lista) koja će kao parametar primiti listu stringova,
a kao rezultat vratiti novi niz stringova (string []) sa svim elementima iz liste pri čemu elementi u nizu
trebaju biti sortirani prema dužini (najkraći string prvi, najduži zadnji). Obratiti pažnju na činjenicu da je
string referentni tip podatka.
Primjer 2 demonstrirao je neke od najosnovnijih operacija nad listama korištenjem stringa kao tipa
podatka koji se pohranjuje u listi. Ekvivalentno tome moguće je u listu smjestiti bilo koji tip podatka.
Sljedeći primjer demonstrira rad sa listama čiji su elementi klase. Ovaj primjer obuhvata nekoliko bitnih
pojedinosti koje su u nastavku obrazložene.
Implementirane su dvije jednostavne klase, Osoba i Glumac, pri čemu klasa Glumac naslijeđuje klasu
Osoba. U okviru klase Osoba nalazi se virtuelna metoda za ispis, koja je reimplementirana u klasi
Glumac.
*/
namespace Tut3zad1
{
    class Program
    {

        class Osoba
        {
            private string _Ime, _Prezime;
            private int _Starost;
            public int Starost
            {
                get { return _Starost; }
                set { _Starost = value; }
            }
            public string Prezime
            {
                get { return _Prezime; }
                set { _Prezime = value; }
            }
            public string Ime
            {
                get { return _Ime; }
                set { _Ime = value; }
            }
            public virtual void Ispisi()
            {
                Console.WriteLine(_Ime + " " + _Prezime + " " + _Starost + " god");
            }
        }
        class Glumac : Osoba
        {
            private List<string> _TopFilmovi;
            public List<string> TopFilmovi
            {
                get { return _TopFilmovi; }
                set { _TopFilmovi = value; }
            }
            public override void Ispisi()
            {
                Console.Write(Ime + " " + Prezime + " " + Starost + " god ||| TOP 3: ");
                if (_TopFilmovi == null)
                {
                    Console.WriteLine();
                    return;
                }
                foreach (string s in _TopFilmovi)
                    Console.Write(s + (_TopFilmovi.Last().Equals(s) ? Environment.NewLine : ", "));
            }
        }

        static void Main(string[] args)
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(new Osoba() { Ime = "almir", Prezime = "Garic", Starost =23 });
            osobe.Add(new Glumac()
            {
                Ime = "kenan",
                Prezime = "husic",
                Starost = 23,
                TopFilmovi = new List<string>() { "film1", "film2", "film3" }
            });
            osobe.Add(new Glumac()
            {
                Ime = "Matthew",
                Prezime = "McConaughey",
                Starost = 45,
                TopFilmovi = new List<string>() { "Interstellar", "Dallas Buyers Club","Magic Mike" }
            });
            osobe.Add(new Glumac()
            {
                Ime = "Denzel",
                Prezime = "Washington",
                Starost = 60,
                TopFilmovi = new List<string>() { "The Equalizer", "Man on Fire", "SafeHouse" }
 });
            Console.WriteLine("Osobe sortirane po starosti");
            osobe.Sort((x, y) => (x.Starost - y.Starost));
            
            foreach(Osoba o in osobe)
            {
                o.Ispisi();
            }
            Console.WriteLine("Osobe sortirane po starosti <60");
            foreach (Osoba o in osobe.Where(o => o.Starost < 60))
            {
                o.Ispisi();
            }
            Console.WriteLine("Prosjecan broj godina : "+ osobe.Average(o => o.Starost));
            Console.WriteLine("Broj osoba mladjih od 60 godina : " + osobe.Count(o => o.Starost < 60));
            Console.WriteLine("Najduze prezime : " + osobe.Max(o => o.Prezime));
            //neophodno je eksplicitno pretvoriti bazi u izvedeni kako bi se primijenile njegove metode
            foreach(Osoba o in osobe)
            {
                Glumac g = o as Glumac;
                if (g!= null){
                    Console.WriteLine(g.Ime + " " + g.Prezime + " " + ": " + g.TopFilmovi.FirstOrDefault());
                }
                Console.ReadLine();
            }


        }
    }
}
