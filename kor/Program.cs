using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class Kor
    {   // Osztályváltozók
        private int r; // "r" oldal
        private int terulet;
        private int kerulet;
        private int sugar;
        
        // Konstrokturok
        public Kor() { }

        public Kor(int r)
        {
            this.r = r;
        }
        public Kor(int r) { this.r = r;}

        // Metódusok
        public void setR(int r)
        {
            if (r > 1000)
            {
                Console.WriteLine("Az oldal nem lehet nagyobb, mint ezer");
            }
            else
                this.r = r;
        }
        public int getR() { return r;}
        public void setTerulet()
        {
            this.terulet = Math.PI * this.r;
        }
        public int getTerulet()
        {
            return this.terulet;
        }
        public void setKerulet()
        {
            this.kerulet = 2 * this.r * Math.PI;
        }
        public int getKerulet()
        {
            return this.kerulet;
        }
        public void setSugar() { return r; }
        public int getSugar() { return terulet; }
    }
}
    
internal class Program
{
    enum nyomtat { oldal, kerter, osszes }
    static void Main(string[] args)
    {
        Kor r = new Kor();
        kiir(r, nyomtat.oldal);
        r.setA(1);

        kiir(r, nyomtat.oldal);

        r.setTerulet();
        r.setKerulet();
        r.setSugar();

        kiir(r, nyomtat.kerter);
        Console.WriteLine();
        Console.ReadKey(); 
    }
    // Metódus
    static private void kiir(Kor obj, nyomtat v)
    {
        if (v == nyomtat.oldal)
        {
            Console.WriteLine($"Az n1 négyszög oldalai: a = {obj.getR()}");
        }
        else if { Console.WriteLine($"Az n1 négyszög területe = {obj.getTerulet()}, kerulete = {obj.getKerulet()}"); }
        else { Console.WriteLine($"Az n1 négyszög sugara = {obj.getSugara()}"); }
    }
}
