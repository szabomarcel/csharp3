using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltOOP
{
    internal class Atvalt
    {
        // Osztályváltozók
        public int bitsor = 0;
        public double osszeg = 0;
        public double hatvany = 2;

        // Konstructor
        private Atvalt() { }
        private Atvalt(int bitsor, int osszeg, int hatvany)
        {
            this.bitsor = bitsor;
            this.osszeg = osszeg;
            this.hatvany = hatvany;
        }

        // Átváltás számolása
        public void szamitas()
        {
            for (int i = 0; i < bitsor; i++) // Ciklus a bitsor kiszámitására
            {
                hatvany = Math.Pow(2, bitsor - i - 1); // Hatványozás
                string szamjegy = bitsor(i, 1); 
                osszeg += int.Parse(szamjegy) * hatvany;
            }
        }
    }
}
