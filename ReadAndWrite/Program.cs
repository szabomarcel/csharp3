using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Channels;

namespace ReadAndWrite
{
    internal class Program
    {
        struct szemely
        {
            public string Hétfő;
            public string Kedd;
            public string Szerda;
            public string Csütörtök;
            public string Péntek;
            public string Szombat;
            public string Vasárnap;

        }
        static void Main(string[] args)
        {
            szemely a = new szemely();
            string fnev;
            Console.Write("Allomany neve utvonallal egyutt:");
            fnev = "taborra.csv";
            StreamReader f = File.OpenText(@"C:\\taborra.csv");
            while (f.Peek() != -1)
            {
                Console.WriteLine(f.ReadLine());

            }
            f.Close();
            StreamReader g = File.OpenText(@"C:\\taborra.csv");
            while (g.Peek() != -1)
            {
                Console.WriteLine(g.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
