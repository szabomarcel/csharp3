using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csomagoloceg
{
    struct csomagolo
    {
        public int ceg; // A cég neve
    }
    internal class csomagoloszamolas
    {
        // Osztályváltozók
        private float ceg;
        static float meret;
        public float szalag;
       

        public csomagoloszamolas() { }

        // Konstruktor
        public csomagoloszamolas(int cs)
        {
            this.ceg = cs;
        }

        public void szamitas()
        {
            // csomagolo szamitas
            setCsomagoloszamolas();
        }

        public void setCsomagoloszamolas()
        {
            int d = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            float szalag = ((2 * d * Math.PI) + 60) * N;
        }
    }
}
