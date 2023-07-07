using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace VELETLENSZERUKIALAKITAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Véletlenszerű csoport kialakítása...");
            Console.WriteLine("Osztály létszáma!");
            int letszam = int.Parse(Console.ReadLine());
            Console.WriteLine("Max létszám: ");
            int csop = int.Parse(Console.ReadLine());
            bool[] osztaly = new bool[letszam];
            Random rnd = new Random();
            int db = 0;
            while (db < letszam)
            {
                int i = rnd.Next(0, letszam);
                if (osztaly[i] == false)
                {
                    double c = db / csop;
                    Console.WriteLine("A(z) {0}. csoport tagja: " + "{1}. tanuló", Math.Floor(c) + 1, i + 1);
                    osztaly[i] = true;
                    db++;
                }
            }
            Console.ReadLine();
        }
    }
}
