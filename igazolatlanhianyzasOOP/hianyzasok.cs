using igazolatlanhianyzasOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igazolatlanhianyzasOOP
{
    struct hiany
    {
        public int x;
    }
    internal class hianyzasok
    {
        // Osztályváltozók
        int a = 10;
        int b = 15;
        int c = 20;
        int d = 30;
        int hianyzas;
        public hianyzasok() { }
        public hianyzasok(int a, int b, int c, int d, int hianyzas)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.hianyzas = hianyzas;
        }
        public double gethianyzas()
        {
            return this.hianyzas;
        }
        // Hiányzás számítsá
        public void hianyasszamitas()
        {
            if (hianyzas >= a)
            {
                Console.WriteLine("Az első kategória\r\nfigyelmeztetést");
            }
            else if (hianyzas >= b)
            {
                Console.WriteLine("A második osztályfőnöki intőt");
            }
            else if (hianyzas >= c)
            {
                Console.WriteLine("A harmadik igazgatói megrovást");
            }
            else if (hianyzas >= d)
            {
                Console.WriteLine("A negyedik kategória pedig felfüggesztést von maga után");
            }
            else
            {
                Console.WriteLine("A büntetés mértékét szintén\r\njelezzük a felhasználó felé.");
            }
        }
    }
}
