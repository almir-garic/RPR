using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad3
{
    class Okus
    {
        string okus;
        //property
        public string Okus
        {
            get { return okus};
            set { okus=value};
        }

        public string DajOkus()
        {
           return string.Format("Okus je {0} ", Okus);
        }
    }
}
