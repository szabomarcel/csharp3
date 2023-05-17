using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratokOOP
{
    struct Lista
    {
        public string Name; // Szöveges név változó
        public DateTime szulido; // Dátum változó DateTime-ban
        public char nem; // Nem változó char-ban
        public int hajlam;  // Hajlam int-be
    }
    internal class BaratokScreen
    {
        #region Konstructor
        public BaratokScreen() { }
        #endregion Konstructor

        #region Képernyőre listázás
        public void listazas()
        {
            StreamReader olvas = new StreamReader(@"C:\\Users\\Lenovo\\Source\\Repos\\csharp\\BaratOOP\\teszt.csv");
            string szoveg;
            while (!olvas.EndOfStream)
            {
                szoveg = olvas.ReadLine();
                Console.WriteLine(szoveg);
            }
            olvas.Close();
        }
        #endregion Képernyőre listázás
    }
}
