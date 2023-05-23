using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Feladat
{
    internal class Program
    {
        static void szamol(int a)
        {
            Console.WriteLine(a);
            if(a <= 40)
            {
                a += 2;
                szamol(a);
            }
        }
        static void Main(string[] args)
        {
            szamol(2);
            Console.ReadKey();
        }
    }
}
