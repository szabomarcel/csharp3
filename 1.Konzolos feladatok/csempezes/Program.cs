using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burkolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A szélesség méterben: ");
            double sz = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("A hosszúság méterben: ");
            double h = double.Parse(Console.ReadLine());
            double t = sz * h;
            Console.WriteLine();
            Console.WriteLine("A konyhánk területe: {0} m2", t);
            double cs = 0.2 * 0.2;
            double db = t / cs;
            double osszes = db + 0.1 * db;
            Console.WriteLine();
            Console.WriteLine("A szüséges csempe mennyisége: {0:0.00} db", osszes);
            Console.ReadLine();
        }
    }
}
