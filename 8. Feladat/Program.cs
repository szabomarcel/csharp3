using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = Console.ReadLine();
            string cim = Console.ReadLine();
            int kor = int.Parse(Console.ReadLine());
            File.WriteAllText("adat.txt", nev + "\n" + cim + "\n" + kor);
            Console.ReadKey();
        }
    }
}
