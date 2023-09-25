using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Teglalap : Sikidom
    {
        double aOldal;
        double bOldal;

        public Teglalap(double parameter1) :  base("Téglatest", parameter1, 0)
        {
            this.aOldal = parameter1;
            this.bOldal = parameter1;
        }
        public override double Terulet(){ return this.aOldal + bOldal; }
        public override double Kerulet() { return (2 * this.aOldal) + ( 2 * bOldal) ; }
    }
}
