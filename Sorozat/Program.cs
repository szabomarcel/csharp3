using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sorozat = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                sorozat[i] = rnd.Next(1, 101);
            }
            int minimum = sorozat[0];
            for (int g = 0; g < 15; g++)
            {
                if (minimum > sorozat[g])
                {
                    minimum = sorozat[g];
                }
            }
            Console.WriteLine("A sorozat legkissebb eleme: {0}", minimum);
            Console.ReadLine(); 
        }
    }
}
