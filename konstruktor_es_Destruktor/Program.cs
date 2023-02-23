using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor_es_Destruktor
{
    class DestructableClass
    {
        public DestructableClass()
        {
            Console.WriteLine("Konstruktor");
        }
        ~DestructableClass()
        {
            Console.WriteLine("Destruktor");
        }
        finally
        {
            base.Finalize();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DestructableClass dc = new DestructableClass();
            Console.ReadKey();
        }
    }
}