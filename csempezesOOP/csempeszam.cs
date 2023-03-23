using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace csempezesOOP
{
    struct csempe
    {
        public int csempezes;
    }

    internal class csempeszam
    {
        // Osztályváltozók 
        private int csempezes;
        public static string[] csempemeret = [1, 20];
        private int meret = 0;
        private int Szamitas;

        public csempeszam() { }

        // Eredmények ádadó metódusok
        public (int csempezes){}

        public static void prmeret(csempe meret)
        {
            if (prmeret[0].meret <= 20)
            {
                Console.WriteLine("A szám megfelelő!");
            }
            else
            {
                Console.WriteLine("A szám nem megfelelő!");
            }
        }

        public void Szamitas()
        {
            double sz = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double t = sz * h;
            double cs = 0.2 * 0.2;
            double db = t / cs;
            double osszes = db + 0.1 * db;
        }
    }
}
