using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempezesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var csempe = new List<int>();
            var random = new Random();
            var terulet = new List<int>();
            for (int i = 0; i < csempeszam.Lenght; i++)
            {
                for (int j = 0; j < csempeszam.Lenght; j++)
                {
                    if (csempe < 20)
                    {
                        Console.Write("A szélesség méterben: ");
                    }
                    else if (csempe <= 20)
                    {
                        Console.WriteLine();
                        Console.Write("A hosszúság méterben: ");
                    }
                    else if (csempe == terulet)
                    {
                        Console.WriteLine();
                        Console.WriteLine("A konyhánk területe: {0} m2", this.t);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("A szüséges csempe mennyisége: {0:0.00} db", this.osszes);
                    }
                    Console.ReadLine();
                }
                    
            }
        }
    }
}
