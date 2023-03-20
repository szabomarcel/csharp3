using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimleteresOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írjon be egy összeget:");
            int penz = Convert.ToInt32(Console.ReadLine());
            int cimlet_helye = 0;
            while (penz >= 0 && penz <= 20000)
            {
                int mennyiseg = penz / penzfajtak(cimlet_helye);
                penz = penz % penzfajtak(cimlet_helye);
                Console.WriteLine("{0} darab {1} Ft-os", mennyiseg);
                cimlet_helye++;
            }
            Console.ReadLine();
        }
    }
}
