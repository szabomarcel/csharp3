using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class Kor
    {
        private int r;
        private double Kerulet;
        private double Terulet;
        public Kor() { }
        public Kor(int r)
        {
            this.r = r;
        }

        public void setR(int r)
        {
            this.r = r;
        }
        public int getR(int r) { return this.r = r; }
        public double setKerulet() => this.Kerulet = 2 * this.r * Math.PI;
        public double getKerulet()
        {
            return this.Kerulet;
        }
        public double setTerulet() => this.Terulet = Math.Pow(r, 2) * Math.PI;
        public double getTerulet()
        {
            return this.Terulet;
        }
    }
    class hasab : Kor
    {
        public int m;
        public double A;
        public double V;


        public hasab() : base() { }

        public hasab(int m, int r) : base(r) { this.m = m; }

        public void setM(int m) { this.m = m; }

        public void setKor()
        {
            base.setKerulet();
            base.setTerulet();
        }
        public void setV()
        {
            this.V = base.getTerulet() * this.m;
        }
        public void setA()
        {
            this.A = 2 * (base.getTerulet()) + (base.getKerulet() * this.m);
        }
        public double getV()
        {
            return this.V;
        }
        public double getA()
        {
            return this.A;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            hasab teszt1 = new hasab(7, 9);
            teszt1.setKor();
            teszt1.setV();
            teszt1.setA();

            Console.WriteLine($"{teszt1.getV()}, {teszt1.getA()}");
            Console.ReadKey();
        }
    }
}
