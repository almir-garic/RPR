using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad3
{
    class Pritisak
    {
        float pritisak;
        //property
        public float Pritisak
        {
            get { return pritisak; }
            set { pritisak = value; }
        }

        public string DajPritisak()
        {
            return string.Format( "Pritisak je {0:2} [Pa]",Pritisak);
        }

    }
}
