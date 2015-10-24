using System;

//Autor: Almir Garic (almir.garic.1992@ieee.org)
namespace Tut1SRzad1
{
    /// <summary>
    /// Klasa Program
    /// </summary>
    class Program
    {
        const float koeficijentMetara = 1.852F;//jedan cvor je 1.852 km/h https://en.wikipedia.org/wiki/Knot_(unit)

        /// <summary>
        /// Main metoda
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            

            Console.WriteLine("Unesi brzinu broda u cvorovima");

            //pretvara string vrijednost unesenog broja u njegov 32bitni ekvivalent
            var brzinaBroda_u_cvorovima = Int32.Parse(Console.ReadLine());

            //pretvara u decimalni broj 
            decimal brzinaBroda_u_metrima=Convert.ToDecimal(brzinaBroda_u_cvorovima*koeficijentMetara);
 
            //za potrebe testiranja programa unosimo 20 cvorova=37.04 km/h
            Console.WriteLine("Konvertova brzina broda je " + brzinaBroda_u_metrima+"km/h");

            //Zaustavlja konzolni prozor
            Console.ReadLine();
        }
    }
}
