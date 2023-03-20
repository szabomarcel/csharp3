using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonthatOOP
{
    struct PontAdat
    {
        public string pont; // Pont neve
    }
    internal class PontHat
    {
        // Osztlyváltozók
        private int pont;
        static string[] jegyek = { "elégtelen", "elégséges", "közepes", "jó", "jeles" };
        private int jegy = 0; // Gyűjtés

        // Konstruktor
        public PontHat(int k) 
        {

            this.pont = k;
        }

        // Eredmények átadó metódusok
        public string getOsztalyzat()
        {
            return jegyek[jegy - 1];
        }
        public void szamitas()
        {
            // Ponthatár számítás
            setPontAdat();
        }
        private void setPontAdat()
        {
            if (this.pont >= 0 && this.pont < 50) this.jegy = 1;
            else if (this.pont >= 50 && this.pont < 65) this.jegy= 2;
            else if (this.pont >= 65 && this.pont < 80) this.jegy= 3;
            else if (this.pont >= 80 && this.pont < 90) this.jegy= 4;
            else if (this.pont >= 90 && this.pont <= 100) this.jegy = 5;
            else this.jegy = 0;
        }

            
    }
}
