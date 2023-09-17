using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bekertnev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem, adja meg a nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Üdv, " + nev + "!");
            string fajlnev = "adatok.txt";
            if(File.Exists(fajlnev))
            {
                string[] sorok = File.ReadAllLines(fajlnev);
                foreach(string sor in sorok)
                {
                    Console.WriteLine(sor);
                }
            }
            else
            {
                Console.WriteLine("A fájl nem található.");
            }
            if (args.Length > 0)
            {
                Console.WriteLine("Első parancssori argumentum: " + args[0]);
            }
            else
            {
                Console.WriteLine("Nincsenek parancssori argumentumok.");
            }
        }
    }
}
