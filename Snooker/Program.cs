using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            Console.ReadLine();
        }

        private static void feladat4()
        {
            Console.WriteLine("\n4. Feladat: ");
            Console.WriteLine($"A versenyzők átlagosan {} fontot keresnek.");
        }

        private static void feladat3()
        {
            Console.WriteLine("3. Feladat: ");
            object Helyezes = null;
            Console.WriteLine($"A világranglista {Helyezes} versenyző szerepel.");
        }

        private static void beolvastatas()
        {
            try
            {
                using (StreamReader file = new StreamReader("smooker"))
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
