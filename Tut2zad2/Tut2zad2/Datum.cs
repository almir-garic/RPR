using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tut2zad2;

namespace Tut2zad2
{
        public class Datum
        {
            int dan;
            public int Dan
            {
                get { return dan; }
                private set
                {
                    /*if (dan > 0 && dan <= 31)*/
                    dan = value;
                    /*else
                    {
                        Console.WriteLine("Ne validan dan({0}) postavi na 1.", value);
                        dan = 1;
                    }*/
                }
            }
            int mjesec;
            public int Mjesec
            {
                get { return mjesec; }
                private set
                {
                    if (value > 0 && value <= 12)
                    {
                        mjesec = value;
                    }
                    else
                    {
                        Console.WriteLine("Ne validan mjesec({0}) postavi na 1.", value);
                        mjesec = 1;

                    }

                }
            }
            int godina;
            public int Godina
            {
                get { return godina; }
                private set { godina = value; }
            }

            // konstruktor: koristi get i set za validaciju dana,godine i mjeseca
            public Datum(int dan, int mjesec, int godina)
            {
                Dan = dan;
                Mjesec = mjesec;
                Godina = godina;

            }

            public override string ToString()
            {
                return string.Format("{0}/{1}/{2}", Dan, Mjesec, Godina);
            }

        }
    }

