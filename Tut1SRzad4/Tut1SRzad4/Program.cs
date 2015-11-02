using System;

// Autor : Almir Garic (almir.garic.1992@ieee.org)
/*Zadatak 4
Napišite program koji traži da se sa tastature unese prirodan broj n, a nakon toga se unose elementi
kvadratne matrice formata n×n. 
Program nakon toga treba da ispiše redni broj kolone sa najvećom sumom elemenata, redni broj reda sa
najmanjom sumom elemenata, kao i sumu elemenata na dijagonali. Koristiti jagged ili
multidimenzionalni niz.
Reference:
Jagged nizovi: http://msdn.microsoft.com/en-us/library/vstudio/2s05feca.aspx
Multidimenzionalni nizovi: http://msdn.microsoft.com/en-us/library/vstudio/2yd9wwz4.aspx
Metode klase string: http://msdn.microsoft.com/en-us/library/system.string_methods(v=vs.110).aspx*/

namespace Tut1SRzad4
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Unesite prirodan broj n ");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);

           
            //A jagged array is an array whose elements are arrays

            //deklaracija matrice
            int[][] matrica = new int[n][];
            for(int i=0;i< n; i++)
            {
                matrica[i] = new int[n];
            }
            //inicijalizacija elemenata na nulu
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    matrica[i][j] = 0;
                }
            }

            //inicijalizacija matrice
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine("Unesi a{0}{0} clan matrice",i+1,j+1);
                    
                    matrica [i][j] =Int32.Parse(Console.ReadLine());
                }
            }

           

            
            // 
            // Console.WriteLine("Redni broj kolone sa max clanovima je : "+ redniBrojKoloneSaMaxSumomElemenata);
            // Console.WriteLine("Redni Broj Kolone sa Min Sumom Elemenata je : " + redniBrojKoloneSaMinSumomElemenata);
            // Console.WriteLine("Suma Dijagonalih elemenata je : " + sumaDijagonalnihElemenata);

            Console.ReadLine();
        }
    }
}




