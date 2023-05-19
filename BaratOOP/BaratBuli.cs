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
            int koraiEv = DateTime.Now.Year - 20;
            List<Barat> ret = new List<Barat>();
            int E = int.Parse(Console.ReadLine());
            int a = 0;
            DateTime d = DateTime.Now;
            foreach (var i in this.list)
            {
                Console.WriteLine("Írd be a hajlami szintedett: ");
                if (i.hajlam >= 5 && i.szulido.Year <= koraiEv)
                    ret.Add(i);
            }
            Console.ReadLine();
        }
        #endregion Bulizás
    }
}
