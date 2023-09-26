using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autotipus
{
    abstract class Jarmuvek
    {
        public string uzemanyag;
        public string rendszamtabala;

        protected Jarmuvek(string uzemanyag, string rendszamtabala)
        {
            this.uzemanyag = uzemanyag;
            this.rendszamtabala = rendszamtabala;
        }

        public abstract string benzin();
        public abstract string diesel();
        public abstract string electric();
        public override string ToString()
        {
            return uzemanyag;
        }
    }
}
