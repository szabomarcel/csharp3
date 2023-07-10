using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 4;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c < a);
            Console.WriteLine(c < b && c > a);
            Console.WriteLine(c < b && c < a);
            Console.WriteLine(c >= b && c >= a);
            Console.WriteLine(c >= b && c <= a);
            Console.WriteLine(c <= b && c <= a);
            Console.WriteLine(c >= b && c <= a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c < b && c == a);
            Console.WriteLine(c < b && c != a);
            Console.WriteLine(c > b && c != a);
            Console.ReadLine();
        }
    }
}
