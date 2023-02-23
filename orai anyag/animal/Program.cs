using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    internal class Program
    {
        enum Animal {Cat = 2, Dog =5, Tiger, Wolf };
        static void Main(string[] args)
        {
            Animal a = Animal.Cat;            
            Animal b = Animal.Tiger;

            // Érték típusos változók nulla értéke
            int c = 0;
            string d = "";

            // Nullázható  érték típusok deklarálása
            int? x = null; 

            if (a != b)
            {
                Console.WriteLine("Az Macska nem egy tigris...");
            }
            Console.WriteLine("Macska indexe: {0}", (int)Animal.Cat);
            Console.WriteLine("Kutya indexe: {0}", (int)Animal.Dog);
            Console.WriteLine("Farkas indexe: {0}", (int)Animal.Wolf);
            Console.ReadKey();
        }
    }
}
