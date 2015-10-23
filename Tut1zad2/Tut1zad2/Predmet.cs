using System;


namespace Tut1zad2
{



    /// <summary>
    /// Javna klasa Predmet
    /// </summary>
    public class Predmet : Osoba
    {
        string nazivPredmeta;
        Osoba profesor;
        int brojStudenata;

        public Predmet(string parametar_nazivPredmeta, string parametar_ime, int parametar_brojStudenata)
        {
            NazivPredmeta = parametar_nazivPredmeta;
            Ime = parametar_ime;//nasljedjeni privatni atribut ime iz klase osoba,dodjeluje se child klasi Predmet
            BrojStudenata = parametar_brojStudenata;
        }

        /// <summary>
        /// property-get i set za nazivPredmeta
        /// </summary>
        public string NazivPredmeta
        {
            get
            {
                return nazivPredmeta;
            }
            set
            {
                nazivPredmeta = value;
            }
        }

        /// <summary>
        /// property-get i set za brojStudenata
        /// </summary>
        public int BrojStudenata
        {
            get
            {
                return brojStudenata;
            }
            set
            {
                brojStudenata = value;
            }
        }

    }
}
