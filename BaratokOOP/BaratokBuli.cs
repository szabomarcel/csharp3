using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratokOOP
{
    struct Buli
    {
        public string Name; // Szöveges név változó
        public DateTime szulido; // Dátum változó DateTime-ban
        public char nem; // Nem változó char-ban
        public int hajlam;  // Hajlam int-be
    }
    internal class BaratokBuli
    {
        #region Konstructor
        public BaratokBuli() { }
        #endregion Konstructor
        #region Bulizás
        public void bulizas()
        {
            Console.WriteLine("Kérem adja meg az életkorát:");
            int E = int.Parse(Console.ReadLine());
            int a = 0;

            if (E > 0) a = 1;
            if (E > 7) a = 2;
            if (E > 19) a = 3;
            if (E > 65) a = 4;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Gyerek");
                    break;
                case 2:
                    Console.WriteLine("Iskolás");
                    break;
                case 3:
                    Console.WriteLine("Felnőtt");
                    break;
                case 4:
                    Console.WriteLine("Nyugdijas");
                    break;
                default:
                    Console.WriteLine("Rossz éréket adott meg.");
                    break;
            }
            Console.ReadLine();
        }
        #endregion Bulizás
    }  
}
