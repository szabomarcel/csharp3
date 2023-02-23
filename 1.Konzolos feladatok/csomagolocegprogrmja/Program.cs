using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csomagolocegprogrmja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dinnyek_atmeroje(cm):!");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine();         
            Console.WriteLine("Dinnyek szama!");
            int N = int.Parse(Console.ReadLine());
            double szalag = ((2 * d * Math.PI) + 60) * N;
            Console.WriteLine();
            Console.WriteLine("A szükséges szalag {0:0.00}", szalag);
            Console.ReadLine();
        }
    }
}
