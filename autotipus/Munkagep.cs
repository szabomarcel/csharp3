using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autotipus
{
    internal class Munkagep
    {
        readonly string rendszam, uzemanya;

        protected Munkagep( string rendszam, string uzemanya) : base("Munkagep", rendszam)
        {
            this.rendszam = rendszam;
            this.uzemanya = uzemanya;
        }
        public string Rendszam => rendszam;
        public string Uzemanya => uzemanya;

        public abstract string diesel();
        public abstract string electric();
        public override string ToString()
        {
            return uzemanyag;
        }
    }
}
