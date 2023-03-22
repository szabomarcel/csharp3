using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimleteresOOP
{
    struct penz
    {
        public int id; // Penzerme neve
    }
    internal class penzerme
    {
        // Osztályváltozók
        private int penz;
        public static string[] penzfajtak = [20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1];
        private int penzermek = 0;

        //Konstruktor
        public (int p)
        {
            this.penz = p;
        }    

        // Eredmények átadó metódusok
        public string GetPenzerme()
        {
            return this.GetPenzerme();
        }
        public void Szamitasa()
        {
            // Kerekités számítás
            object value = SetPenz();
        }
        private void SetPenz()
        {
            int osszeg = 0;
            for (int i = 0; i < osszeg.Length; i++)
            {
                osszeg = osszeg + penzfajtak[i];
            }
            if (this.penz > 1 && this.penz < 200000)
            {
                Math.Round((decimal)(20000), MidpointRounding.AwayFromZero);
            }

        }
    }