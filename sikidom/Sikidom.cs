using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    abstract class Sikidom
    {
        public string nev;
        public double parameter1;
        public double parameter2;
        public Sikidom(string nev, double parameter1, double parameter2)
        {
            this.nev = nev;
            this.parameter1 = parameter1;
            this.parameter2 = parameter2;
        }
        public abstract double Terulet();
        public abstract double Kerulet();
        public override string ToString()
        {
            return this.nev;
        }
    }
}
