using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratOOP
{
    struct Lista
    {
        public string Name; // Szöveges név változó
        public DateTime szulido; // Dátum változó DateTime-ban
        public char nem; // Nem változó char-ban
        public int hajlam;  // Hajlam int-be
    }
    internal class BaratScreen : Barat
    {
        #region Konstructor
        public BaratScreen() { } // Meghívja az őskontructort
        #endregion Konstructor

        #region Képernyőre listázás
        public void listazas()
        {            
            foreach (var item in this.list)
            {
                Console.WriteLine($"{item.Name, -20}; " +
                    $"{item.szulido.ToShortDateString(), 10}; " +
                    $"{item.hajlam, 1};  " +
                    $"{item.nem, 1}");                
            }
        }
        #endregion Képernyőre listázás
    }
}
