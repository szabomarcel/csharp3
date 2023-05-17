using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratOOP
{
    struct Page
    {
        public string Name; // Szöveges név változó
        public DateTime szulido; // Dátum változó DateTime-ban
        public char nem; // Nem változó char-ban
        public int hajlam;  // Hajlam int-be
    }
    internal class BaratPage
    {
        
        public static void ZoomIn(object sender, EventArgs e)
        {
            if (e.Up > 0)
            {
                // A felhasználó felfelé görgetett.
            }
            else if (e.Down < 0)
            {
                // A felhasználó lefelé görgetett.
            }
        }
    }
}
