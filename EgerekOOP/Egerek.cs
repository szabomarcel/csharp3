using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgerekOOP
{
    internal class Egerek
    {
        public int L; //Az L tárolása/bekérése
        public int U; //Az U tárolása/bekérése
        public int V; //Az V tárolása/bekérése
        public int T; //Az T tárolása/bekérése

        // Konstruktor
        public Egerek() { }
        public Egerek(int L, int U, int V, int T) 
        {
            this.L = L;
            this.U = U;
            this.V = V;
            this.T = T;
        }
        // Csatorna hosszának beállítása.
        private void Számítás_Click(object sender, EventArgs e)
        {
            // Az idő beállítása.
            int p1x, p1y, p2x, p2y;
            double tav;
            if (  L.ToString() != "" && U.ToString() != "" &&
                V.ToString() != "" && T.ToString() != "")
            {
                // Az első patkány sebességének beállítása.
                p1x = Int32.Parse(L.ToString());
                p1y = Int32.Parse(U.ToString());

                // A második patkány sebességének beállítása.
                p2x = Int32.Parse(V.ToString());
                p2y = Int32.Parse(T.ToString());
                
                // Eredmény kiszámítása
                tav = Math.Sqrt(Math.Pow(p1x - p2x, 2) +
                                Math.Pow(p1y - p2y, 2));
                T.Text = tav.ToString();
            }
        }
        
        // Eredmény lekérése
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tav.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tav.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tav.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            tav.Text = "";
        }
    }
}
