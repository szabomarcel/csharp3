using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace km_t_szamitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, km;
            Console.Write("Innen indulok: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ide érkezem: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Itt lesznek mindkét oldalon a fák: ");
            if(a < b)
            {
                km = a;
                for (i = 0; i <= (b - a); i++) 
                {
                    if ((km % 5 == 0) && ((km % 3 == 0)))
                    {
                        Console.WriteLine("{0}, ", km);
                    }
                    km++;
                }
            }
            else
            {
                km = b;
                for (i = 0; i <= (a - b); i++)
                {
                    if ((km % 5 == 0) && ((km % 3 == 0)))
                    {
                        Console.WriteLine("{0} , ", km);
                    }
                    km++;
                }
            }
            Console.ReadLine();
        }
    }
}
