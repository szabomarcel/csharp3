using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodfokuegyenletOOP
{
    struct masodfoku
    {
        public int egyenlet;
    }
    internal class masodfokuszamolas
    {
        // Osztályváltozók
        private int a;
        private int b;
        private int c;
        private int d;

        public masodfokuszamolas(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public masodfokuszamolas() { }
        
        // Eredményekátadó metódus
        public string GetMasodfokuszamolas()
        {
            return this.GetMasodfokuszamolas();
        }
        public string Masodfoku()
        {
            double d = b * b - 4 * a * c;
        }
    }
}
