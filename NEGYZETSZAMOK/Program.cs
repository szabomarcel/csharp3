using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGYZETSZAMOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Négyzetszámok 1 és 10000 között: ");
            Console.WriteLine();
            while (i * i < 10001)
            {
                Console.Write("{0}, ", i * i);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Köbszámok 1 és 10000 között: ");
            Console.WriteLine();
            i = 1;
            while(i * i * i < 10001)
            {
                Console.Write("{0}, ", i * i * i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
