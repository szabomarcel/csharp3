using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamokbekereseOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            string n = Console.ReadLine();
            Console.WriteLine();
            int hossz = n.Length;
            int osszeg = 0;
            
            Console.WriteLine("A szám osztható 3-mal.");
            Console.WriteLine("A szám nem osztható 3-mal.");
            
            Console.WriteLine("A szám osztható 9-cel.");
            Console.WriteLine("A szám nem osztható 9-cel.");
            
                    
            Console.WriteLine("A szám osztható 4-gyel.");
            Console.WriteLine("A szám nem osztható 4-gyel.");
            
            Console.WriteLine("A szám osztható 4-gyel.");
            Console.WriteLine("A szám nem osztható 4-gyel.");
            Console.ReadLine();
        }
    }
}
