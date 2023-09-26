using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace autotipus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jarmuvek> jarmu = new List<Jarmuvek>();
            jarmu.Add(new Furgon(uzemanya));
            jarmu.Add(new Kamion());
            jarmu.Add(new Autobusz());
            jarmu.Add(new Munkagep());
            jarmu.Add(new Auto());
            foreach (var item in jarmu)
            {
                if (item.GetType().Equals(typeof(Furgon)))
                {
                    Furgon furgon = (Furgon)item; // -- Csak így juthatunk az egyedi adathoz, a sugérhoz
                    //Console.WriteLine($"\nAz 1. elem {item.GetType()} - {item}");
                    Console.WriteLine($"A téglatest Felszine: ");
                }
                else if (item.GetType().Equals(typeof(Kamion)))
                {
                    Kamion kamoin = (Kamion)item;
                    Console.WriteLine($"\nA kocka Felszine: ");
                }
                else if (item.GetType().Equals(typeof(Autobusz)))
                {
                    Autobusz autobusz = (Autobusz)item;
                    Console.WriteLine($"\nA henger Felszine: ");
                }
                else if (item.GetType().Equals(typeof(Munkagep)))
                {
                    Munkagep munkagep = (Munkagep)item;
                    Console.WriteLine($"\nA henger Felszine: ");
                }
                else if (item.GetType().Equals(typeof(Auto)))
                {
                    Auto auto = (Auto)item;
                    Console.WriteLine($"\nA henger Felszine: ");
                }
            }
            Console.ReadLine();
        }
    }
}
