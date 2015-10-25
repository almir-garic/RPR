using System;


namespace Threesome_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            //int counter = 0;
            var line1 = System.Console.ReadLine().Trim();
            string[] niz = line1.Split();
            
            
            a=Int32.Parse(niz[0]);
            b=Int32.Parse(niz[1]);
            c=Int32.Parse(niz[2]);



          /*  while (a != 0 || b != 0 || c != 0)
            {

                if (a <= b)
                {
                    b = b - a;
                    a += a;
                    
                }
                else if (a <= c)
                {
                    c = c - a;
                    a += a;
                    
                    
                }
                else if (b <= c)
                {
                    c = c - b;
                    b += b;
                    

                }
                else if (b <= a)
                {
                    a = a - b;
                    b += b;
                    

                }
                else if (c <= a)
                {
                    a = a - c;
                    c += c;
                    
                }
                else if (c <= b)
                {
                    b = b - c;
                    c += c;
                    
                }
                counter++;
            }


            Console.Write(counter);*/

       
        }
    }

}
