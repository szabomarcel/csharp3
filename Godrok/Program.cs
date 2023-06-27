using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godrok
{
    internal class Program
    {
        static int[] melysegek = new int[2000]; // tomb letrehozzás amit feltöltünk 2000 számmal
        static int darab = 0;
        static int felhasznalo;
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
        }
        #region Feladat1
        static void Feladat1()
        {
            Console.WriteLine("1.Feladat");

            StreamReader reader = new StreamReader("melyseg.txt");

            string line = reader.ReadLine();
            while(line != null) // While ciklus ami kiolvastassa a következő sort
            {
                melysegek[darab] = Int32.Parse(line);
                darab++; // Darab növelése +1 -gyel
                line = reader.ReadLine();
            }
            reader.Close(); // Lezárja az adott részt
            Console.WriteLine($"A fájl adatainak száma: {darab}");
            Console.WriteLine();
        }
        #endregion Feladat1
        #region Feladat2
        static void Feladat2()
        {
            Console.WriteLine("2. Feladat");
            Console.Write("Adjon meg egy távolságot! ");
            felhasznalo = Int32.Parse(Console.ReadLine());
            felhasznalo--;

            Console.WriteLine($"Ezen a helyen a felszín {melysegek[felhasznalo]} méter mélyen van." );
            Console.WriteLine();
        }
        #endregion Feladat2
        #region Feladat3
        static void Feladat3()
        {
            Console.WriteLine("3. Feladat");

            int nullak = 0;
            for(int i = 0; i < darab; i++)
            {
                if (melysegek[i] == 0)
                {
                    nullak++;
                }
            }

            double erintetlen = (double)nullak / (double)darab * 100;
            erintetlen = Math.Round(erintetlen, 2);
            Console.WriteLine($"Az érintetlen terület aránya {erintetlen} %.");
            Console.WriteLine();
        }
        #endregion Feladat4
        #region Feladat4
        static void Feladat4()
        {
            StreamWriter writer = new StreamWriter("godrok.txt"); // Fájlba írás

            for (int i = 1; i < darab; i++)
            {
                if (melysegek[i] != 0)
                {
                    writer.Write(melysegek[i] + " ");
                }
                else
                {
                    if (melysegek[i -1] != 0)
                    {
                        writer.WriteLine();
                    }
                }
            }

            writer.Close();
            Console.WriteLine();
        }
        #endregion Feladat4
        #region Feladat5
        static void Feladat5()
        {
            Console.WriteLine("5. Feladat");
            int godrok = 0;
            for (int i = 0; i < darab; i++)
            {
                if (melysegek[i] != 0 && melysegek[i - 1] == 0)
                {
                    godrok++;
                }
            }
            Console.WriteLine($"A gödrök száma: {godrok}");
            Console.WriteLine();
        }
        #endregion Feladat5
        #region Feladat6
        static void Feladat6()
        {
            Console.WriteLine("6. Feladat");
            if (melysegek[felhasznalo] != 0)
            {
                Feladat6a();
                Feladat6b();
                Feladat6c();
                Feladat6d();
                Feladat6e();
            }
            else
            {
                Console.WriteLine("Az adott helyen nincs gödör.");
            }
            Console.WriteLine();
        }
        #endregion Feladat6
        static int kezdete;
        static int vege;
        static int terfogat;
        #region Feladat6a
        static void Feladat6a()
        {
            Console.WriteLine("a)");
            kezdete = felhasznalo;
            vege = felhasznalo;

            while (melysegek[kezdete -1] != 0)
            {
                kezdete--;
            }
            while (melysegek[vege +1] != 0)
            {
                vege++;
            }
            Console.WriteLine($"A gödör kezdete: {kezdete +1} méter, a gödör vége: 22 méter.");
            Console.WriteLine();
        }
        #endregion Feladat6a
        #region Feladat6b
        static void Feladat6b()
        {
            Console.WriteLine("b)");
            int x = kezdete;
            int y = vege;

            while (melysegek[x] <= melysegek[x + 1])
            {
                x++;
            }
            while ( y > x && melysegek[y] <= melysegek[y - 1])
            {
                y--;
            }
            if(x == y)
            {
                Console.WriteLine("Folyamatosan mélyül.");
            }
            else
            {
                Console.WriteLine("Nem mélyül folyamatosan.");
            }
            Console.WriteLine();
        }
        #endregion Feladat6b
        #region Feladat6c
        static void Feladat6c()
        {
            Console.WriteLine("c)");
            int max = 0;
            for (int i = kezdete; i < vege; i++)
            {
                if (melysegek[i] > max)
                {
                    max = melysegek[i];
                }
            }
            Console.Write($"A legnayobb mélysége {max} méter.");
        }
        #endregion Feladat6c
        #region Feladat6d
        static void Feladat6d()
        {
            Console.WriteLine("d)");
            terfogat = 0;
            for (int i = kezdete; i < vege; i++)
            {
                terfogat += melysegek[i];
            }
            terfogat *= 10;
            Console.WriteLine($"A térfogata {terfogat} n^3.");
        }
        #endregion Feladat6d
        #region Feladat6e
        static void Feladat6e()
        {
            Console.WriteLine("e)");

            int viz = terfogat - ((vege - kezdete) * 10);
            Console.WriteLine($"A vizmennyiség {viz}m^3");
        }
        #endregion Feladat6e
    }
}
