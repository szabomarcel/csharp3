using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezogazdasagijoslatOOP
{
    struct joslat
    {
        public string joslatok;
    }
    internal class joslatszamolas
    {
        // Osztályváltozók
        Random rnd = new Random();
        private int mag;
        private int szorzo;
        private int hozam;

        // Konstruktor
        public joslatszamolas(int rnd, int mag, int szorzo, int hozam)
        {
            this.mag = mag;
            this.szorzo = szorzo;
            this.hozam = hozam;

        }
        public joslatszamolas() { }
        public joslat GetJoslat()
        {
            return GetJoslat();
        }

        // Joslat kiszámítás
        public void Szamitas()
        {
            if (szorzo > 5 && szorzo < 8)
                Console.WriteLine("Átlag alatti");
            else if (szorzo > 9 && szorzo < 12)
                Console.WriteLine("Átlagos év");
            else if (szorzo > 13 && szorzo < 15)
                Console.WriteLine("Átlag feletti");
        }
    }
}
