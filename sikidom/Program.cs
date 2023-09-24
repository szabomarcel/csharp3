using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidoms = new List<Sikidom>();
            sikidoms.Add(new Haromszog(120));
            sikidoms.Add(new Trapez(100));
            sikidoms.Add(new Paralelogramma(112));
            foreach (var item in sikidoms)
            {
                Console.WriteLine($"Területe: {item.Terulet()} - Kerülete: {item.Kerulet()}");
            }
            Console.ReadLine();
        }
    }
}
