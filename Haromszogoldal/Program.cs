using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogoldal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Háromszög 'a' oldala: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Háromszög 'b' oldala: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Háromszög 'c' oldala: ");
            int c = int.Parse(Console.ReadLine());
            double s = (a + b + c) / 2;
            if (a == b && a == c && c == b)
            {
                Console.WriteLine("Egyenlő oldalú.");
            }
            else if (a == b || a == c || c == b)
            {
                Console.WriteLine("Egyenlő szárú.");
            }
            else Console.WriteLine("Nem egyenlő oldalú és nem is egyenlő szárú.");
            Console.WriteLine("A háromszög kerülete: {0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            Console.ReadLine();
        }
    }
}
