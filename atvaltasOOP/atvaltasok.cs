using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvaltasOOP
{
    struct atvalt
    {
        public string atvaltas;
    }
    internal class atvaltasok
    {
        // Osztályváltozók
        private int n;
        private byte c;

        // Konstruktor
        public atvaltasok(int n, byte c)
        {
            this.n = n;
            this.c = c;
        }
        public atvalt GetAtvalt()
        {
            return GetAtvalt();
        }

        // Hőfok kiszámítás
        public void Szamitas() 
        {
            switch (c)
            {
                case 1:
                    Console.WriteLine("{0} F∘ = {1} C∘", n, (n - 32) * 5 / 9); break;
                case 2:
                    Console.WriteLine("{0} C∘ = {1} F∘", n, (n * 9 / 5) + 32); break;
            }
        }    
    }
}
