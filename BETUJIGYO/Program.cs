using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BETUJIGYO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Title = "BETÜKÍGYÓ";
            char[] kigyo = new char[80];
            int i, j, kdb;
            kdb = 0;
            ConsoleKeyInfo gomb = new ConsoleKeyInfo();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("50 KARAKTERBŐL ÁLLÓ BERÜKÍGYÓ");
            do
            {
                kigyo[kdb] = Convert.ToChar(rnd.Next(Convert.ToInt32('A'), Convert.ToInt32('K') + 1));
                kdb++;
                Console.SetCursorPosition(0, 5);
                for (int i = 0; i < kdb; i++)
                {
                    Console.Write("{0}", kigyo[i]);
                }
                for (int i = kdb; i < 50; i++) Console.Write(" ");
                Thread.Sleep(100);
                while (Console.KeyAvailable)
                {
                    gomb = Console.ReadKey(true);
                    for (int i = 0; i < kdb; i++)
                    {
                        if (Char.ToUpper(gomb.KeyChar) == kigyo[i])
                        {
                            for (int j = i; j < kdb - 1; j++)
                            {
                                kigyo[j] = kigyo[j + 1];
                            }
                            kdb--; i--;
                        }
                    }
                }
            }
            while ((kdb < 50) && (kdb > 0) && (gomb.Key != ConsoleKey.Escape));
            Console.WriteLine();
            if (gomb.Key != ConsoleKey.Escape)
            {
                if (0 == kdb) Console.Write("Nyertél");
                else Console.Write("Nyertem");
                Console.WriteLine("\n\nEnterre kilépek!");
                Console.ReadLine();
            }
        }
    }
}
