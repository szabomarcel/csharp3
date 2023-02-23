using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_or_Derived
{
    class Base
    {
        ~Base() 
        {
            Console.WriteLine("Base");
        }

    }
    class Derived : Base
    {
        ~Derived()
        {
            Console.WriteLine("Derived");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            Console.ReadKey(); 
        }
    }
}
