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
        private static auto kinezetek;
        static void Main(string[] args) // Statikus Main
        {
            Namecar = new auto();
            autonev();

            rendszam = new auto();
            rendszam();

            gyartasiev = new auto();
            gyartas();

            uzemanyag = new auto();
            uzemAnyag();

            szin = new auto();
            szin();

            abroncsok = new auto();
            abroncsmeret();

            ajtoszam = new auto();
            ajtokszama();

            ulohely = new auto();
            ajtokszama();

            kinezetek = new auto();
            kinezetek();
        }        
    }
}
