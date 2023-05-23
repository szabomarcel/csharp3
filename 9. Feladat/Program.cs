using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("html.txt");
            sw.WriteLine("<table>");
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine("<tr>");
                for(int j = 0; j < 20; j++)
                {
                    sw.WriteLine("\t\t<td>");
                    sw.WriteLine("\t\t</td>");
                }
                sw.WriteLine("\t</tr>");
            }
            sw.WriteLine("</table>");
            sw.Close();

        }
    }
}
