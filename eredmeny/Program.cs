using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace eredmeny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eredmeny = 1;
            Console.Write("Kérem adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            if(a > 0)
            {
                for (int i = 0; i < a + 1; i++)
                {
                    eredmeny = eredmeny * i;
                }
                Console.WriteLine("A szám faktoriálisa: {0}", eredmeny);
            }
            Console.ReadLine();
        }
    }
}
