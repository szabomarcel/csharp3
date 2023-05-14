using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Konzol calculator a c#-ban\r");
            Console.WriteLine("--------------------------\n");
            
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("Írja be az első számot:");
                numInput1 = Console.ReadLine();

                double cleanNum1;
                while(!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Ez nem kimenet. Kérem írja be újra");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Írja be a számot és üse le az entert:");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Ez nem kimenet. Kérem írja be újra");
                    numInput2 = Console.ReadLine();
                }
                Console.WriteLine("Operátorok amik választhatóak");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("A te beállitásod?");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DeOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Ez egy matematikai operátor hiba.\n");
                    }
                    else Console.WriteLine("Te eredményed: {0:0.##}\0", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh nem! Kivétel történt a számolás során.\n - Details: " + e.Message);
                }
                Console.WriteLine("--------------------------\n");
                Console.Write("Nyomja meg az 'n' és Enter billentyűt az alkalmazás bezárásához, vagy nyomja meg bármelyik másik billentyűt és Entert a folytatáshoz: ");
                if(Console.ReadLine()== "n") endApp = true;
                Console.WriteLine("\n");
            }
            return;
        }
    }
}