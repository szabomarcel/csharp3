using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace run
{
    internal class Program
    {
        static void Main(string[] tomb)
        {
            if (tomb.Length != 0)
            {
                Console.WriteLine("Ezt a paramétert kaptam: {0}", tomb[0]);
            }
            else { Console.WriteLine("Nincs megadva a paraméter"); }
            Console.ReadKey();
        }
    }
}
