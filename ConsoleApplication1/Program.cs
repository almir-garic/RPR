using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        const int broj_ulaza = 6;

        static bool validirajUlaz(string ulaz, out int[] brojevi)
        {
            brojevi = new int[broj_ulaza];
            string[] ulazi = ulaz.Split(',');

            if (ulazi.Length - broj_ulaza != 0) { return false; }
            
            for (int i=0;i<ulazi.Length;i++)
            {
                bool validirajBroj = Int32.TryParse(ulazi[i], out brojevi[i]);

                if (!validirajBroj)
                {
                    Console.WriteLine("Ulaz {0} nije ispravan broj", ulazi[i]);
                    return false;
                }

            }
            return true;
        }
        static bool sviPozitivni(int[] brojevi){

            foreach(int broj in brojevi)
            {
                if(broj<=0) {return false;}      
            }
            return true;
        }
        /// <summary>
        /// Metoda ispituje da li u zadanom nizu postoji neparnih brojeva
        /// </summary>
        /// <param name="brojevi">zahtjeva cjelobrojni niz kao parametar</param>
        /// <returns>vraca istinitosne vrijednosti True/False</returns>
        static bool imaNeparnih(int[] brojevi){
            foreach(int broj in brojevi)
            {
                if(broj%2!=0){return true;}   
            }
            return false;
        }
        
        static void Main(string[] args)
        {
            string ulaz;
            int[] brojevi;
            do{

                Console.WriteLine("Unesite niz od {0} brojeva,odvojite ih zarezom.Unesite q za prekid",broj_ulaza);
                ulaz=Console.ReadLine();

                if (ulaz=="q"){ return; }//prekid
            }
           while(!validirajUlaz(ulaz,out brojevi));
            string neparnihBrojeva=imaNeparnih(brojevi) ? "ima" : "nema" ;
            string brojeviPozitivni=sviPozitivni(brojevi) ? "jesu" : "nisu";

            Console.WriteLine("Brojevi u nizu "+brojeviPozitivni+" svi pozitivni");
            Console.WriteLine("U nizu "+neparnihBrojeva+" neparnih brojeva");

            Console.ReadLine();

        }
    }
}
