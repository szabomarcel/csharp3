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
            Console.WriteLine("Kérem adja meg az életkorát:");
            int E = int.Parse(Console.ReadLine());
            int a = 0;
            DateTime d = DateTime.Now;
            foreach (var i in this.list)
            {
                
                if(i.hajlam >= 5 && )
            }
            Console.ReadLine();
        }
        #endregion Bulizás
    }
}
