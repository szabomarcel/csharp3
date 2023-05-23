using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _12.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> l = new List<int>();
            int pr = 0;
            for (int i = 0; i < 345000; i++)
            {
                l.Add(rnd.Next(1, 10001));
                if (l[i] % 2 == 0) 
                    pr++;
            }
            Console.WriteLine("Paros: {0}", pr);
            Console.ReadLine();
        }
    }
}
