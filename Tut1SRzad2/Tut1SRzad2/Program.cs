using System;

//Autor : Almir Garic(almir.garic.1992@ieee.org)


namespace Tut1SRzad2
{
    /// <summary>
    /// Klasa Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main metoda
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //rjesenje preuzeto sa http://stackoverflow.com/questions/5037012/making-pyramid-using-c-sharp
            //modifikovano za proizvoljan unos

            

            Console.WriteLine("Unesi broj n za ispis piramide");

            //pozivam sistemsku metodu da odmah pretvori unesenu string vrijednost broja
            //u njegovo ekvivalentu 32bitnu int vrijednost
            
            var n = Convert.ToInt32(Console.ReadLine());

            //matrica piramide

            //1.petlja
            for(int i=1;i<=n;i++)
            {

                // j treba da ide do neparnog 2*n-1-i+1,zadnja jedinica zato sto krecemo od j=1,
                // a ne od int j=0
                for(int j=1;j<=2*n-i;j++)
                {
                    Console.Write(" ");
                    
                }

                // k treba da ide do neparnog broja 
                for(int k=1;k<=2*i-1;k++)
                {
                    Console.Write("*");
                  
                    
                }
                Console.WriteLine();
                
            }

            //zaustavi konzolu
            Console.ReadLine();
         }
    }
}
