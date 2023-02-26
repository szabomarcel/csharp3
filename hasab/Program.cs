using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hasab
{
    internal class hasab
    {
        // Osztályváltozók
        private int T; // "T" oldal
        private int m; // "m" oldal
        private int felszin;
        private int terfogat;

        // Konstrokturok
        public hasab() { }

        public hasab(int T, int m)
        {
            this.T = T;
            this.m = m;
        }
        public hasab(int T){ this.T = T; this.m = m; }

        // Metódusok
        public void setA(int T)
        {
            if (T > 1000)
            {
                Console.WriteLine("Az oldal nem lehet nagyobb, mint ezer");
            }
            else
                this.T = T;
        }
        public void setB(int m)
        {
            this.m = m;
        }
        public int getA() { return T; }
        public int getB() { return m; }
        public void setFelszin()
        {
            this.felszin = 2 * this.T + this.m;
        }
        public int getFelszin()
        {
            return this.felszin;
        }
        public void setTerfogat()
        {
            this.terfogat = V = T * m;
        }
        public int getTerfogat()
        {
            return this.terfogat;
        }
    }

    internal class Program
    {
        enum nyomtat { oldal, kerter, osszes }
        static void Main(string[] args)
        {
            // Első példa
            hasab n1 = new hasab();
            kiir(n1, nyomtat.oldal);
            n1.setA(5);
            n1.setB(6);

            kiir(n1, nyomtat.oldal);

            n1.setFelszin();
            n1.setTerfogat();

            kiir(n1, nyomtat.kerter);

            //Második példa
            hasab n2 = new hasab(6, 2);
            kiir(n2, nyomtat.oldal);

            n2.setFelszin();
            n2.setTerfogat();

            kiir(n2, nyomtat.oldal);

            n2.getFelszin();
            n2.getTerfogat();

            kiir(n2, nyomtat.kerter);

            // Harmadik négyzet példa
            hasab n3 = new hasab(2);
            kiir(n3, nyomtat.oldal);

            n3.setFelszin();
            n3.setTerfogat();

            kiir(n3, nyomtat.oldal);

            n3.getFelszin();
            n3.getTerfogat();

            kiir(n3, nyomtat.kerter);

            Console.ReadKey();
        }
        // Metódus
        static private void kiir(hasab obj, nyomtat v)
        {
            if (v == nyomtat.oldal)
            {
                Console.WriteLine($"Az n1 négyszög oldalai: a = {obj.getA()}, b = {obj.getB()}");
            }
            else
                Console.WriteLine($"Az n1 négyszög területe = {obj.getFelszin()}, kerulete = {obj.getTerfogat()}");
        }
    }
}
