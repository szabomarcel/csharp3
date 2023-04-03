using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    internal class Program
    {
        class Kivetel
        {
            public Kivetel() { }
            #region Nincs kivétel kezelés
            public void KivKezNincs()
            {
                Console.WriteLine("Nincs kivétel kezelés\nAdjon meg egy szamot!");
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
                Console.ReadKey();
            }
            #endregion Nincs kivétel kezelés

            #region Általános kivételkezelés
            public void KivKezAlt()
            {
                Console.WriteLine("\nHiba objektum nélküli kivételkezelés\nAdjon meg egy karakter!");
                try
                {
                    int szam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A beírt szám: {0}",szam);
                }
                catch 
                {
                    throw;
                }
                Console.ReadKey();
            }
            #endregion Általános kivételkezelés

            #region Őshiba ubjektummal
            public void KivKetOs()
            {
                Console.WriteLine("\nŐs Hiba objektummal kiveételkezelés\nAdjon meg egy számot!");
                try
                {
                    int szam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A beírt szám: {0}", szam);
                }
                catch(Exception eh)
                {
                    Console.WriteLine(eh.ToString());
                }
                Console.ReadKey();
            }
            #endregion Őshiba ubjektummal

            #region Hiba objehtummal
            public void KivKezObj()
            {
                Console.WriteLine("\nSaját Hiba objektummal kivételkezelés\nAdjon meg egy karaktert!");
                try
                {
                    int szam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A beírt szám: {0}", szam);
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
            #endregion Hiba objehtummal
        }
        static void Main(string[] args)
        {
            Kivetel kivetel = new Kivetel();
            //kivetel.KivKezNincs();
            //kivetel.KivKezAlt();
            //kivetel.KivKetOs();
            //kivetel.KivKezObj();
        }
    }
}
