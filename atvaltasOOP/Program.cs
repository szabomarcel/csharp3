using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvaltasOOP
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
            Console.ReadKey();
        }
    }
}
