using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMETLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg hányszor ismételjem: ");
            int n = int.Parse(Console.ReadLine());
            string s = "";
            for (int i = 0; i <= n; i++)
            {
                s = s + "XO";
            }
            Console.Write(s);
            Console.ReadLine();
        }
    }
}
