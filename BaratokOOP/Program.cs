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
            NEVEK.Insert(2, "Új fiú");

            // Remove
            NEVEK.Remove(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
            NEVEK.RemoveAt(1);
            // Clear
            NEVEK.Clear();


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
            Console.ReadKey();
        }
    }
}
