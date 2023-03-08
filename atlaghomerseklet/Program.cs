using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlaghomerseklet
{
    internal class Program
    {
        static void Main()
        {
            // nap: átlag hőmérséklete
            #region
            honap[] nap = new honap[3];
            nap[0] = new honap("Első nap");
            nap[1] = new honap("Második nap");
            nap[2] = new honap("Harmadik nap");
            Console.WriteLine("Az átlag hömérsélet: ");
            foreach (honap random in Random)
            {
                Console.WriteLine(nap.GetTemp(3));
            }
            nap[0].GetMinTemp() = "Atlaghomerseklet";
            nap[1].GetMinTemp() = "Atlaghomerseklet";
            #endregion

            // honap: átlag hőmérséglete
            #region
            honap[] honap = new honap[3];
            honap[0] = new honap("Első hónap");
            honap[1] = new honap("Második hónap"); 
            honap[2] = new honap("Harmadik hónap");
            Console.WriteLine("Az átlag hömérsélet: ");
            foreach (honap random in Random)
            {
                Console.WriteLine(honap.GetTemp(3));
            }
            honap[0].GetMinTemp() = "Atlaghomerseklet";
            honap[1].GetMaxTemp() = "Atlaghomerseklet";
            #endregion

            Console.Write("Adj meg egy hőmérséklet értékét:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Válassz opciót: (1) Nap (2) Hónap : ");
            byte c = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (c)
            {
                case 1:
                    Console.WriteLine("{0} Nap"); break;
                case 2:
                    Console.WriteLine("{0} Hónap"); break;
            }
            Console.ReadKey();
            Console.ReadLine();
        }
       
    }
}
