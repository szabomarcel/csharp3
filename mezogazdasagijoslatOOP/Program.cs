using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezogazdasagijoslatOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Búza mennyisége tonnában:");
            this.mag = int.Parse(Console.ReadLine());
            this.szorzo = this.rnd.Next(5, 15);
            this.hozam = this.mag * this.szorzo;

            Console.WriteLine("A várható mennyiség {0}.", this.hozam);
            Console.ReadKey();
        }
    }
}
