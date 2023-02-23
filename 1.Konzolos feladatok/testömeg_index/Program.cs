using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testömeg_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Testtömeg[kg]: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Testmagasság[cm]: ");
            double h = double.Parse(Console.ReadLine());
            h = h / 100;
            double tti = m / Math.Pow(h, 2);
            Console.WriteLine("Testtömegindex: {0}", tti);
            Console.Write("Testsúlyosztály: ");
            if (tti < 16) Console.WriteLine("Súlyos soványság");
            else if (tti < 17) Console.WriteLine("Mérsékelt soványság");
            else if (tti < 18.5) Console.WriteLine("Enyhe soványság");
            else if (tti < 25) Console.WriteLine("Normális testsúly");
            else if (tti < 30) Console.WriteLine("Túlsúlyos");
            else Console.WriteLine("Elhízás");
            Console.ReadLine();
        }
    }
}
