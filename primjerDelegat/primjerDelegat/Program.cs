using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjerDelegat
{
    class Program
    {
        //delegacija delegata
        delegate double procesDelegate(double broj1, double broj2);

        //definisanje metode Sabiranje
        static double Sabiranje(double broj1,double broj2)
        {
            return broj1 + broj2;
        }

        //definisanje metode Oduzimanje
        static double Oduzimanje(double broj1,double broj2)
        {
            return broj1-broj2;
        }




        static void Main(string[] args)

        {
            //instanciranje delegata
            procesDelegate matematicka;

            //difinisanje parametara
            double broj11 = 12.2d;
            double broj22 = 10.3d;

            Console.WriteLine("Unesite S za sabiranje ili O oduzimanje ");
            string input = Console.ReadLine();

            //Inicijalizacija delegata matematickaOperacija(referenca na metodu)
            if (input == "S")
            {
                matematicka = new procesDelegate(Sabiranje);
            }
            else 
            {
                matematicka = new procesDelegate(Oduzimanje);
            }

            //poziv metode koristenjem delegata
            Console.WriteLine("Rezultat je : {0}",matematicka(broj11, broj22));

            Console.ReadKey();
        }

    }
}
