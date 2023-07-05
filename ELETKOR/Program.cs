using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELETKOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az életkorát: ");
            int E = int.Parse(Console.ReadLine());
            int a = 0;
            if (E >= 0 && E < 7) a = 1;
            if (E >= 7 && E < 22) a = 2;
            if (E >= 19 && E < 66) a = 3;
            if (E >= 65) a = 4;
            switch (a)
            {
                case 1: Console.WriteLine("Gyermek."); break;
                case 2: Console.WriteLine("Iskolás."); break;
                case 3: Console.WriteLine("Felnőtt."); break;
                case 4: Console.WriteLine("Nyugdíjas."); break;
                default: Console.WriteLine("Rossz értéket adott meg."); break;
            }
            Console.ReadLine();
        }
    }
}
