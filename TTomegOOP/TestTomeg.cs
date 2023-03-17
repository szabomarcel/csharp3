using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTomegOOP
{
    struct Testtomeg
    {
        public string tomeg; // A testtömeg nev
    }
    struct TestMagassag
    {
        public string magass; // A testmagasság
    }
    internal class TestTomeg
    {
        // Osztlyváltozók
        private int[,] testtomeg = null; // A testtömeg megadása


        // Konstuktor
        public TestTomeg(int[,] p)
        {
            this.Equals(p);
        }

        // Tömeg bekérés
        int m = int.Parse(Console.ReadLine());
        private Testtomeg testT;
        private TestMagassag testM;

        // Súly bekérés
        public Testtomeg GetTesttomeg()
        {
            return testT;
        }
    
        public TestMagassag GetTestMagassag()
        {
            return testM;
        }
        // Testtömeg index kiszámítása
        private void testTomeg()
        {
            int testtomeg = 0;
            if (testtomeg < 16) 
            {
                Console.WriteLine("Súlyosan soványság");
            }
            else if (testtomeg < 17) 
            {
                Console.WriteLine("Mérsékelt soványság");
            }
            else if (testtomeg < 18.5)
            {
                Console.WriteLine("Enyhe soványság");
            }
            else if (testtomeg < 25)
            {
                Console.WriteLine("Normális soványság");
            }
            else if (testtomeg < 30)
            {
                Console.WriteLine("Túlsúlyos");
            }
        }


        // Testtömeg index lekérése
        public int this [int index]
        {
            get => testTomeg[index];
            set => testTomeg[index];
        }
    }
}
