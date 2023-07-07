using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitsorozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitsorozat: "); // Bekérés a személytől az adott szöveget vagy számot.
            string bitsor = Console.ReadLine(); // Szöveg változó átalakitása
            double osszeg = 0; // 8 bites szám váltázó
            double hatvany = 2; // 8 bites szám váltázó
            for (int i = 0; i < bitsor.Length; i++)
            {
                hatvany = Math.Pow(2, bitsor.Length - i - 1);
                string szamjegy = bitsor.Substring(i, 1);
                osszeg += int.Parse(szamjegy) * hatvany;
            }
            Console.WriteLine("Az átváltás eredménye: {0}", osszeg);
            Console.ReadLine();
        }
    }
}
