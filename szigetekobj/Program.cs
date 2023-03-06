using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetekobj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.példa
            string s;
            if (true) 
            {
                s = "0011111101110000001111110011110";
                Szigetszamolas sz1 = new Szigetszamolas();
                sz1.setData(s);
                sz1.szamol();
                Console.WriteLine($"A szigetek száma: {sz1.getIslandCount()}, a sziget leghosszabb hossz: {sz1.getMaxIslandLenght()}");
            }
            #endregion

            #region 2.példa
            string s2;
            if (true) 
            {
                s2 = "0011111101110000001111110011110";
                Szigetszamolas sz2 = new Szigetszamolas();
                sz2.setData(s2);
                sz2.szamol();
                Console.WriteLine($"A szigetek száma: {sz2.getIslandCount()}, a sziget leghosszabb hossz: {sz2.getMaxIslandLenght()}");
            }
            #endregion
            Console.ReadKey();

        }
    }
}
