using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outer
{
    internal class Program
    {
        class Outer
        {
            private int value = 11;
            private Inner child;
            public Outer()
            {
                child= new Inner(this);
            }
            public void Do()
            {
                child.Do();
            }
            class Inner
            {
                Outer parent; // a beágyazott osztály nem látható
                public Inner(Outer o)
                {
                    parent = o;
                }
                public void Do()
                {
                    Console.WriteLine(parent.value);
                }
            }
        }
        class Outer2
        {
            public class Inner2
            {
                // így már látszik
            }
        }
        // ...
        Outer.Inner x = new Outer2.Inner2(); //példányosítás
        static void Main(string[] args)
        {
        }
    }
}
