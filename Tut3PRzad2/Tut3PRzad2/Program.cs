using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut3PRzad2
{
   
    class Program
    {

        static void DodavanjeElemenanta(List<string> rijeci)
        {
            rijeci.Add("test");
            rijeci.Add("asdf");
            //string dvijeRijeci=new string[]{"predznanja","zadnja"};
            rijeci.AddRange(new string[] { "predznanja", "zadnja" });//na kraj liste se dodaju dvije rijeci
                                                                     //iteracije kroz listu pomocu for each petlje 
            foreach (string s in rijeci)
            {
                Console.WriteLine(s + (rijeci.Last().Equals(s) ? Environment.NewLine : ", "));
                rijeci.Clear();//brisanje svih rijeci iz liste rijeci
                Console.WriteLine("Ukupno elemenata u listi : " + rijeci.Count);
            }
        }

        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>();//instancira se nova lista stringova
            DodavanjeElemenanta(rijeci);            
        }
    }
}
