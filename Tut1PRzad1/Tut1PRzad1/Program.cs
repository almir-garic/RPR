using System;

/*Primjer1 Tutorijal1
 * 
 * Postavka zadatka:
 * 
 * Napisati program koji traži da se sa tastature unese 6 brojeva, a koji zatim ispisuje da li su svi uneseni
brojevi pozitivni i da li među njima ima neparnih brojeva. Primjeri ulaza:
o 2, 6, 10, 18, 8, 6
o 4, –12, 10, 18, –18, 10
o 3, 5, 4, 19, 7, 12
o –3, 9, 15, –7, 13, 11
 */


namespace Tut1PRzad1
{
    //Autor : Almir Garic (almir.garic.1992@ieee.org)  
    // preuzeto sa http://pastebin.com/dVZAhcSF
    class Program
    {
        const int broj_ulaza = 6;

        /// <summary>
        /// metoda za ispitivanje ulaza
        /// </summary>
        /// <param name="ulaz">string ulaza</param>
        /// <param name="brojevi">referenca (neinicijalizirana) na niz brojeva</param>
        /// <returns></returns>
        static bool validirajUlaz(string ulaz, out int[] brojevi)
        {
            brojevi = new int[broj_ulaza];
            string[] ulazi = ulaz.Split(',');

            if (ulazi.Length - broj_ulaza != 0) { return false; }

            for (int i = 0; i < ulazi.Length; i++)
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
        /// <summary>
        /// Metoda ispituje da li su u zadanom nizu svi pozitivni brojevi
        /// </summary>
        /// <param name="brojevi">zahtjeva cjelobrojni niz kao parametar</param>
        /// <returns>vraca istinitosnu vrijednost True/False</returns>
        static bool sviPozitivni(int[] brojevi)
        {

            foreach (int broj in brojevi)
            {
                if (broj <= 0) { return false; }
            }
            return true;
        }
        /// <summary>
        /// Metoda ispituje da li u zadanom nizu postoji neparnih brojeva
        /// </summary>
        /// <param name="brojevi">zahtjeva cjelobrojni niz kao parametar</param>
        /// <returns>vraca istinitosne vrijednosti True/False</returns>
        static bool imaNeparnih(int[] brojevi)
        {
            foreach (int broj in brojevi)
            {
                if (broj % 2 != 0) { return true; }
            }
            return false;
        }

        static void Main(string[] args)
        {
            string ulaz;
            int[] brojevi;
            do
            {

                Console.WriteLine("Unesite niz od {0} brojeva,odvojite ih zarezom.Unesite q za prekid", broj_ulaza);
                ulaz = Console.ReadLine();

                if (ulaz == "q") { return; }//prekid
            }
            while (!validirajUlaz(ulaz, out brojevi));
            string neparnihBrojeva = imaNeparnih(brojevi) ? "ima" : "nema";
            string brojeviPozitivni = sviPozitivni(brojevi) ? "jesu" : "nisu";

            Console.WriteLine("Brojevi u nizu " + brojeviPozitivni + " svi pozitivni");
            Console.WriteLine("U nizu " + neparnihBrojeva + " neparnih brojeva");

            Console.ReadLine();

        }
    }
}