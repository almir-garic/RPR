using System;

//Autor: Almir Garic (almir.garic.1992@ieee.org)

/*
 Zadatak 3
Napišite program koji traži da se sa tastature unese broj n, a nakon toga n elemenata niza tipa int.
Potrebno je iz glavnog programa pozvati funkciju private static void bubbleSortNiz(int[] arr) koja sortira
i ispisuje u glavnom programu uneseni niz cijelih brojeva. Nakon poziva ove funkcije pozvati funkciju
private static void izbaciElementNiza(int[] arr, int element) koja iz originalnog niza izbacuje element
proslijeđen kao parametar, i ispisuje niz bez elementa. Nakon poziva ove funkcije ispisati originalni niz.
 
 *referenca: https://en.wikipedia.org/wiki/Bubble_sort#Pseudocode_implementation
 */

namespace Tut1SRzad3
{
    /// <summary>
    /// Klasa Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <param name="arr">niz koji se sortira</param>
        private static void bubbleSortNiz(int[] arr)
        {
            // preuzeto sa http://stackoverflow.com/questions/14768010/simple-bubble-sort-c-sharp

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            //ispis niza
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        /// <summary>
        ///  iz originalnog niza izbacuje element proslijeđen kao parametar
        ///  i ispisuje niz bez elementa
        /// </summary>
        /// <param name="arr">niz iz kojeg se izbacuje element</param>
        /// <param name="element">element koji se izbacuje iz niza</param>
        private static void izbaciElementNiza(int[] arr, int element)
        {

            
            }
        }
        
        static void Main(string[] args)
        {
            
            //unosimo broj n
            Console.WriteLine("Unesite broj n");
            var n = Int32.Parse(Console.ReadLine());

            //alociramo niz od n brojeva
            int[] niz = new int[n];
            Console.WriteLine("Unesite n elemenata u niz");

            //unosimo string brojeva razdvojenih zarezom
            string ulaz = Console.ReadLine();
            string[] Niz=ulaz.Split(',');

            //konvertujemo svaki zaseban string u njegovu 32bitnu vrijednost 
            //i dodjeljujemo int niz
            for (int i = 0; i < Niz.Length; i++)
            {
                niz[i] = Convert.ToInt32(Niz[i]);
            }

            
            Console.ReadLine();

        }
    }
}
