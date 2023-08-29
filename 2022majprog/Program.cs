using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022majprog
{
    internal class Program 
    {
        struct Telek
        {
            public int adoszam;
            public string utcanev, hazszam, adosav;
            public int terulet;
        }
        static int A = 0, B = 0, C = 0;
        static Telek[] telkek = new Telek[1000];
        static int meret = 0;
        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();
        }
        private static void feladat1()
        {
            // A fájl sorainak beolvasása
            string[] sorok = File.ReadAllLines("utca.txt");

            // Adóságok meghatározása (1. sor)
            string[] darabok = sorok[0].Split(' ');
            A = int.Parse(darabok[0]);
            B = int.Parse(darabok[1]);
            C = int.Parse(darabok[2]);

            // Telkek adatainak meghatározása (2.sortól)
            for (int i = 1; i < sorok.Length; i++)
            {
                darabok = sorok[i].Split(' ');

                telkek[i - 1].adoszam = int.Parse(darabok[0]);
                telkek[i - 1].utcanev = darabok[1];
                telkek[i - 1].hazszam = darabok[2];
                telkek[i - 1].adosav = darabok[1];
                telkek[i - 1].terulet = int.Parse(darabok[4]);
            }
            meret = sorok.Length - 1;
        }
        private static void feladat2()
        {
            // A mintában 543 telek szerepel.
            Console.WriteLine("2.Feladat: ");
            Console.WriteLine("A mintában {0} telek szerepel");
        }
        private static void feladat3()
        {
            Console.WriteLine("3.Feladat: ");
            Console.WriteLine("Egy tulajdonos adószáma: ");
            int bekertAdoszam = int.Parse(Console.ReadLine());

            bool vanEredmeny = false;
            for (int i = 0; i < meret; i++)
            {
                if (telkek[i].adoszam == bekertAdoszam)
                {
                    Console.WriteLine("{0} utca {1}", telkek[i].utcanev, telkek[i].hazszam);
                    vanEredmeny = true;
                }
            }
            if (!vanEredmeny)
            {
                Console.WriteLine("Nem szerepel az adatállományban.");
            }
        }
    }
}
