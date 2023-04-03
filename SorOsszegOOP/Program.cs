using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorOsszegOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SorOsszeg sorOsszeg = new SorOsszeg();
            sorOsszeg.s = 0;
            sorOsszeg.k = 0;
            sorOsszeg.osszeg = 0;
            sorOsszeg.szam = "0";

            Console.WriteLine("Kérek egy számot");          
            Console.WriteLine("Add neg a k pozítiv számot:");
            Console.WriteLine("Összeg: {0}");
            Console.WriteLine("A számjegyek osszege: {0}.");
            Console.ReadLine();
        }
    }
}
