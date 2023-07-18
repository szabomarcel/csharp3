using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApolication7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a prógram ki számitja a négyzet kerületétt és területétt.");
            Console.Clear();
            Console.Write("Add meg a számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A négyzet kerülete: {0}\nA négyzet területe: {1}", szam * 4, szam * szam);
            Console.ReadLine();
        }
    }
}
