using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
            Console.WriteLine("\n7. Feladat: ");
            foreach (var item in fifav.FindAll(z => z.HeIyezes1 == 0).GroupBy(a => a.Pontszam1).Select(b => new { ok = b.Key, db = b.Count() }))
            {
                if (item.db > 2)
                {
                    Console.WriteLine($"\t{item.ok} : {item.db}");
                }
            }
        }
        private static void feladat6()
        {
            Console.WriteLine("\n6. Feladat: ");
            foreach (Fifa item in fifav)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine($"A csapatok között nincs {item}.");
            }
        }

        private static void feladat5()
        {
            Console.WriteLine("\n5. Feladat: ");
            foreach (Fifa item in fifav.FindAll(a => a.HeIyezes1.Equals("Hollandia") && a.Pontszam1 > 0))
            {
                Console.WriteLine($"\t{item.Csapat1.Max()} : {item.HeIyezes1}. helyzes");
            }
        }

        private static void feladat4()
        {
            Console.WriteLine("\n4. Feladat: ");
            foreach(var item in fifav) 
            {
                /*Console.WriteLine($"A csapatok átlagos pontszáma: " + fifav.Count(item));*/
            }
        }

        private static void feladat3()
        {
            Console.WriteLine("3. Feladat: ");
            Console.WriteLine($"A vilgranglistán {fifav.Count} csapat szerepel");
        }

        private static void beolvastatas()
        {
            try
            {
                using (StreamReader file = new StreamReader(@"berek2020.txt"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        fifav.Add(new Fifa(file.ReadLine()));
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
