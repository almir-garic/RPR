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
