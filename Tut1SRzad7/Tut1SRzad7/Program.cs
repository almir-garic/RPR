using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autor : Almir Garic(almir.garic.1992@ieee.org)
/*Zadatak 7
Napišite program koji traži od korisnika da unese spisak riječi (broj riječi se prethodno unosi sa
tastature), a zatim ispisuje na ekran prvu i posljednju riječ iz spiska po abecednom poretku, kao i popis
svih unesenih riječi, ali bez ispisivanja duplikata (tj. bez ispisivanja riječi koje su se već jednom ispisale).
Program realizirajte korištenjem niza stringova, odnosno niza čiji su elementi tipa “string”.*/

namespace Tut1SRzad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj rijeci ");
            string s = Console.ReadLine();
            var n = Int32.Parse(s);

            //inicijaliziramo niz stringova
            string[] rijecnik = new string[n];

            //instanciramo clanove niza stringova
            for(int i = 0; i < rijecnik.Length; i++)
            {
                rijecnik[i] = Console.ReadLine();
            }

            //istanciramo sortirani niz
            string[] sortiranRijecnik = new string[n];
            for (int i = 0; i < rijecnik.Length; i++)
            {
                sortiranRijecnik[i] =rijecnik[i];
            }

            //funkcija za sortiranje niza abecedno stringa preuzeta sa
            //http://stackoverflow.com/questions/16636554/sorting-an-array-alphabetically-in-c-sharp
            Array.Sort(sortiranRijecnik, (x, y) => String.Compare(x, y));

            //ispisujemo clanove niza clanove niza stringova
            Console.WriteLine("Popis svih unesenih rijeci je sljedeci :");
            for (int i = 0; i < rijecnik.Length; i++)
            {
                Console.WriteLine(rijecnik[i]);
            }

            //uz pretpostavku da idu jedna za drugom(mislim na rijeci duplikate)
            //ispisujemo clanove sortiranog niza clanove niza stringova
            Console.WriteLine("Popis svih unesenih rijeci po abecednom poretku je sljedeci :");
            for (int i = 1; i <= sortiranRijecnik.Length; i++)
            {
                for(int j=i+1;j<=sortiranRijecnik.Length-1;j++)
                    if (sortiranRijecnik[i] == sortiranRijecnik[j]) { continue; }
                    else
                    {
                        Console.WriteLine(sortiranRijecnik[i]);
                        i=j;
                    }                
            }


            //zaustavljamo konzolu
            Console.ReadKey();
        }
    }
}
