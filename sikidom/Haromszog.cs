using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Haromszog : Sikidom
    {
        public double aOldal;
        public double bOldal;
        public double cOldal;
        public double mMagassag;

        public Haromszog(double parameter1) : base("Háromszög", parameter1, 0)
        {
            this.aOldal = parameter1;
            this.bOldal =parameter1;
            this.cOldal = parameter1;
        }
        public override double Terulet() { return (aOldal * mMagassag + bOldal * mMagassag + cOldal * mMagassag) / 2; }
        public override double Kerulet() { return aOldal + bOldal + cOldal; }
    }
}
