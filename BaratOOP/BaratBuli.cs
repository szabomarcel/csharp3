using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratOOP
{
    internal class BaratBuli : Barat // Származtatott osztály
    {
        #region Konstructor
        public BaratBuli() { }
        #endregion Konstructor
        #region Bulizás
        public void bulizas()
        {
            Console.WriteLine("Kérem adja meg az életkorát: ");
            List<Barat> ev = new List<Barat>();
            int koraiEv = DateTime.Now.Year - 20;
            int E = int.Parse(Console.ReadLine());
            int a = 0;
            DateTime d = DateTime.Now;
            foreach (var i in this.list)
            {
                Console.WriteLine("Írd be a hajlami szintedett: ");
                if (i.hajlam >= 5 && i.szulido.Year <= koraiEv)
                    ev.Add(i);
                else if (i.hajlam <= 5 && i.szulido.Year <= a)
                {
                    Console.WriteLine("Nem alkalmas a bulizásra.");
                }
                else
                {
                    Console.WriteLine("Tilos a bulizás.");
                }
            }
            Console.ReadLine();
        }
        #endregion Bulizás
    }
}
