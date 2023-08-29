using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace eletkoros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 0;
            bool a_ertek_helyes_e = false;
            bool b_ertek_helyes_e = false;
            while(a_ertek_helyes_e != true)
            {
                Console.Write("Kérem adjon meg egy számot: ");
                a = int.Parse(Console.ReadLine());
                if (a >= 10 && a <= 90) a_ertek_helyes_e = true;
            }
            while (b_ertek_helyes_e != true)
            {
                Console.Write("Kérem adjon meg még egy számot: ");
                b = int.Parse(Console.ReadLine());
                if (b >= 10 && b <= 90) b_ertek_helyes_e = true;
            }
            if(a > b)
            {
                int x = a - b;
                if(x < 18 || x > 50)
                {
                    Console.WriteLine("Az apa {0} éves volt amikor a fiú megszületett, bár ez nehezen hihető.", x);
                }
                else
                {
                    Console.WriteLine("Az apa {0} éves volt amikor a fiú megszületett.", x);
                }
            }
            else
            {
                int x = b - a;
                if (x < 18 || x > 50)
                {
                    Console.WriteLine("Az apa {0} éves volt amikor a fiú megszületett, bár ez nehezen hihető.", x);
                }
                else
                {
                    Console.WriteLine("Az apa {0} éves volt amikor a fiú megszületett.", x);
                }
            }
            Console.ReadLine(); 
        }
    }
}
