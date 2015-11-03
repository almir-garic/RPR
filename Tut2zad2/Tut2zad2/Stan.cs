using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2zad2
{
    
    


        /// <summary>
        /// abstraktna klasa Stan
        /// </summary>
        abstract class Stan : IStan
        {
            // atributi abstraktne klase sa njihovih osobinama
            int brojKvadrata;

            public int BrojKvadrata
            {
                get { return brojKvadrata; }
                set { brojKvadrata = value; }
            }
            Lokacija lokacija;

            public Lokacija Lokacija
            {
                get { return lokacija; }
                set { lokacija = value; }
            }
            bool imaInternetKonekcije;

            public bool ImaInternetKonekcije
            {
                get { return imaInternetKonekcije; }
                set { imaInternetKonekcije = value; }
            }

            //abstraktne metode klase Stan
            public abstract void Ispisi();
            public abstract double ObracunajCijenuNajma();

        }
    
}
