using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace percekesorakOOP
{
    struct percekora
    {
        public int x;
    }
    internal class percekorak
    {
        // Osztályváltozók
        private int ora;
        private int perc;
        private int mperc;

        public percekorak() { }

        // Eredmények átadó metódusok
        public void Szamitas()
        {
            // Első időpont
            this.ora = Convert.ToInt32(Console.ReadLine());
            this.perc = Convert.ToInt32(Console.ReadLine()); 
            this.mperc = Convert.ToInt32(Console.ReadLine());
            DateTime elso = new DateTime(2000, 02, 02, this.ora, this.perc, this.mperc);

            // Második időpont
            this.ora = Convert.ToInt32(Console.ReadLine());
            this.perc = Convert.ToInt32(Console.ReadLine());
            this.mperc = Convert.ToInt32(Console.ReadLine());
            DateTime masik = new DateTime(2000, 02, 02, this.ora, this.perc, this.mperc);
        }

    }
}
