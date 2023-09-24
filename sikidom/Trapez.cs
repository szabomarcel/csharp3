using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Trapez : Sikidom
    {
        public double aOldal;
        public double bOldal;
        public double cOldal;
        public double dOldal;
        public double mMagassag;

        public Trapez(double parameter1) : base("Trapez", parameter1, 0)
        {
            this.aOldal = parameter1;
            this.bOldal = parameter1;
            this.cOldal = parameter1;
            this.dOldal = parameter1;
            this.mMagassag = parameter1;
        }
        public override double Terulet(){ return (aOldal + cOldal) * mMagassag;}
        public override double Kerulet() { return ((aOldal + cOldal) * mMagassag) / 2; }
    }
}
