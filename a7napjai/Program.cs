using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7napjai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy számot 1 - 7 között: ");
            int napkod = int.Parse(Console.ReadLine());
            bool helyes_e_az_ertek = false;
            while(helyes_e_az_ertek != true)
            {
                if(napkod >= 1 && napkod <= 7)
                    helyes_e_az_ertek = true;
                else
                {
                    Console.WriteLine("Rossz értéket adott meg!");
                    Console.WriteLine("Kérem adjon meg egy számot 1 - 7 között: ");
                    napkod = int.Parse(Console.ReadLine());
                }
            }
            switch (napkod)
            {
                case 1: Console.WriteLine("Hétfő"); break;
                case 2: Console.WriteLine("Kedd"); break;
                case 3: Console.WriteLine("Szerda"); break;
                case 4: Console.WriteLine("Csütörtök"); break;
                case 5: Console.WriteLine("Péntek"); break;
                case 6: Console.WriteLine("Szombat"); break;
                case 7: Console.WriteLine("Vasárnap"); break;
            }
            Console.ReadLine();
        }
    }
}
