using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("html.txt");
            string nev = Console.ReadLine();
            sw.WriteLine("<html>");
            sw.WriteLine("<head></head>");
            sw.WriteLine("<body>");
            sw.WriteLine("<h1Csá>" +nev+ "!</h1>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();
        }
    }
}
