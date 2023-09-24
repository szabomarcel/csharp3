using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Paralelogramma : Sikidom
    {
        public double aOldal;
        public double bOldal;
        public double mMagassag;

        public Paralelogramma(double parameter1) : base("Paralelogramma", parameter1, 0)
        {
            this.aOldal = parameter1;
            this.bOldal = parameter1;
        }
        public override double Terulet() { return aOldal * mMagassag; }
        public override double Kerulet() { return 2 * (aOldal + bOldal); }
    }
}
