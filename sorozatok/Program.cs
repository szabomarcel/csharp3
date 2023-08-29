using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorozatok
{
    class Sorozat 
    {
        public string Datum { get; set; }
        public string Cim { get; set; }
        public string EvadEsEpizod { get; set; }
        public int HosszPercben { get; set; }
        public bool Megnezte { get; set; }
    }
    internal class Program
    {
        static List<Sorozat> sorozatok;
        static void Main(string[] args)
        {
            Feladat1();
            Console.WriteLine("2. Feladat ");
            Feladat2();
            Console.WriteLine();

            Console.WriteLine("3. Feladat ");
            Feladat3();
            Console.WriteLine();

            Console.WriteLine("4. Feladat ");
            Feladat4();
            Console.WriteLine();

            Console.WriteLine("5. Feladat ");
            Feladat5();
            Console.WriteLine();

            Console.WriteLine("7. Feladat ");
            Feladat7();
            Console.WriteLine();

            Feladat8();           
        }
        static string Hetnapja(int ev, int ho, int nap)
        {
            string[] napok = { "v", "h", "k", "sz", "cs", "p", "sz" };
            int[] honapok = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4};
            if (ho < 3) ev = ev - 1;
            return napok[(ev + ev / 4 - ev / 100 + ev / 400 + honapok[ho - 1] + nap) % 7];
        }
        private static void Feladat1()
        {
            sorozatok = new List<Sorozat>();
            string[] adatok = File.ReadAllLines("lista.txt");
            for (int i = 0; i < adatok.Length; i += 5)
            {
                Sorozat uj = new Sorozat();
                uj.Datum = adatok[i];
                uj.Cim = adatok[i + 1];
                uj.EvadEsEpizod = adatok[i + 2];
                uj.HosszPercben = int.Parse(adatok[i + 3]);
                uj.Megnezte = adatok[i + 4] == "1";
                sorozatok.Add(uj);
            }
            Console.ReadLine();
        }
        private static void Feladat2()
        {
            Console.WriteLine("A listában {0} db vetítési dátummal rendelkező epizód van. ", sorozatok.Count(x => x.Datum != "NI"));
            Console.ReadLine();
        }
        private static void Feladat3()
        {
            Console.WriteLine("A listában lévő epizód {0:N2}%-át látta. ", sorozatok.Count(x => x.Megnezte) / (float)sorozatok.Count * 100);
            Console.ReadLine();
        }
        private static void Feladat4()
        {
            int osszegPercben = sorozatok.Where(x => x.Megnezte).Sum(x => x.HosszPercben);
            int nap = osszegPercben / 24 / 60;
            int ora = osszegPercben / 60 - (nap * 24);
            int perc = osszegPercben - ora * 60 - nap * 60 * 24;
            Console.WriteLine($"Sorozatnézéssel {nap} napot {ora} órát és {perc} percet töltött");
            Console.ReadLine();
        }
        private static void Feladat5()
        {
            Console.WriteLine("Adjon meg egy dátumot! Dátum = ");
            string bekertDatum = Console.ReadLine();

            foreach(var item in sorozatok.Where(x => !x.Megnezte && x.Datum != "NI" && bekertDatum.CompareTo(x.Datum) >= 0))
            {
                Console.Write($"{item.EvadEsEpizod}\t{item.Cim}");
            }
            Console.ReadLine();
        }
        private static void Feladat7()
        {
            Console.WriteLine("Adja meg a hét egy napját (például cs) ! Nap = ");
            string bekertNap = Console.ReadLine();

            var adottNaponVetitettek = sorozatok.Where(x => x.Datum != "NI" && Hetnapja(x.Datum) == bekertNap).Select(x => x.Cim).Distinct();
            foreach(var item in adottNaponVetitettek)
            {
                Console.WriteLine(item);
            }
            if(adottNaponVetitettek.Count() == 0)
            {
                Console.WriteLine("Az adott napon nem kerül adásba sorozat.");
            }
            Console.ReadLine();
        }
        private static string Hetnapja(string datum)
        {
            string[] reszek = datum.Split('.');
            return Hetnapja(int.Parse(reszek[0]), int.Parse(reszek[1]), int.Parse(reszek[2]));
        }
        private static void Feladat8()
        {
            StreamWriter sw = new StreamWriter("summa.txt");
            var csoportositva = sorozatok.GroupBy(x => x.Cim);
            foreach(var item in csoportositva)
            {
                sw.WriteLine("{0} {1} {2}", item.Key, item.Sum(x => x.HosszPercben, item.Count()));
            }
            sw.Close();
        }
    }
}
