using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokuCLI
{
    internal class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        // Konstruktor
        public Feladvany(string sor) // paramétert kap azaz a sort és elteszi a Lezdő értékbe majd kiszámol
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol() // Kiírja a feladvány tartalmát
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
