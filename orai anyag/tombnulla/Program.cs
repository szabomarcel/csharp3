using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombnulla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tömb deklarálás
            int hossz = 10; // Tömb mérete
            int alsoHatar = 10, // Generált számok alsó határok
                felsohatar = 1000; // Generált számok felső határok
            int[] tomb = new int[hossz]; 
            Random rnd = new Random();
            
            // Tömb feltöltése véletlen számokkal
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(alsoHatar, felsohatar);
            }

            // Tömb kiíratás
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

            // Tömb kiíratás 2
            foreach (int i in tomb)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
