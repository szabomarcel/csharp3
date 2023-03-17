using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonthatOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int osztalyzat;
            Console.WriteLine("Kérem a pontszámot:");
            int pont = int.Parse(Console.ReadLine());

            if (osztalyzat > 0)
                Console.WriteLine("A kapott eredmény:{0}.", osztalyzat);
            else Console.WriteLine("Hibás az adat!");
            Console.ReadKey();
        }
    }
}
