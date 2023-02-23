using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace igazolatlan_hianyzasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hiányzások: ");
            int hianyzas;
            hianyzas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hianyzas);
            if (hianyzas >= 10)
            {
                Console.WriteLine("Add meg a születési dátumodat(yyyy/mm/dd)");
                DateTime datum;
                datum = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(hianyzas);
                int a = 10;
                int b = 15;
                int c = 20;
                int d = 30;
                if(hianyzas >= a)
                {
                    Console.WriteLine("Az első kategória\r\nfigyelmeztetést");
                }
                else if (hianyzas >= b)
                {
                    Console.WriteLine("A második osztályfőnöki intőt");
                }
                else if (hianyzas >= c)
                {
                    Console.WriteLine("A harmadik igazgatói megrovást");
                }
                else if (hianyzas >= d)
                {
                    Console.WriteLine("A negyedik kategória pedig felfüggesztést von maga után");
                }
                else
                {
                    Console.WriteLine("A büntetés mértékét szintén\r\njelezzük a felhasználó felé.");
                }

                Console.ReadKey();
            }
        }
    }
}
