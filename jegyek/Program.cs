using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace jegyek
{
    class osztalyzat
    {
        static void Main(string[] args)
        {
            Console.Write("A dolgozatod eredménye (számmal): ");
            string osztalyzat = Console.ReadLine();
            Console.WriteLine("\nSzüleid véleménye:\n");
            switch (osztalyzat)
            {
                case "1":
                    Console.WriteLine("Megmondtam, hogy ez lesz a vége, ha csak játékra használod a számítógépet!!!");
                    Console.WriteLine("Büntetés: Egy hétig nincs se TV, se Internet!");
                    break;
                case "2":
                    Console.WriteLine("Megmondtam, hogy olvasd mág át legalább egyszer lefekvés előtt!!!");
                    Console.WriteLine("Büntetés: Ma este nincs se TV, se Internet! Alvás és kész.");
                    break;
                case "3":
                    Console.WriteLine("Ha egy kicsit többet gyakorolnál, akkor még jobb is lehetne!");
                    break;
                case "4":
                    Console.WriteLine("Szép - szép, de ugye évvégétr kijavítid ötösre?!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
