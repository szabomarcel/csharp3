using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratOOP
{

    internal class BaratPage : Barat
    {
        #region Kontructor
        public BaratPage() { } // Meghívja az őskontructort
        #endregion Kontructor
        #region Page
        public void Page()
        {
            /*
            Console.WriteLine("Nyomd meg egy gombot.");
            ConsoleKeyInfo k = Console.ReadKey();
            Console.WriteLine("\n");
            if (k.Key == ConsoleKey.Home)
            {
                Console.WriteLine("");
            }
            Console.ReadKey();
            */

            int lapmeret = 15;
            ConsoleKeyInfo p;
            int i = 0, j = 0;
            bool kilepes = false;

            do
            {
                Console.Clear();
                for (j = i; j < this.list.Count && j < lapmeret; j++)
                {
                    Console.WriteLine($"{this.list[j].Name,-20}; " +
                        $"{this.list[j].szulido.ToShortDateString(),10}; " +
                        $"{this.list[j].hajlam,1};  " +
                        $"{this.list[j].nem,1}"); // Erre az objectumra hivatkozom
                }
                p = Console.ReadKey();
                
                switch (p.Key)
                {
                    case ConsoleKey.PageUp: // PageUp
                        i = (j >= lapmeret) ? j - lapmeret : 0;
                        break;
                    case ConsoleKey.PageDown: // PageDown
                        i = j;
                        break;
                    case ConsoleKey.Home: // Home
                        i = 0;
                        break;
                    case ConsoleKey.End: // End
                        i = this.list.Count - lapmeret;
                        break;
                    case ConsoleKey.Escape: // ESC                    
                        kilepes = true;
                        break;
                    default:
                        Console.WriteLine("Csak a következő billentyűket használhatod: PageUp, PageDown, Home, End és ESC");
                        break;
                }
            } while (!kilepes);
        }
        #endregion Page
    }
}
