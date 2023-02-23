using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tömb deklarálás
            int sor = 10; // Tömb mérete
            int oszlop = 10; // Tömb mérete
            int alsoHatar = 10, // Generált számok alsó határok
                felsohatar = 1000; // Generált számok felső határok
            int[,] tomb = new int [sor, oszlop];
            Random rnd = new Random();

            // Tömb feltöltése véletlen számokkal
            for (int i = 0; i < sor; i++)
            {
                for (int  j = 0; j < oszlop; j++)
                {
                    tomb[i, j] = rnd.Next(alsoHatar, felsohatar);
                }
            }

            // Tömb kiíratás
            for (int i = 0; i < tomb.Length; i++)
                for (int j = 0; j < tomb.Length; j++)
                {
                    Console.Write(tomb[i,j] + ",");
                }
            
            // A sor végén soremelés
            Console.WriteLine();

            // Tömb kiíratás 2
            Console.WriteLine("Kiíratás foreach-csel");
            foreach (int i in tomb)
            {
                Console.WriteLine(i + ",");
            }
            Console.ReadKey();
        }
    }
}
