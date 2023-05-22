using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozatOOP
{
    internal class Program : auto
    {
        private static auto Namecar;
        private static auto rendszam;
        private static auto uzemanyag;
        private static auto gyartasiev;
        private static auto szin;
        private static auto abroncsok;
        private static auto ajtoszam;
        private static auto ulohely;
        static void Main(string[] args) // Statikus Main
        {
            Namecar = new auto();
            Namecar.autonev();
            kereses(uj[0]);

            rendszam = new auto();
            rendszam.rendszam();
            kereses(uj[0]);

            gyartasiev = new auto();
            gyartasiev.gyartas();
            kereses(uj[0]);

            uzemanyag = new auto();
            uzemanyag.uzemAnyag();
            kereses(uj[0]);

            szin = new auto();
            szin.szin();
            kereses(uj[0]);

            abroncsok = new auto();
            abroncsok.abroncsmeret();
            kereses(uj[0]);

            ajtoszam = new auto();
            ajtoszam.ajtokszama();
            kereses(uj[0]);

            ulohely = new auto();
            ulohely.ajtokszama();
            kereses(uj[0]);
        }
        private static void kereses(string uj) // Visszatérési érték
        {
            if (Namecar.autonev(uj))
            {
                Console.WriteLine("Léteszik ilyen autó.");
            }
            else
            {
                Console.WriteLine("Még nincs ilyen autó.");
            }
        }
    }
}
