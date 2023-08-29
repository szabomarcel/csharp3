using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csillag1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            for (int y = 0; y <= 24; y++)
            {
                for (int x = 0; x <= 79; x++)
                {
                    if (y % 2 == 0) Console.SetCursorPosition(x, y);
                    else Console.SetCursorPosition(79 - x, y);

                    if (y == 24 && x == 79)
                        Console.SetCursorPosition(x - 1, y);

                    Console.Write("*");
                    System.Threading.Thread.Sleep(5);
                }
            }
            System.Threading.Thread.Sleep(3000); 
        }
    }
}
