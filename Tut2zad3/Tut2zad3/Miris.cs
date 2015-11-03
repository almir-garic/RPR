using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad3
{
    class Miris
    {
        string miris;
        //property
        public string Miris
        {
            get { return miris; }
            set { miris = value; }
        }

        public string DajMiris()
        {
            return string.Format("Miris je {0} ", Miris);
        }
    }
}
