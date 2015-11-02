using System;
using System.Linq;
//Autor: Almir Garic (almir.garic.1992@ieee.org)
/*Zadatak 5
Napišite funkciju “DaLiJePalindrom” koja za string koji joj je proslijeđen kao parametar ispituje da li
predstavlja palindrom ili ne, i kao rezultat vraća odgovarajuću logičku vrijednost “true” ili “false”.
Napomena: Pod palindromima smatramo riječi ili rečenice koje se isto čitaju sa obe strane (npr.
“kapak”). Prilikom ispitivanja treba ignorirati eventualne razmake, interpunkcijske znake i razliku između
velikih i malih slova, tako da rečenica “Ana voli Milovana” treba da bude prepoznata kao palindrom, iako
bukvalno pročitana sa suprotnog kraja glasi “anavoliM ilov anA”. */

namespace Tut1SRzad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi string : ");
            string s = Console.ReadLine().Trim();
            Console.WriteLine(s);

            //pomocni string
            string rijec2="";

            //pravim niz od unesenog stringa
            string [] b = s.Split(' ');

            //niz stringa sastavljam u jedinstven string
            for(int i = 0; i < b.Length; i++)
            {
                rijec2=rijec2+b[i];
            }

            //razbijam novonastali string na niz charova
            char[] rijec = rijec2.ToCharArray();

            //pomocni niz charova koji cu okrenuti
            char[] okrenutaRijec = rijec; 

            //pozivam metodu za okretanje niza
                Array.Reverse(okrenutaRijec);

            //od niza pravim string
            string temp = new string(okrenutaRijec);

            //ispis
            Console.WriteLine(rijec2+" okrenuto glasi : "+temp);


            //provjera pomocu sequenceEqual iz biblioteke system.Linq
            if (rijec.SequenceEqual(temp))
                {
                Console.WriteLine("DA,radi se o palindromu");
                }
            else
            {
                Console.WriteLine("NE,ne radi se o palindromu");
            }
        
            //zaustavljam konzolu
        Console.ReadKey();
        }
    }
}