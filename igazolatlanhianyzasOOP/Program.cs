using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igazolatlanhianyzasOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hiányzások: ");
            hianyzasok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hianyzasok);
            if (hianyzasok >= 10)
            {
                Console.WriteLine("Add meg a születési dátumodat(yyyy/mm/dd)");
                DateTime datum;
                datum = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(hianyzasok);

                Console.ReadKey();
            }
        }
    }
}
