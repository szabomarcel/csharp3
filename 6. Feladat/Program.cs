using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("MI van?");
                string a = Console.ReadLine();
                while (a[a.Length - 1] != "?")
                {
                    Console.WriteLine("Nem kérdés, újra");
                }
                Random r = new Random();
                int a1 = r.Next(0, 2);
                if (a1 == 0)
                {
                    Console.WriteLine("Igen");
                }
                else if (a1 == 1)
                {
                    Console.WriteLine("Nem");
                }
                Console.ReadKey();
            }
        }
    }
}
