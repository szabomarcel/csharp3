using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koordinata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Első x koordinata:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Első y koordinata:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Második x koordinata:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Második x koordinata:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double tavolsag = Math.Sqrt((x1-x2)*(x1-x2)*(y2-y1)*(y2-y1));
            Console.Write("Távolsag: {0}", tavolsag);
            Console.ReadLine();
        }
    }
}
