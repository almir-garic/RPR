using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad3
{
    class Temperatura
    {
        float temperatura;
        //property
        public float Temperatura
        {
            get { retun temperatura; }
            set { temperatura = value; }
        }

        public string DajTemperaturu()
        {
            return string.Format("Temperatura je {0}", Temperatura);
        }
    }
}
