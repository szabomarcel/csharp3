using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be egy szöveg: ");
            string a = Console.ReadLine();
            while(a.Length > 10)
            {
                Console.WriteLine("Nem jó. Írd be még egyszer!");
                a = Console.ReadLine();
            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
