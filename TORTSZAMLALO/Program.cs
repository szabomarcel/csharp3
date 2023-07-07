using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TORTSZAMLALO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A tört számlálója: ");
            int a = int.Parse(Console.ReadLine());
            int x = a;
            Console.Write("A tört számlálója: ");
            int b = int.Parse(Console.ReadLine());
            int y = b;
            while(a != 0 && b != 0)
            {
                if (a > b)
                    a = a - b;
                else b = b - a;
            }
            int lnko = Math.Max(a, b); 
            Console.WriteLine();
            Console.WriteLine("Az egyszerűsített tört számlálója: {0}", x / lnko);
            Console.WriteLine("Az egyszerűsített tört Nevezője: {0}", y / lnko);
            Console.WriteLine();
        }
    }
}
