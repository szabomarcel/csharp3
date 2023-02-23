using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Adjon meg egy paramétert");
                Console.ReadKey();
                return;
            }
            int number = int.Parse(args[0]);
            Console.WriteLine(number * 2);
            Console.ReadKey();  
        }
    }
}
