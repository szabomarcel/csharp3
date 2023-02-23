using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Ez egy szöveg";
            Console.Write("Kiíratás stringként:");
            Console.WriteLine(s);
            Console.WriteLine("Kiíratás tömb elemenként:");
            for (int i = 0;i < s.Length; i++) 
            {
                Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
