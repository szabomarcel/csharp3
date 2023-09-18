using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snooker
{
    internal class Program
    {
        static List<Snook> smooker = new List<Snook>();
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
            Console.WriteLine("\n7.feladat: Statisztika");
            foreach (var item in smooker.FindAll(z => z.Helyezes1 == 0).GroupBy(a => a.Nev1).Select(b => new { ok = b.Key, db = b.Count() }))
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
            
            Console.WriteLine($"A versenyzők között van  versenyző");
        }

        private static void feladat5()
        {
            Console.WriteLine("\n5. Feladat: ");
            /*foreach (Snook item in smooker.FindAll(a => a.Helyezes1).FindAll(b => b.Nev1).FindAll(c => c.Orsazg1).GroupBy(d => d.Nyeremeny1)
            {

                Console.WriteLine("A legjobb kereső kínai versenyző: ");
            }*/
        }

        private static void feladat4()
        {
            Console.WriteLine("\n4. Feladat: ");
            foreach (Snook item in smooker.FindAll(a => a.Nyeremeny1 == 0).GroupBy(b => b.Helyezes1))            
                Console.WriteLine($"\tA versenyzők átlagosan {item} fontot keresnek.");            
        }

        private static void feladat3()
        {
            Console.WriteLine("3. Feladat: ");
            Console.WriteLine($"A világranglista {smooker.Count} versenyző szerepel.");
        }

        private static void beolvastatas()
        {
            try
            {
                using (StreamReader file = new StreamReader("smooker.txt"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        smooker.Add(new Snook(file.ReadLine()));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
