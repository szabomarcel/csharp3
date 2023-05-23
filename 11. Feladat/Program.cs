using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Feladat
{
    internal class Program
    {
        static int Szam()
        {
            int a = 0;
            a = int.Parse(Console.ReadLine());
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nem szám.");
            }
            
            return a;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while(list.Count < 0)
            {
                list.Add(Szam());
            }
            Console.WriteLine("Legkisebb: {0}", list.Min());
            Console.ReadKey();
        }
    }
}
