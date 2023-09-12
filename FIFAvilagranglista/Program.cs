using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FIFAvilagranglista
{
    internal class Program
    {
        static List<Fifa> fifav = new List<Fifa>();
        static void Main(string[] args)
        {
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            Console.ReadLine();
        }

        private static void feladat7()
        {
            Console.WriteLine("\n 7. Feladat: ");
            foreach (var item in fifav)
            {
                while (!item.HeIyezes1(false))
                {
                    item.HeIyezes1++;
                }
            }
            Console.WriteLine();
        }

        private static void feladat6()
        {
            Console.WriteLine("\n 6. Feladat: ");
            Console.WriteLine("A csapatok között nincs Magyarország.");
        }

        private static void feladat5()
        {
            Console.WriteLine("\n5. Feladat: ");
            foreach(var item in fifav)
            {
                Console.WriteLine("A legtöbbet javíti csapat: " + item.ToString());
            }
        }

        private static void feladat4()
        {
            Console.WriteLine("\n4. Feladat: ");
            foreach(var item in fifav) 
            {
                Console.WriteLine($"A csapatok átlagos pontszáma: \t{item.Pontszam1.ToString()}"  );
            }
        }

        private static void feladat3()
        {
            Console.WriteLine("3. Feladat: ");
            Console.WriteLine($"A vilgranglistán 20 csapat szerepel");
        }

        private static void beolvastatas()
        {
            try
            {
                using (StreamReader file = new StreamReader(@"berek2020"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                       //fifa.Add(new fifav(file.ReadLine()));
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
