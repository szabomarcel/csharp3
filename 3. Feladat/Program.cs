using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> l = new List<int>();
            while (l.Count < 20)
            {
                int rand = rnd.Next(1, 6);
                if(!l.Contains(rand))
                    l.Add(rand);
            }
            l.Sort();
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine("{0}", l[i]);
            }
            Console.ReadKey();
        }
    }
}
