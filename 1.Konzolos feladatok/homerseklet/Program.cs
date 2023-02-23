using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy hőmérséklet értékét:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Válassz opciót: (1) C∘ --> F∘ (2) F∘ --> C∘ : ");
            byte c = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (c) 
            {
                case 1:
                    Console.WriteLine("{0} F∘ = {1} C∘", n, (n -32) * 5 / 9);break;
                case 2: 
                    Console.WriteLine("{0} C∘ = {1} F∘", n, (n * 9 / 5) + 32); break;
            }
            Console.ReadKey();

        }
    }
}
