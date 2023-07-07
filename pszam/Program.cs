using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.Write("Add meg a k pozitiív számot: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                s = s + i * (i + 1);
            }
            Console.WriteLine("Osszeg: {0}",s);
            Console.ReadLine();
        }
    }
}
