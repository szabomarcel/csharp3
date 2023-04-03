using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortOOP
{
    internal class Program : Tort
    {
        static void Main(string[] args)
        {
            Tort tort = new Tort();
            tort.a = 0;
            tort.b = 0;
            tort.y = 0;
            tort.x = 0;

            Console.WriteLine("A tört számláló:", tort.a);
            Console.Write(Console.ReadLine());
            Console.WriteLine("A tört nevező:", tort.b);
            Console.Write(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Az egyszerűsített tört számlálója: ", tort.y);
            Console.Write(Console.ReadLine());
            Console.WriteLine("Az egyszerűsített tört nevezője: ", tort.x);
            Console.Write(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
