﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortOOP
{
    internal class Tort
    {
        // Konstruktor
        private int a = 0; // Az a oldal = 0-val
        private int x;
        private int b = 0; // Az b oldal = 0-val
        private int y;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public Tort() { }
        public Tort(int a, int b, int x, int y) // Az oldalak =-ek önmagukkal
        {
            this.a = a;
            this.x = a;
            this.y = a;
            this.b = b;
        }

        // Számláló beállitása
        public void szamlalo() // Tört számolása
        {
            Console.WriteLine("A tört számláló:");
            int a = int.Parse(Console.ReadLine());
            int x = a;
        }

        // Nevező beállitása
        public void nevezo() // Nevező kiszámítása
        {
            int b = int.Parse(Console.ReadLine());
            int y = b;
        }

        // Tört meghatározása
        public void tort() // Tört számolás
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                    b = b - a;
            }
        }

        // Eredmény lekérése
        public void eredmeny() // Eredmény kiszámítása
        {
            int szamolas = Math.Max(a, b);
        }

    }
}
