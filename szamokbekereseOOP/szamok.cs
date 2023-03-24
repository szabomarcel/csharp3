using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamokbekereseOOP
{
    struct szamkbe
    {
        public int x;
    }
    internal class szamok
    {
        // Osztályválétozók
        private string n;
        private int hossz;
        private int osszeg;

        public szamok() { }

        public szamok(string n, int hossz)
        {
            this.n = n;
            this.hossz = hossz;
        }
        public void szamitas()
        {
            setszambe();
        }

        private void setszambe()
        {
            for (int i = 0; i < hossz; i++)
            {
                this.osszeg = this.osszeg + Convert.ToInt16(n[i]) - 48;
            }
            if (this.osszeg % 3 == 0) ;
            if (this.osszeg % 9 == 0) ;
            if (this.hossz > 1)
                if (this.hossz > 1)
                {
                    if ((Convert.ToInt16(n[this.hossz - 2] - 48) * 10 + Convert.ToInt16(n[this.hossz - 1]) - 48) % 4 == 0) ;
                    else if ((Convert.ToInt16(n[0]) - 48) % 4 == 0) ;
                }
        }
    }
}
