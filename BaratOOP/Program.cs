using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaratOOP
{
    internal class Program
    {
        private static Barat barat;
        private static BaratScreen barat1;
        private static BaratPage barat2;
        private static BaratBuli Buli;
        static void Main(string[] args) // Statikus Main
        {
            /*
            barat = new Barat();
            string[] t = { "teszt aranka", "1991.11.12", "N", "4" };
            barat.beolvas();
            vizsga(t[0]);

            /*
            barat.kereses(t[0]);
            vizsgalat(t[0]);
            

            barat.insertBarat(t);
            vizsga(t[0]);

            barat.delete(t[0]);
            vizsga(t[0]);

            barat1 = new BaratScreen();
            barat1.beolvas(); // Ős metódus és használjuk
            barat1.listazas();
            */
            barat2 = new BaratPage();
            barat2.beolvas();
            barat2.Page();

            Console.ReadKey();
        }
        private static void vizsga(string t) // Visszatérési érték
        {

            if (barat.kereses(t))
            {
                Console.WriteLine("Már van ilyen barátunk.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen barátunk.");
            }
        }
    }
}
