using System;


namespace Tut1zad2
{
    /// <summary>
    /// Definicija Klase Osoba
    /// </summary>
    public class Osoba
    {
        private string ime;
        private string prezime;

        /// <summary>
        /// Defaultni konstruktor,parent(tj. base) klasa treba da ga sadrzi 
        /// </summary>
        public Osoba()
        {
            ime = "default ime";
            prezime = "default prezime";
        }
        /// <summary>
        /// Instance Konstruktor klase Osoba
        /// </summary>
        /// <param name="ime">privatni parametar ime</param>
        /// <param name="prezime">privatni parametar prezime</param>
        public Osoba(string parametar_ime, string parametar_prezime, int parametar_brojStudenata)
        {
            Ime = parametar_ime;
            Prezime = parametar_prezime;
        }

        /// <summary>
        /// property-get i set za ime
        /// </summary>
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }

        /// <summary>
        /// property-get i set za prezime
        /// </summary>
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }

    }
}
