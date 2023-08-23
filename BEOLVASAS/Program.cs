using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEOLVASAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo beolvasott;
            int x = 1;
            int y = 1;
            while (true)
            {
                Kepernyo(x, y);
                beolvasott = Console.ReadKey();
                switch (beolvasott.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if(x != 1) { x --; } 
                        break;
                    case ConsoleKey.RightArrow:
                        if (x != 1) { x++; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (x != 1) { y--; }
                        break;
                    case ConsoleKey.DownArrow:
                        if (x != 1) { y++; }
                        break;
                    default: break;
                }
            }
        }
        static void Kepernyo(int x, int y)
        {
            Console.Clear();
            Console.WriteLine("(x: {0}; y: {1})", x, y);
            for (int i = 0; i < y; i++) { }
            {
                Console.WriteLine(" ");
            }
            for (int i = 0; i < x; i++) { }
            {
                Console.WriteLine(" ");
            }
            Console.Write("@");
        }
    }
}
