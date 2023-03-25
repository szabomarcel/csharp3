using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizgozjegOOP
{
    struct vgj
    {
        public int viz_goz_jeg;
    }
    internal class VGJ
    {
        // Osztályváltozók
        private int t;
        

        // Konstruktor
        public VGJ(int t)
        {
            this.t = t;
        }
        public vgj GetAtvalt()
        {
            return GetAtvalt();
        }

        // Víz_Gőz_Jég kiszámítás
        public void Szamitas()
        {
            Convert.ToDouble(Console.ReadLine());
            if (t > 0)
            {
                if (t >= 100) Console.WriteLine("Goz!");
                else Console.WriteLine("Víz!");
            }
            else Console.WriteLine("Jeg!");
        }
    }
}
