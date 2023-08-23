using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fejvagyiras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hányszor dobjuk fela a pénzt? ");
            int db = int.Parse(Console.ReadLine());

            int fej = 0; 
            int iras = 0;

            for (int i = 0; i < db; i++)
            {
                Random veletlen = new Random();
                int dobas = veletlen.Next(0,100);
                if(dobas % 2 == 0)
                {
                    fej++;
                }
                else
                {
                    iras++;
                }
            }
            Console.WriteLine("{0} db fej, {1} db iras.", fej, iras);
            Console.ReadLine();
        }
    }
}
