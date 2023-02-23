using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreProst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10,
            b = 20,
            c = 30,
            d = 40;

            Console.WriteLine("a++ = {0}", a++); // 10 
            Console.WriteLine("++a = {0}", ++a); // 12
            
            Console.WriteLine("b-- = {0}", b--); // 20
            Console.WriteLine("--b = {0}", --b); // 18
            Console.ReadKey();
        }
    }
}
