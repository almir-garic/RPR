using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace primjerArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList Lista = new System.Collections.ArrayList();
            Lista.Add("beast");
            Lista.Add(666);
            Lista.Add("Eddie");
            Lista.Add(0.11);
            Lista.Add('c');

            foreach(object o in Lista) { Console.WriteLine(o); }
            Console.ReadLine();
        }
    }
}
