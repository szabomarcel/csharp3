using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Negyzet : Sikidom
    {
        double aOldal;

        public Negyzet(double parameter1) : base("Negyzet", parameter1, 0)        
        {
            this.aOldal = parameter1;
        }

        public override double Terulet() {return this.aOldal * aOldal; }
        public override double Kerulet() { return this.aOldal * 4; }
    }
}
