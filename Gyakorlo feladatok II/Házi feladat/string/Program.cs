using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(50); //szöveg építő
            for (char ch = 'a'; ch <= 'z'; ++ch) // Eldöndendö ciklus a ch-ra
            {
                sb.Append(ch); // Melléklet a ch-ra
            }
            Console.WriteLine(sb); // Sb kiíratás
            Console.ReadKey();
        }
    }
}
