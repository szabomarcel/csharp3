using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> NEVEK = new List<string>();
            NEVEK.Add(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
            for (int i = 0; i < NEVEK.Count; i++)
            {
                Console.Write(NEVEK[i] + ", ");
            }
            // Insert
            // NEVEK.Insert(2, "Új fiú");

            // Remove
            // NEVEK.Remove(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
            // NEVEK.RemoveAt(1);
            // Clear
            // NEVEK.Clear();

            /*
            Baratok a = new Baratok();
            StreamWriter f = new StreamWriter(@"feladat2.text");
            string[] s;
            double atl = 0, sz = 0;
            /*
            while (g.Peek() != -1)
            {
                s = g.Readline().Split('_');
                a.nev = s[0];
                a.eletkor = int.Parse(s[1]);
                atl = atl + a.eletkor;
                sz++;
            }
            g.Close();*/
            //Console.WriteLine("Csoport atlageletkotra: {0}", atl / sz);
            Baratok a = new Baratok();
            string fnev;
            Console.Write("Allomany neve utvonallal egyutt:");
            fnev = "fajlnev.csv";
            StreamReader f = File.OpenText(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
            while (f.Peek() != -1)
            {
                Console.WriteLine(f.ReadLine());

            }
            f.Close();
            StreamReader g = File.OpenText(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
            while (g.Peek() != -1)
            {
                Console.WriteLine(g.ReadLine());
            }

            Console.ReadKey();
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
