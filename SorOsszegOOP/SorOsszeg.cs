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
        public int s = 0; //s érték tárolás
        public int k = 0; //k érték tárolás
        public string szam; //Szám tárolás
        public int osszeg = 0; //Összeg tárolás

        public SorOsszeg() { }
        public SorOsszeg(int s, int k, int szam, int osszeg) // A sorosszeg egyenlőek önmagukkal
        {
            this.s = s;
            this.k = k;
            this.osszeg = osszeg;
        }
        // "N" beállitás
        public int S { get { return s; } }
        public int K { get { return k; } }

        // Eredmény meghatározása
        public void szamitas() // Meghatározuk az eredmény számát for ciklussal
        {
            for (int i = 0; i <= k; i++)
            {
                s = s + i * (i + 1);
            }

        }

        // Eredmény lekérése
        public void eredmeny() // Lekérjük a szám eredményét és elkészítme for ciklussal.
        {
            for (int i = 0; i < szam.Length; i++)
            {
                osszeg = osszeg + int.Parse(szam[i].ToString());
            }
        }

    }

}
