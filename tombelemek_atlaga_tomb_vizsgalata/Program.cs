using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombelemek_atlaga_tomb_vizsgalata
{
    internal class Program
    {
        static int[] szamok = new int[30];
        static void Main(string[] args) 
        {
            tomb_feltotes();
            Console.WriteLine("A tömb tartalma: ");
            tomb_kiir();
            double atlag = szamok.Average();
            Console.WriteLine("\n\nA tömb elemeinek átlaga: {0}", atlag);
            Console.WriteLine("Az egymás mellett lévő átlagtól nagyobbak maximális száma: {0}", eloszlas_db(atlag));
            Console.WriteLine("A vektor elosztása: {0}", a_veltor_eloszlasa(atlag));
            Console.WriteLine("\n\n\n");
            int ujra_db = 0;
            while (eloszlas_db(atlag) >= 3) // amig
            {
                tomb_feltotes();
                ujra_db++;
                atlag = szamok.Average();
            }
            Console.WriteLine("A tömb tartalma: ");
            tomb_kiir();
            Console.WriteLine("\n\nA tömb elemeinek átlaga: {0}", atlag);
            Console.WriteLine("Az egymás mellett lévő átlagtól nagyobbak maximális száma: {0}", eloszlas_db(atlag));
            Console.WriteLine("A vektor elosztása: {0}", a_veltor_eloszlasa(atlag));
            Console.WriteLine("Újra generálások száma: {0}", ujra_db);

            Console.ReadKey();
        }

        private static string a_veltor_eloszlasa(double atlag)
        {
            // int db = 0;
            /*if(db < 3)
            {
                return "Jó eloszlású";
            }
            else
            {
                return "Nem jó eloszlású";
            }*/
            return (eloszlas_db(atlag) < 3) ? "Jó eloszlású" : "Nem jó eloszlású";
        }

        private static int eloszlas_db(double avg)
        {
            int db = 0;
            int maxdb = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] > avg)
                {
                    db++;
                    if (db > maxdb)
                    {
                        maxdb = db;
                    }
                }
                else
                {
                    db = 0;
                }
            }
            return maxdb;
        }

        private static void tomb_kiir()
        {
            foreach (int szam in szamok)
            {
                Console.Write(szam + " ");
            }
        }

        private static void tomb_feltotes()
        {
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(10, 31);
            }
        }
    }
}
