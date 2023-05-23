using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> l = new List<int>();
            while (l.Count < 20)
            {
                int os = 0;
                int rand = rnd.Next(500, 1001);
                for (int i = 1; i < rand; i++)
                {
                    if(rand % i == 0)
                    {
                        os++;
                    }
                }
                if (os == 2)
                {
                    l.Add(rand);
                }
                for (int i = 0; i < l.Count; i++)
                {
                    Console.WriteLine("{0}", l[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
