using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0; 
            double atlag = 0;
            double szorzat = 1;
            for (int i = 0; i <=10; i++) 
            {
                sum += i;
            }
            atlag = sum / 10;
            int j = 1;
            while (j < 10)
            {
                szorzat *= j;
                j++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Számok összege");
            Console.WriteLine(sum);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Számok átlaga");
            Console.WriteLine(atlag);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Számok szorzat");
            Console.WriteLine(szorzat);
            Console.ReadKey();
        }
    }
}
