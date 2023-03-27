using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombElem
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] tomb = new int[100];
            int paros = 0;
            int paratlan = 0;   
            bool m = false;

            Console.WriteLine("Írj be számokat 100-ig: ");
            while (m == false)
            {
                for (int i = 0; m == false; i++)
                {
                    int k = Convert.ToInt32(Console.ReadLine());
                    if (k % 2 == 0)
                    {
                        paros++;
                    }
                    else if (k % 2 == 1)
                    {
                        paratlan++;
                    }
                    k = k + k;
                    if(k >= 100)
                    {
                        m = true;
                    }
                }
            }

            Console.WriteLine("Elértük a százat");
            Console.WriteLine("{0} Páros volt benne, {1} Páratlan volt benne", paros, paratlan);
            Console.ReadKey();
        }
    }
}
