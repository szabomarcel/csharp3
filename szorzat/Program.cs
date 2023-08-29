using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szorzat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a szorzat tényezői 1 - 1000 között egész számokat");
            Console.Write("\n1. tényező: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\n2. tényező: ");
            int b = int.Parse(Console.ReadLine());
            int szorozat = 0;
            for (int i = 0; i <=b; i++)
            {
                szorozat = szorozat + a;
            }
            Console.Write("\nSzorzatuk: {0}", szorozat); 
            Console.ReadLine();
        }
    }
}
