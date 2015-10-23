using System;

/*Zadatak 2
Cilj je prisjetiti se rada sa klasama kroz jednostavan zadatak. Osnovni koncepti i sintaksa su prezentirani
na trećem predavanju.
Napisati klasu Osoba koja sadrži sljedeća (privatna) polja:
 ime (string) – ime osobe
 prezime (string) – prezime osobe
Konstruktor klase Osoba prima parametre ime i prezime.
Napisati klasu Predmet koja sadrži sljedeća polja:
 naziv (string) – naziv predmeta
 profesor (Osoba) – ime i prezime profesora
 brojStudenata (int) – broj studenata koji pohadjaju predmet
Konstruktor klase Predmet prima naziv predmeta, ime profesora i broj studenata.
Za sva polja u obje klase definisati osobine (properties), koje su javne, a služe za pristup privatnim
poljima klase.
Potrebno je izvršiti dekompoziciju programa, izdvajanjem koda za klase Osoba i Predmet u zasebnu
datoteku, Predmet.cs. Dodavanje nove datoteke uraditi desnim klikom na ime projekta u Solution
Exploreru -> Add -> New Item, pa izabrati Class i dati klasi ime.
Unutar metode Main klase Program napraviti test klasa Osoba i Predmet. Prvo instancirati klasu Osoba, a
zatim i klasu Predmet. Ispisati vrijednosti polja instancirane klase Predmet. Promijeniti neke vrijednosti
korištenjem settera (preko properties), a nakon toga ispisati nove vrijednosti parametara (korištenjem
gettera iz properties)*/

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

    /// <summary>
    /// Javna klasa Predmet
    /// </summary>
    public class Predmet : Osoba
    {
        string nazivPredmeta;
        Osoba profesor;
        int brojStudenata;

        public Predmet(string parametar_nazivPredmeta, string parametar_ime, int parametar_brojStudenata) 
            {
                NazivPredmeta = parametar_nazivPredmeta;
                Ime = parametar_ime;//nasljedjeni privatni atribut ime iz klase osoba,dodjeluje se child klasi Predmet
                BrojStudenata = parametar_brojStudenata;
            }

        /// <summary>
        /// property-get i set za nazivPredmeta
        /// </summary>
        public string NazivPredmeta
        {
            get
            {
                return nazivPredmeta;
            }
            set
            {
                nazivPredmeta = value;
            }
        }
        
        /// <summary>
        /// property-get i set za brojStudenata
        /// </summary>
        public int BrojStudenata
        {
            get
            {
                return brojStudenata;
            }
            set
            {
                brojStudenata = value;
            }
        }

    }
    /// <summary>
    /// Glavna klasa program
    /// </summary>
    class Program
    {
      
        /// <summary>
        /// Glavna metoda main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

        }
    }
}
