using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace matrixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matr = new int[2, 2]; // Két dimenziós mátrix tömb. 
            for (int i = 0; i < 2; i++) // For ciklu az i-edik elemre
            {
                for (int j = 0; j < 2; j++) // For ciklu az j-edik elemre
                {
                    Console.Write("Kérem az {0}. sor {1}. elemét: ", i + 1, j + 1);
                    matr[i, j] = int.Parse(Console.ReadLine()); // Mátrix konvertálás
                }
            }
            Console.WriteLine();
            Console.WriteLine("A matrix: ");
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}     ", matr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int det = matr[0, 0] * matr[1, 1] - matr[0, 1] * matr[1, 0];
            Console.WriteLine("A mátrix determinánsa: {0}", det);
            Console.WriteLine();
        }
    }
}
