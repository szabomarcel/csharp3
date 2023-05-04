using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mennyit számok generáljak: ");
            int mennyiseg = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Mi legyen a file-nak a neve?");
            string fileName = Console.ReadLine();

            Random rnd = new Random();
            using (StreamWriter writer = new StreamWriter(fileName + "txt"))
            {
                int szamok = rnd.Next(1, 1000);
                writer.WriteLine(szamok);
            }
                /*
                Random rnd = new Random();
                Console.WriteLine("Mennyit számok generáljak: ");
                int mennyiseg = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < mennyiseg; i++)
                {
                    int szamok = rnd.Next(1, 1000);
                    Console.WriteLine(szamok);
                }
                Console.WriteLine("Mi legyen a file-nak a neve?");
                string file = Console.ReadLine();
               */
                Console.ReadKey();
        }
    }
}
