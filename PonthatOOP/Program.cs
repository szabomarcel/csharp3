using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PonthatOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pont = 0;
            Console.WriteLine("Kérem a pontszámot:");
            pont = int.Parse(Console.ReadLine());

            if (pont > 0 && pont <= 100)
            {
                PontHat p1 = new PontHat(pont);
                p1.szamitas();
                Console.WriteLine("A kapott eredmény:{0}.", p1.getOsztalyzat());
            }
            else Console.WriteLine("Hibás az adat!");
            Console.ReadKey();
        }
    }
}
