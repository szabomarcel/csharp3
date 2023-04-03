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

            Console.WriteLine("A tört számláló:"); // Számláló bekérés
            Console.Write(Console.ReadLine());
            Console.WriteLine("A tört nevező:"); // Nevező bekérés
            Console.Write(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Az egyszerűsített tört számlálója: ", tort.a); // Számláló törté kiszámítása
            Console.Write(Console.ReadLine());
            Console.WriteLine("Az egyszerűsített tört nevezője: ", tort.b); // Nevező törté számolása
            Console.Write(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
