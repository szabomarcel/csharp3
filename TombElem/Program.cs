﻿using System;
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

            Console.WriteLine("Írj be számokat 100-ig: "); // 0-tól 100-ig beírando számok és azon felül
            while (m == false) // While ciklus amikor az m hamis
            {
                for (int i = 0; m == false; i++) // for ciklus az m-re
                {
                    int k = Convert.ToInt32(Console.ReadLine());
                    if (k % 2 == 0) // Ha k % 2 == 0 akkor páros lesz a szám
                    {
                        paros++;
                    }
                    else if (k % 2 == 1) // Ha k % 2 == 1 akkor páratlan lesz a szám
                    {
                        paratlan++;
                    }
                    k = k + k;
                    if(k >= 100) // Ha nagyobb vagy egyenlő a szám akkor igaz lesz az állitás és nem halad tovább
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
