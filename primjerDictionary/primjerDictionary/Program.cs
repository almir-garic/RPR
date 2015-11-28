using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjerDictionary
{
    class Program
    {
        //------------------------------KLASA OSOBA I GLUMAC-----------------------------
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
        //-------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            //deklarisem rijecnik
            Dictionary<string, Glumac> glumci = new Dictionary<string, Glumac>();

            //dodajem u rijecnik sa kljucevima
            glumci.Add("prvi",new Glumac()
            {
                Ime = "almir",
                Prezime = "Garic",
                Starost = 23,
                TopFilmovi = new List<string>() { "Interstellar", "Magic Mike", "Dallas Buyers Club" }
            });
            glumci.Add("drugi",new Glumac()
            {
                Ime = "kenan",
                Prezime = "husic",
                Starost = 22,
                TopFilmovi = new List<string>() { "avion", "auto", "tramvaj" }
            });

            //pomocna varijabla
            Glumac g;

            //mijenjam vrijednost imena
            if (glumci.TryGetValue("prvi",out g))
            {
                g.Ime = "nabukodonosor";
            }

            //ispis kljuceva
            foreach(string key in glumci.Keys)
            {
                Console.WriteLine(key);
            }

            //ispis vrijednosti .Ispisi()
            foreach(Glumac value in glumci.Values)
            {
                value.Ispisi();
            }
            Console.Read();


        }
    }
}
