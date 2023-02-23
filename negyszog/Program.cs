using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszog
{
    class Negyszog
    {
        // Osztályváltozók
        private int a; // "a" oldal
        private int b; // "b" oldal
        private int terulet;
        private int kerulet;

        // Konstrokturok
        public Negyszog() { }

        public Negyszog(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Negyszog(int a) { this.a = a; this.b = a;}

        // Metódusok
        public void setA(int a)
        {
            if (a > 1000)
            {
                Console.WriteLine("Az oldal nem lehet nagyobb, mint ezer");
            }
            else
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public int getA() { return a; }
        public int getB() { return b; }
        public void setTerulet()
        {
            this.terulet = this.a * this.b;
        }
        public int getTerulet()
        {
            return this.terulet;
        }
        public void setKerulet()
        {
            this.kerulet = 2 * (this.a + this.b);
        }
        public int getKerulet()
        {
            return this.kerulet;
        }
    }

    internal class Program
    {
        enum nyomtat { oldal, kerter, osszes}
        static void Main(string[] args)
        {
            // Első példa
            Negyszog n1 = new Negyszog();
            kiir(n1, nyomtat.oldal);
            n1.setA(5);
            n1.setB(6);

            kiir(n1, nyomtat.oldal);

            n1.setTerulet();
            n1.setKerulet();

            kiir(n1, nyomtat.kerter);

            //Második példa
            Negyszog n2 = new Negyszog(6, 2);
            kiir(n2, nyomtat.oldal);

            n2.setTerulet();
            n2.setKerulet();

            kiir(n2, nyomtat.oldal);

            n2.getTerulet();
            n2.getKerulet();

            kiir(n2, nyomtat.kerter);

            // Harmadik négyzet példa
            Negyszog n3 = new Negyszog(2);
            kiir(n3, nyomtat.oldal);

            n3.setTerulet();
            n3.setKerulet();

            kiir(n3, nyomtat.oldal);

            n3.getTerulet();
            n3.getKerulet();

            kiir(n3, nyomtat.kerter);

            Console.ReadKey();
        }
        // Metódus
        static private void kiir(Negyszog obj, nyomtat v)
        {
            if (v == nyomtat.oldal)
            {
                Console.WriteLine($"Az n1 négyszög oldalai: a = {obj.getA()}, b = {obj.getB()}");
            }
            else
            Console.WriteLine($"Az n1 négyszög területe = {obj.getTerulet()}, kerulete = {obj.getKerulet()}");
        }
    }
}
