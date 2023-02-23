using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dog
{
    class Dog
    {
        private string nev = "Rex";
        private int ev = 5;

        public Dog(string nev, int ev)
        {
            this.nev = nev;
            this ev = ev;
        }
        public Dog(Dog otherDog) : this(otherDog.nev, otherDog.ev) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Puli", 2);
            Console.ReadKey();
        }
    }
}
