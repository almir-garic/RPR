using System;


namespace dictionaryString
{
    class Program
    {
        /// <summary>
        /// Metoda za ispitivanje da li je rijec iz rijecnika sadrzana unutar toBeChecked rijeci
        /// </summary>
        /// <returns>vraca True/False zavisno da li je sadrzana</returns>
        bool rijecnikString(ref string TBC,string[] rijecnik1)
        {
            string[] slova=new string[]
            for (int i = 0; i < rijecnik1.Length; i++)
            {
                var slova = rijecnik1[i].Split();
            }
                return false;
        }
       
        /// <summary>
        /// Metoda za ispitivanje da li je rijec iz rijecnika sadrzana unutar toBeChecked rijeci i 
        /// da li su iskoristeni svi karakteri unutar toBeChecked,
        /// </summary>
        /// <returns>ako jesu vraca True,ako nisu tj.ima viska onda vraca False</returns>
        bool savrseniRijecnikString();
    
        static void Main(string[] args)
        {
            //broj testCase-ova
            var unos = System.Console.ReadLine().Trim();
            var testCases = Int32.Parse(unos);

            //D&S
            var unos1 = System.Console.ReadLine().Trim();
            string[] DS = unos1.Split();
            //konverzija
            var D=Int32.Parse(DS[0]);
            var S = Int32.Parse(DS[1]);

            //rijecnik
            string[] rijecnik = new string[D]; 
            //Stringovi to be checked
            string[] toBeChecked = new string[S];

            //for petlja za unos rijeci
            for (int i = 0; i < D; i++)
            {
                var rijec = System.Console.ReadLine();
                rijecnik[i] = rijec;  
            }

            //for petlja za unos stringova toBeChecked
            for (int i = 0; i < S; i++)
            {
                var rijec1 = System.Console.ReadLine();
                toBeChecked[i] = rijec1;
            }

           

            Console.ReadLine();


         
                
        }
    }
}
