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
        private PontAdat[] osztalyzat = new PontAdat[0]; // A pontadat tömbje
        static string[] jegyek = { "elégtelen", "elégséges", "közepes", "jó", "jeles" };

        // Konstruktor
        public PontHat(int[,]k) 
        {

            this.osztalyzat = k;
        }

        // Eredmények átadó metódusok
        public PontAdat getPontAdat()
        {
            return this.osztalyzat[0];
        }
        public void szamitas()
        {
            // Ponthatár számítás
            setPontAdat();
        }
        private void setPontAdat()
        {
            int pont = 0; // Gyűjtés
            if (pont >= 0 && pont < 50) osztalyzat = 1;
            else if (pont >= 50 && pont < 65) osztalyzat = 2;
            else if (pont >= 65 && pont < 80) osztalyzat = 3;
            else if (pont >= 80 && pont < 90) osztalyzat = 4;
            else if (pont >= 90 && pont <= 100) osztalyzat = 5;
            else osztalyzat = 0;
        }

            
    }
}
