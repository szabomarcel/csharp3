using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aertek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az a: ");
            int a = int.Parse(Console.ReadLine());
            string s = "";
            for (int i = 1; i <= a; i++)
            {
                Console.SetCursorPosition(2 * a - 1, i);
                s = s + "*";
                Console.Write(s);
            }
            Console.ReadLine();
        }
    }
}
