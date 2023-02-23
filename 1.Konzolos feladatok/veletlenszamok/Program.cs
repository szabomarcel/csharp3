using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veletlenszamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1, szam2;

            Console.WriteLine("Írja be az első számot");
            szam1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Írja be a második számot");
            szam2 = Convert.ToInt32(Console.ReadLine());

            Random veletlen = new Random();
            Console.WriteLine( "A generalt szamok: {0}, {1}, {2}.",
            veletlen.Next(szam1, szam2),
            veletlen.Next(szam1, szam2),
            veletlen.Next(szam1, szam2));
    
            Console.ReadLine();

        }
    }
}
