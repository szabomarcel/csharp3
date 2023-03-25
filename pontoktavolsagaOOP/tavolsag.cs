using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pontoktavolsagaOOP
{
    struct tavol
    {
        public int x;
        public int y;
    }
    internal class tavolsag
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;
        private int tavol;

        public tavolsag(int x1, int x2, int y1, int y2, int tavol)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.tavol = tavol;
        }
        public void Szamitas()
        {
            double tavolsag = Math.Sqrt((x1 - x2) * (x1 - x2) * (y2 - y1) * (y2 - y1));
            Convert.ToDouble(Console.ReadLine());
            if (tavolsag >= 0)
            {
                if (tavolsag >= 1)
                Console.Write("Távolsag: {0}", tavolsag);
            }
            else Console.WriteLine("Ez túl magas!");
        }
       
    }
}
