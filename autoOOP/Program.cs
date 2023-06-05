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
            sorOsszeg.k = 0;
            sorOsszeg.osszeg = 0;
            sorOsszeg.szam = "0";

            Console.WriteLine("A megadott márka: ", kiir.marka());
            Console.WriteLine("Add neg a k pozítiv számot:", sorOsszeg.k);
            Console.WriteLine("Összeg: {0}", sorOsszeg.osszeg);
            Console.WriteLine("A számjegyek osszege: {0}.", sorOsszeg.s);
            Console.ReadLine();
        }
    }
}
