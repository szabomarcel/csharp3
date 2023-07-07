using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamolasfeladat2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meret = 10; // Változó a méretre
            int vkozep = Convert.ToInt16(40 - meret / 2); // Változó a vközépre és a méret osztása 2-vel
            int fkozep = Convert.ToInt16(12 - meret / 2); // Változó a fközépre és a méret osztása 2-vel
            int harmad = Convert.ToInt16(meret / 3); // Változó a harmadra és a méret osztása 3-mal
            for (int i = 0; i < meret; i++)
            {
                Console.SetCursorPosition(vkozep + i, fkozep);
                Console.Write("X");
                Console.SetCursorPosition(vkozep - i, fkozep + i + 1);
                Console.Write("X");
                Console.SetCursorPosition(vkozep + i, fkozep + meret + 1);
                Console.Write("X");
                Console.SetCursorPosition(80 - vkozep + i + harmad * 2 + 1, fkozep + harmad + 1);
                Console.Write("X");
                Console.SetCursorPosition(80 - vkozep + i + 2 * (harmad), fkozep + harmad * 2 + 2);
                Console.Write("X");
            }
            for (int i = 0; i < harmad; i++)
            {
                Console.SetCursorPosition(80 - vkozep + meret, fkozep + i + 1);
                Console.Write("X");
                Console.SetCursorPosition(80 - vkozep + meret - 1, fkozep + harmad + i + 2);
                Console.Write("X");
                Console.SetCursorPosition(80 - vkozep + meret - 2, fkozep + harmad * 2 + i + 3);
                Console.Write("X");
                Console.SetCursorPosition(80 - vkozep + meret + harmad + 1, fkozep + harmad + i + 1);
                Console.Write("X");
                Console.SetCursorPosition(80 - vkozep + meret + harmad, fkozep + harmad + i + 2);
                Console.Write("X");
                Console.SetCursorPosition(80 - vkozep + meret + harmad - 1, fkozep + harmad * 2 + i + 3);
                Console.Write("X");
            }
            Console.ReadLine();
        }
    }
}
