using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husvetifeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg az idei év húsvét napját: ");
            double T = int.Parse(Console.ReadLine());
            double A = T % 19;
            double B = T % 4; 
            double C = T % 7;
            double D = (19 * A + 24) % 30;
            double E = (2 * B + 4 * C + 6 * D + 5) % 7;

            double H = 22 + D + E;
            if(E == 6 && D == 29)
            {
                H = 50;
            }
            else if (E == 6 && D == 28 && A > 10)
            {
                H = 49;
            }

            double P = H + 49 - 30 - 30;
            if (H < 30)
            {
                Console.WriteLine("Húsvét vasárnap: március "+ H    +".");
            }
            else
            {
                Console.WriteLine("Húsvét vasárnap: március " + (H-31) + ".");
            }
            if (P < 30)
            {
                Console.WriteLine("Húsvét vasárnap: március " + P    + ".");
            }
            else
            {
                Console.WriteLine("Húsvét vasárnap: március " + (P - 31) + ".");
            }
        }
    }
}
