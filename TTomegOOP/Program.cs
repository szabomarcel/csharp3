using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTomegOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testömeg tömbje
            int[,] data = new int[0, 30];

            // Példányosítás 
            TestTomeg atest = new TestTomeg(data);

            // Elvégeztetem vele a számításokat
            atest.GetTesttomeg();

            Console.ReadKey();
        }
        private static void prTesttomeg(TestTomeg p)
        {
            Testtomeg[] tomegAdats = new Testtomeg[30];
            tomegAdats = p.GetTesttomeg();


            if (tomegAdats[0].tomeg >= 0)
            {
                Console.WriteLine("A megadot tömege: ");
            }
            else
            {
                Console.WriteLine("A megadot testömege ");
                for (int i = 0; i < tomegAdats.Length; i++)
                {
                    Console.WriteLine("{0} {1}: {2}", tomegAdats[i].tomeg);
                }
            }
        }
        private static void prTestMagasság(TestTomeg k)
        {
            TestMagassag[] testMagassag = new TestMagassag[120];
            testMagassag = k.GetTestMagassag();
            if (testMagassag[0].magass <= 100)
            {
                Console.WriteLine("Túl alacsony!");
            }
            else
            {
                Console.WriteLine("Túl magass");
            }
        }

    }
}
