using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olvashiba
{
    internal class Program
    {
        int szam;
        public void Hibakezel()
        {
            while (true)
            {
                Console.WriteLine("Szám: ");
                try
                {
                    szam = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("A beírt szam: {0} ", szam);
            }
        }
        static void Main(string[] args)
        {
            Program hibakezel = new Program();
            hibakezel.Hibakezel();
            Console.ReadKey();
        }
    }
}
