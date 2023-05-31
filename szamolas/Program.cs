using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 2;
            var c = 10;

            Console.Write("Amikor + van:\n");
            Console.WriteLine(a + b + c);
            Console.Write("Amikor - van:\n");
            Console.WriteLine(a + b - c);
            Console.Write("Amikor * -s van:\n");
            Console.WriteLine(a + b * c);
            Console.Write("Amikor / -s van:\n");
            Console.WriteLine(a + b / c);
            Console.WriteLine("A meg adott számok végeredménye.");
            Console.ReadKey();
        }
    }
}
