using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjerTuple
{
    class Program
    {
        //-------------------------KLASA OSOBA I GLUMAC-------------------------------
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
        //----------------------------------------------------------------------------
        /// <summary>
        /// MAIN 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Deklaracija rijecnika sa Tuple<string,int> --kljucevima
            Dictionary<Tuple<string, int>, Glumac> glumci = new Dictionary<Tuple<string, int>, Glumac>();

            Tuple<string, int> kljuc1 = Tuple.Create<string, int>("Jimmy", 1);
            Tuple<string, int> kljuc2 = Tuple.Create<string, int>("Jimmy", 2);

            //dodajem glumce
            glumci.Add(kljuc1, new Glumac()
            {
                Ime = "almir",
                Prezime = "garic",
                Starost = 23,
                TopFilmovi = new List<string>() { "film1", "film2", "film3" }
            });
        glumci.Add(kljuc2, new Glumac()
        {
            Ime = "Matthew",
            Prezime = "McConaughey",
            Starost = 45,
            TopFilmovi = new List<string>() { "Interstellar", "Dallas Buyers Club", "Magic Mike" }
            });

            //pomocna varijabla
            Glumac g;
            if(glumci.TryGetValue(Tuple.Create<string,int>("Jimmy",1),out g))
            {
                g.Ime = "nabukodonosor";
            }

            //ispisi kljuceve
            foreach(Tuple<string,int>key in glumci.Keys)
            {
                Console.WriteLine(key.Item1 + " " + key.Item2);
            }

            //ispisi vrijednosti
            foreach(Glumac value in glumci.Values)
            {
                value.Ispisi();
            }

            //drugi naci
            foreach(KeyValuePair<Tuple<string,int>,Glumac> pair in glumci)
            {
                pair.Value.Ispisi();
            }

            //zaustavi konzolu
            Console.ReadKey();
        }
}
}
