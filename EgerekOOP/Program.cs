using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgerekOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Egerek eger = new Egerek();
            eger.L = 0;
            eger.V = 0;
            eger.T = 0;
            eger.U = 0;

            Console.WriteLine("Írd be az első pontot:", eger.L);
            Console.Write(Console.ReadLine());
            Console.WriteLine("Írd be a második pontot:", eger.V);
            Console.Write(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
