using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> l = new List<int>();
            for (int i = 0; i < 67000; i++)
            {
                l.Add(rnd.Next(1, 100001));
            }
            Console.WriteLine("Legnagyobb: {0}",l.Max());
            Console.ReadLine();
        }
    }
}
