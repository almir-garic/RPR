using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autor : Almir Garic(almir.garic.1992@ieee.org)
/*Zadatak 3
Razviti konzolno programsko rješenje koje de omoditi evidenciju i upravljanje gasova. Postoje četiri tipa
gasova: G1, G2, G3 i G4. Svaki tip gasa ima boju (crvena, žuta, plava i zelena), okus, miris, temperaturu i
pritisak. Gasovi tipova G1 i G3 su nestabilni i potrebno je omoguditi provjeru njihove stabilnosti i
korekciju temperature. G1 je stabilan ako je temperatura manja od 100 C (Celzijus) stepeni a G3 je
stabilan ako nije crvene boje i ako je temperature manja od 150 C stepeni. Korekcija temperature za G1
tipove se vrši tako što se temperature smanji za 30 C stepeni a G3 za 50. Tipovi G1, G2 I G4 imaju
određenu dozu toksičnog djelovanja koje se mjeri pomodu toksičnosti (T). Potrebno je omoguditi
provjeru toksičnog dijelovanja tako što za svaki od toksičnih gasova mjeri da li je u granicama normale
(G1 između 10T – 50T, G2 između 30T-80T i G4 između 20-50T). Potrebno je omoguditi odabir svih
gasova, toksičnih gasova ili nestabilnih gasova. U slučaju odabira svih gasova ispisuju se osnovni podaci o
svim gasovima. Odabirom toksičnih ispisuju se samo toksični i pored osnovnih ispisuje se i informacija o
njihovoj toksičnosti. Odabirom nestabilnih ispisuju se samo nestabilni i pored osnovnih ispisuje se i
informacija o stanju stabilonsti pri čemu se daje opcija korisniku da odabere gas čija de se korekcija
obaviti ili da se upiše slovo “b” čime de se vratiti na prvi odabir gasova. Izvršiti dekompoziciju klasa i
primijentiti polimorfizam. Prije odabira kontrole gasova omoguditi unos n gasova.
*/
namespace Tut2zad3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
