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
            for (int i = 0; i < hossz; i++)
            {
                osszeg = osszeg + Convert.ToInt16(n[i]) - 48;
            }
            if (osszeg % 3 == 0)
                Console.WriteLine("A szám osztható 3-mal.");
            else Console.WriteLine("A szám nem osztható 3-mal.");
            if (osszeg % 9 == 0)
                Console.WriteLine("A szám osztható 9-cel.");
            else Console.WriteLine("A szám nem osztható 9-cel.");
            if (hossz > 1)
                if (hossz > 1)
                {
                    if ((Convert.ToInt16(n[hossz - 2] - 48) * 10 + Convert.ToInt16(n[hossz - 1]) - 48) % 4 == 0)
                        Console.WriteLine("A szám osztható 4-gyel.");
                    else Console.WriteLine("A szám nem osztható 4-gyel.");
                }
                else if ((Convert.ToInt16(n[0]) - 48) % 4 == 0)
                    Console.WriteLine("A szám osztható 4-gyel.");
                else Console.WriteLine("A szám nem osztható 4-gyel.");
            Console.ReadLine();
        }
    }
}
