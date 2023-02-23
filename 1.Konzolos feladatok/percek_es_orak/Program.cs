using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percek_es_orak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ora,
                perc,
                mperc;

            // Első időpont beolvasása
            Console.WriteLine("Adja meg az első órát!");
            ora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg az első percet!");
            perc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg az első másodpercet!");
            mperc = Convert.ToInt32(Console.ReadLine());
            
            // Második időpont beolvasása
            Console.WriteLine("Adja meg az második órát!");
            DateTime elso = new DateTime(2000, 02, 02, ora, perc, mperc);
            ora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg az második percet!");
            perc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg az második másodpercet!");
            mperc = Convert.ToInt32(Console.ReadLine());
            DateTime masik = new DateTime(2000, 02, 02, ora, perc, mperc);
            
            // A két időpont külömbsége
            TimeSpan k = elso - masik;
            
            // Kiíratás
            Console.WriteLine(k.ToString());
            Console.ReadKey();
        }
    }
}
