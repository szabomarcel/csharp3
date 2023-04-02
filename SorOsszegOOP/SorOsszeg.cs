using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorOsszegOOP
{
    internal class SorOsszeg
    {
        // Konstruktor
        private int s = 0;
        private int k = 0;
        private string szam;
        private int osszeg = 0;

        public SorOsszeg() { }
        public SorOsszeg(int s, int k, int szam, int osszeg) // A sorosszeg egyenlőek önmagukkal
        {
            this.s = s;
            this.k = k;
            this.osszeg = osszeg;
        }
        public int S { get { return s; } }
        public int K { get { return k; } }

        // "N" beállitás


        // Eredmény meghatározása
        public void szamitas() // Meghatározuk az eredmény számát
        {
            for (int i = 0; i <= k; i++)
            {
                s = s + i * (i + 1);
            }

        }

        // Eredmény lekérése
        public void eredmeny() // Lekérjük a szám eredményét
        {
            for (int i = 0; i < szam.Length; i++)
            {
                osszeg = osszeg + int.Parse(szam[i].ToString());
            }
        }

    }

}
