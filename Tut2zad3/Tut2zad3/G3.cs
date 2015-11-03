using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad3
{
    class G3:TipGasa
    {
        TipBoje boja;

        //property
        public TipBoje Boja
        {
            get { return boja; }
            get { boja = ValueType; }
        }
}
