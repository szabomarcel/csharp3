using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autotipus
{
    internal class Kamion : Jarmuvek
    {
        readonly string rendszam, uzemanya;

        public Kamion(string rendszam, string uzemanya) : base("Kamion", rendszam)
        {
            this.rendszam = rendszam;
            this.uzemanya = uzemanya;
        }
        public string Rendszam => rendszam;
        public string Uzemanya => uzemanya;
        public override string diesel()
        {
            return "Az autó diesel-el megy.";
        }
        public override string electric()
        {
            return "Az autó electric-ossal megy.";
        }
        public override string ToString()
        {
            return rendszam;
        }
    }
}
