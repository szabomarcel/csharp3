using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atvalt atvalt = new Atvalt();
            atvalt.bitsor = 0;
            atvalt.osszeg = 0;
            atvalt.hatvany = 2;
            Console.Write("Bitsorozat : ", atvalt.bitsor);
            Console.WriteLine("Az átváltás eredménye : {0}");
            Console.ReadKey();
        }
    }
}
