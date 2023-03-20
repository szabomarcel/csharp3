using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimleteresOOP
{
    internal class penzerme
    {
        struct penz
        {
            public int id; // Penzerme neve
        }
        internal class PontHat
        {
            // Osztályváltozók
            private int penz;
            static string[] penzfajtak = [ 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 ];
            private int penzermek = 0;

            //Konstruktor
            public penzerme(int p)
            {
                this.id = p;
            }

            // Eredmények átadó metódusok
            public string getPenzerme()
            {
                return 
            }
            public void szamitasa()
            {
                // Kerekités számítás
                setPenz();
            }

            private void setPenz()
            {
                if ( this.penz > 1 && this.penz < 200000)
                {

                    Math.round();
                }
                
            }
        }
    }
}

