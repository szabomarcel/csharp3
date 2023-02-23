using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viz_goz_jeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a viz hőmérsékletét:");
            Console.Write("Hőmérséklet: "):
            double t = Convert.ToDouble(Console.ReadLine());

            if (t > 0)
            {
                if (t >= 100) Console.WriteLine("Goz!");
                else Console.WriteLine("Víz!");
            }
            else Console.WriteLine("Jeg!");
        }
    }
}
