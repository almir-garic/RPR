using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut3PRzad1
{
    class Program
    {
      //  private static int CompareInt(int x,int y)
        //{
          //  return y - x;
        //}
        static void Main(string[] args)
        {
            int[] niz = { 10, 20, 30, 59, 43, 15, 17, 25, 35 };
            int[] temp = new int[niz.Length];
            niz.CopyTo(temp,0);
            Console.Write("Orginalni niz:");
            foreach (int i in niz)
            {
                Console.Write(i + " ");
            }
                Console.WriteLine();
                //obrnuti niz
                Array.Reverse(temp);
                Console.Write("Obrnuti niz:");
                foreach(int i in niz)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine();
                //kopirani niz
                Console.Write("Kopirani niz:");
                foreach(int i in temp)
                {
                    Console.WriteLine(i + " ");
                }
                //sortirani niz
                Array.Sort(temp);
                Console.Write("Sortirani niz: ");
                foreach(int i in niz)
                {
                    Console.Write(i + " ");
                }
                //clear niz
                Console.Write("Clear niz: ");
                foreach(int i in niz)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                //Console.Read();
                //prvi nacin 
              //  Array.Sort(niz, ((x,y)=>y-x));
            //drugi nacin 
            Array.Sort(niz, delegate (int x,int  y) { return y - x; });
                Console.Write("niz sortiran u opadajucem poretku:");
                foreach (int i in niz) Console.Write(i + " ");

            Console.Read();


            }
        }
    }

