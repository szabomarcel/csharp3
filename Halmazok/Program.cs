﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halmazok
{
    internal class Program
    {
        static void Kiir<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection) 
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("C:\\Users\\szabo.marcell\\source\\repos\\csharp4\\Szamok\\bin\\Debug\\szamok.txt");
        }
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            using (StreamReader reader = new StreamReader("C:\\Users\\szabo.marcell\\source\\repos\\csharp4\\Szamok\\bin\\Debug\\szamok.txt"))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int szam;
                    if (int.TryParse(line, out szam))
                    {
                        szamok.Add(szam);
                    }
                }
            }
            var set1 = new HashSet<int>(new int[] {});
            var set2 = new HashSet<int>(new int[] {});

            set2.Add(1);
            set2.Add(1000);

            Console.WriteLine("set1:");
            Kiir(set1);
            Console.WriteLine("set2:");
            Kiir(set2);

            Console.WriteLine("set1 unio set2:");
            set1.UnionWith(set2);

            Kiir(set1);

            Console.WriteLine("set2 metszet set1:");
            set2.IntersectWith(set1);

            Kiir(set2);
            Console.ReadKey();
        }
    }
}
