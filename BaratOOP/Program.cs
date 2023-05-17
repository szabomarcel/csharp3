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
        private static BaratScreen kepernyo;
        private static BaratBuli Buli;
        static void Main(string[] args) // Statikus Main
        {
            barat = new Barat();
            string[] t = { "teszt aranka", "1991.11.12", "N", "4" };
            barat.beolvas();
            vizsga(t[0]);

            /*
            barat.kereses(t[0]);
            vizsgalat(t[0]);
            */

            barat.insertBarat(t);
            vizsga(t[0]);

            barat.delete(t[0]);
            vizsga(t[0]);

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

        private static void lista() // Lista kiíratása
        {
            int l = (kepernyo.listazas(Console.OpenStandardInput(l));
            Console.WriteLine(l);
        }

        private static void eldontendo() // Eldöntendő hogy mehet-e bulizni vagy sem.
        {
            int b;
            if (Buli.bulizas(Console.OpenStandardOutput(b)))
            {
                Console.WriteLine("Mehet bulizni.");
            }
            else
            {
                Console.WriteLine("Nem mehet ulizni. Nem érte el az éltkort");
            }
        }
        private static void latpozasGorgetes(int lg) // Lapozás és görgetés 
        {

        }
    }
}
