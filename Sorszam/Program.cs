using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tomb[i] = -1;
            }
            int db = 0; int sorszam;
            while (db != 10)
            {
                Console.Write("Kérem adjon meg egy sorsámot: ");
                sorszam = int.Parse(Console.ReadLine());
                if (tomb[sorszam] == -1)
                {
                    Console.Write("Ez a hely még nem került feltöltésre, adjon meg egy másik értéket: ");
                    tomb[sorszam] = int.Parse(Console.ReadLine());
                    db++;
                }
                else Console.WriteLine("Ezen a helyen már van érték.");
                if(db == 10)
                    Console.WriteLine("A vektor fel lett töltve teljesen.");
            }
            Console.ReadLine();
        }
    }
}
