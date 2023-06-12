using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoOOP
{
    internal class Program : Autok
    {
        static void Main(string[] args)
        {
            Autok kiir = new Autok();
            kiir.marka();
            kiir.rendszam();
            kiir.gyartasev();
            kiir.uzemanyag();
            kiir.szin();
            kiir.abroncsmeret();
            kiir.kilometerallas();
            kiir.ajtokszama();
            kiir.szemelyszam();
            kiir.kinezet();
            Console.ReadLine();
        }
    }
}
