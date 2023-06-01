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
            var a = 30;
            var b = 5;
            var c = 15;
            var d = 4;
            var e = 3;

            Console.Write("Amikor összeadás van:\t");
            Console.WriteLine(a + b + c);
            Console.Write("Amikor kívonás van:\t");
            Console.WriteLine(a + b - c);
            Console.Write("Amikor szirzás is van:\t");
            Console.WriteLine(a + b * c);
            Console.Write("Amikor osztás is van:\t");
            Console.WriteLine(a + b / c);
            Console.Write("Amikor kiszámolás oldunk meg:\t");
            Console.WriteLine(a / b * (c - d * e);
            Console.WriteLine("A meg adott számok végeredménye.");
            Console.ReadKey();
        }
    }
}
