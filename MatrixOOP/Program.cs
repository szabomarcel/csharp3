using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOOP
{
    internal class Program : Matrix
    {
        public static Random rnd = new Random();
        // függvénnyel való haszbálat
        static void Main(string[] args)
        {
            // Létrehozás
            int[,] matrix = new int[5, 10]; 
            
            // Feltöltés
            for (int i = 0; i < 5; i++) // sor közötti lépkedés
            {
                for (int j = 0; j < 10; j++) // oszlop (elemek) közötti lépkedés
                {
                    matrix[i, j] = this.rnd.Next(1, 20); // Adott elem feltöltése
                }
            }

            // Kiíratás
            for (int i = 0; i < 5; i++) // sor közötti lépkedés
            {
                for (int j = 0; j < 10; j++) // oszlop (elemek) közötti lépkedés
                {
                    Console.WriteLine("{0}\t", matrix[i,j]); // adott elem kiíratása 
                }
                Console.WriteLine(); // Az adott sor kiíratása után sortörést készítünk
            }

            #region Függvényekkel való használata
            // Függvényhasználat:
            Console.WriteLine("Ez a függvényel létrehozott mátrix:");
            int[,] ezisegymatrix = this.RandomMatrixLetrehozas(4,5); // Létrehozó függvénye meghívása
            this.MatrixKiirat(ezisegymatrix); // Kiirandó függvény meghívása
            #endregion
            Console.ReadLine();
        }
    }
}
