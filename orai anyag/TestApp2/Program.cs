using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            if (args.Length == 0) 
            { 
                Random r = new Random();
                number = r.Next(100);
            }
            else 
            { 
                number = int.Parse(args[0]);
            }
           
            for( int i = 1;i < number; i++ ) 
            {
                Console.WriteLine("{0} × {1} = {2}", i, number, i * number);
            }
            Console.ReadKey();
        }
    }
}
