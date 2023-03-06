using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace haromszog
{
    class haromszog
    {
        private int a;
        private int b;
        private int c;
        private double Kerulet;
        private double Terulet;
        public haromszog() { }
        public haromszog(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void setA(int a)
        {
            this.a = a;
        }
        public int getA(int a) { return this.a = a; }
        public void setB(int b)
        {
            this.b = b;
        }
        public int getB(int b) { return this.b = b; }
        public void setC(int c)
        {
            this.c = c;
        }
        public int getC(int c) { return this.c = c; }
        public double setKerulet() => this.Kerulet = a + b + c;  
        public double getKerulet()
        {
            return this.Kerulet;
        }
        public double setTerulet()
        {
            double s = (double)(this.a + this.b + this.c) / 2;
            this.Terulet = Math.Round(Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c)), 2);
        } 
        public double getTerulet()
        {
            return this.Terulet;
        }
    }
    class hasab : haromszog
    {
        public int m2;
        public double terfogat;
        public double felszin;
        public hasab() : base() { }

        public hasab(int a, int b, int c) : base(a, b, c) { this.m2 = m2;}
        

        public void setM2(int m2) { this.m2 = m2; }

        public void set()
        {
            base.setKerulet();
            base.setTerulet();
        }
        public void setV()
        {
            this.terfogat = base.getTerulet() * this.m2;
        }
        public void setA()
        {
            this.felszin = base.getKerulet() * this.m2 + 2 * base.getTerulet();
        }
        public int getTerfogat() { return this.terfogat; }
        public int getFelszin() { return this.felszin; }
    }
    internal class Program
    {
        enum nyomtat { oldal, kerter, osszes }
        static void Main(string[] args)
        {

            haromszog h1 = new haromszog();
            kiir(h1, nyomtat.oldal);

            h1.setA(3);
            h1.setB(5);
            h1.setC(6);

            kiir(h1, nyomtat.oldal);
            h1.setTerulet();
            h1.setKerulet();
            kiir(h1, nyomtat.kerter);

            Console.WriteLine();

            Console.WriteLine("hasáb példa");
            hasab h2 = new hasab();
            h2.setharomszog();
            h2.setTerfogat();
            h2.setFelszin();

            Console.WriteLine($"Felszín:{h2.getFelszin()}, Térfogat:{h2.getTerfogat()}");

            Console.ReadKey();
        }
        static private void kiir(haromszog obj, nyomtat v)
        {
            if (v == nyomtat.oldal)
            {
                Console.WriteLine($"A h1 háromszög oldalai: a={obj.getA()}, b = {obj.getB()}, c={obj.getC()}");
            }
            else
                Console.WriteLine($"A h1 háromszög területe ={obj.getTerulet()}, kerület = {obj.getKerulet()}");

        }
        static private void kiir(int a, int b, int c)
        {
        }
        
    }
}
