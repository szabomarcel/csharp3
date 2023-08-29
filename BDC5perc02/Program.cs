using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDC5perc02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Két kockával dobok: "); 
            Random r = new Random();

            int db12 = 0;
            for (int i = 1; i <= 20; i++)
            {
                int kocka1 = r.Next(1, 7);
                int kocka2 = r.Next(1, 7);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(kocka1 + " ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(kocka2 + " ");
                if((kocka1 + kocka2) == 12)
                {
                    db12++;
                }
            }
            Console.WriteLine("\nEnnyiszer volt 12 az összeg." + db12);
            Console.ReadKey();
        }
    }
}
