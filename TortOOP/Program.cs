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
            Console.WriteLine("A tört számláló:");
            Console.Write(Console.ReadLine());
            Console.WriteLine("A tört nevező:");
            Console.Write(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Az egyszerűsített tört számlálója: ");
            Console.Write(Console.ReadLine());
            Console.WriteLine("Az egyszerűsített tört nevezője: ");
            Console.Write(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
