using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tut2zad2;

namespace Tut2zad2
{

    public abstract class Uposlenik : IPlacanje
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            private set { ime = value; }
        }
        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            private set { prezime = value; }
        }


        //konstruktor za uposlenik
        public Uposlenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;

        }
        public abstract override string ToString();
        public abstract decimal IznosPlacanja();

    }
}
