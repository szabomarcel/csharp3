using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class TesztOsztály
    {
        // -- Példány szintű tagok -- // -->> // -- Több példány is létrehozható -- //
        int szam1 = 15;
        public void osszeg_kiir()
        {
            Console.WriteLine("Az összeg: " + (szam1 + szam2));
            this.szam1 = 11;    this.szam2 = 22;
            szorzat_kiir();     this.szorzat_kiir();
        }

        // -- Osztály szintű tagok -- (static jelzővel) //
        static int szam2 = 24;
        public static void szorzat_kiir()
        {
            Console.WriteLine("Az összeg: " + (szam1 + szam2);
            this.szam1 = 11;    this.szam2 = 22;
            oszeg_kiir();       this.osszeg_kiir();
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // .. -- Osztálykezelési példa -- .. //
            double[] tortek = new double[5];
            List<int> egeszek = new List<int>();
            egeszek.IndexOf(5); // Vissza térési elemérték megadása zárójelbe
            Array.IndexOf(tortek, 5); // Magát az osztály nevezűk meg. Ezután tömb és érték megadása kell.
            TesztOsztály.szorzat_kiir();
            TesztOsztály peldato = new TesztOsztály();
            peldato.osszeg_kiir();

            Console.ReadLine();
        }
    }
}
