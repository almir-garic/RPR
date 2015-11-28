using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace primjerLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>(); // instancira se nova lista
          //  stringova kapaciteta 0
        DodavanjeElemenata(rijeci);
            UbacivanjeElemenata(rijeci);
            BrisanjeElemenata(rijeci);
            Console.Read();
        }
        static void DodavanjeElemenata(List<string> rijeci)
        {
            rijeci.Add("test");
            rijeci.Add("asdf");
            // string dvijeRijeci = new string[] { "predzadnja", "zadnja" };
            rijeci.AddRange(new string[] { "predzadnja", "zadnja" }); // na kraj liste se
          //  dodaju dvije riječi
        // Iteracija kroz listu pomoću foreach petlje
 foreach (string s in rijeci)
                Console.Write(s + (rijeci.Last().Equals(s) ? Environment.NewLine : ", "));
        }
        static void UbacivanjeElemenata(List<string> rijeci)
        {
            rijeci.Insert(0, "prva"); // nova riječ se ubacuje na prvu poziciju (indeks 0)
            rijeci.InsertRange(1, new string[] { "druga", "treća" }); // dvije riječi se
         //   dodaju na drugu poziciju
        // Iteracija unazad pomoću for petlje
 for (int i = rijeci.Count - 1; i >= 0; i--)
                Console.Write(rijeci[i] + (rijeci.First().Equals(rijeci[i]) ?
               Environment.NewLine : ", "));
        }
        static void BrisanjeElemenata(List<string> rijeci)
        {
            rijeci.Remove("prva"); // brisanje elementa 'prva' iz liste
            rijeci.RemoveRange(0, 2); // brisanje prva dva elementa iz liste
            foreach (string s in rijeci)
                Console.Write(s + (rijeci.Last().Equals(s) ? Environment.NewLine : ", "));
            rijeci.Clear(); // brisanje svih elemenata iz liste
            Console.WriteLine("Ukupno elemenata u listi: " + rijeci.Count);
        }
    }
}
