using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Autor : Almir Garic (almir.garic.1992@ieee.org)

/*Zadatak 6
a) Napišite funkciju “IzbrisiPodstring” sa dva parametra tipa “string”. Funkcija treba da kreira novi string
u koji će prepisati sadržaj prvog stringa iz kojeg su izbačena sva eventualna pojavljivanja stringa koji je
zadan drugim parametrom kao njegovog podstringa (ukoliko takvih pojavljivanja nema, string se
prepisuje neizmijenjen), i da vrati tako kreirani string kao rezultat. Na primjer, nakon poziva funkcije
s = IzbrisiPodstring("rijexyzc", "xyz");
u stringu “s” (uz pretpostavku da je propisno deklariran) trebao bi se nalaziti niz znakova “rijec”. Funkciju
napisati pomoću metoda klase String.
b) Napišite funkciju “NadjiPodstring” koja pronalazi da li se jedan string nalazi unutar drugog, i ukoliko
se nalazi, gdje se nalazi. Funkcija ima dva parametra tipa “string”. Funkcija treba da ispita da li se string
predstavljen drugim parametrom nalazi unutar stringa predstavljen prvim parametrom kao njegov dio
(na primjer, string “je lijep” se nalazi kao dio stringa “danas je lijep dan”. Ukoliko je odgovor potvrdan,
funkcija treba da kao rezultat vrati redni broj pozicije na kojoj se drugi string nalazi unutar prvog, pri
čemu brojanje počinje od nule (tako da za prethodni primjer rezultat treba biti 6). Ukoliko je odgovor
odrečan, funkcija treba da vrati –1 kao rezultat. Funkciju napisati pomoću metoda klase String.

*/
namespace Tut1SRzad6
{
    class Program
    {
        public string IzbrisiPodstring(string s1, string s2)
        {
            char[] niz1 = s1.ToCharArray();
            char[] niz2 = s2.ToCharArray();

            char[] noviNiz = new char[s1.Length];
            for (int i = 1; i < niz1.Length; i++)
            {
                for (int j = 0; j < niz2.Length; j++)
                {
                    if (niz1[i]!= niz2[j])
                    {
                        j++;
                    }  
                }
                noviNiz[i]=
            }
            string noviString;
            noviString = new string(noviNiz);

            return noviString;
        }

        static void Main(string[] args)
        {
            Program a=new Program();
            var s = a.IzbrisiPodstring("rijexyzc", "xyz");
           Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
