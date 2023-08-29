using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tarsalgo_18maj
{
    internal class Program
    {
        static List<int> ora = new List<int>();
        static List<int> perc = new List<int>();
        static List<int> szemaz = new List<int>();
        static List<string> beki = new List<string>();
        static List<int> szemelyek = new List<int>();
        static List<int> athaladas = new List<int>();
        static int szemazon;
        static void Main(string[] args)
        {
            // 1.Feladat
            feladat_1();
            feladat_2();
            feladat_3();
            feladat_4();
            feladat_5();
            feladat_6();
            feladat_7();
            feladat_8();
            Console.ReadLine(); 
        }

        private static void feladat_8()
        {
            Console.WriteLine("8. Feladat");
            int belep = 0;
            int kilep = 0;
            int percek = 0;
            bool kilepett = false;
            for (int i = 0; i < szemaz.Count; i++)
            {
                if (szemaz[i] == szemazon)
                {
                    if (beki[i] == "be")
                    {
                        percek = ora[i] * 60 + perc[i];
                        kilepett = false; 
                    }
                    else
                    {
                        kilep = ora[i] * 60 + perc[i];
                        percek += kilep - belep;
                        kilepett = true;
                    }
                }
            }
            if (!kilepett)
            {
                percek += 15 * 60 - belep;
                Console.WriteLine("A(z) {0}. személy összesen 18 percet volt bent, a megfigyelés\r\nvégén a társalgóban volt.", szemazon, percek);
            }
            else
            {
                Console.WriteLine("A(z) {0}. személy összesen 18 percet volt bent, a megfigyelés\r\nvégén nem volt a társalgóban.", szemazon, percek);
            }
        }

        private static void feladat_7()
        {
            Console.WriteLine("7. Feladat");
            for (int i = 0; i < szemaz.Count; i++)
            {
                if (szemaz[i] == szemazon)
                {
                    if (beki[i] == "be")
                    {
                        Console.Write("{0}:{1}-", ora[i], perc[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", ora[i], perc[i]);
                    }
                }
            }
            Console.WriteLine(); Console.WriteLine();
        }

        private static void feladat_6()
        {
            Console.WriteLine("\n6. Feladat");
            Console.Write("Adja meg a szemályk azonosítóját!");
            szemazon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        private static void feladat_5()
        {
            Console.WriteLine("\n\n5. Feladat");
            // List<int> folista = new List<int>();
            int fo = 0;
            int maxfo = 0;
            int maxhely = 0;
            for (int i = 0; i < beki.Count; i++)
            {
                if (beki[i] == "be")
                {
                    fo++;
                }
                else
                {
                    fo--;
                }
                if (fo > maxfo)
                {
                    maxfo = fo;
                    maxhely = i;
                }
            }
            Console.WriteLine("{0}:{1}-kor voltak a legtöbben a társaégóban.", ora[maxhely], perc[maxhely]);
        }

        private static void feladat_4()
        {
            Console.WriteLine("\n4. Feladat");
            Console.Write("A végén a társalgóban voltak: ");
            for (int i = 0; i < athaladas.Count; i++)
            {
                if (athaladas[i] % 2 == 1)
                {
                    Console.Write(szemelyek[i] + " "); 
                }
            }
        }

        private static void feladat_3()
        {
            for (int i = 0; i < szemaz.Count; i++)
            {
                if (szemelyek.Contains(szemaz[i]))
                {
                    athaladas[szemelyek.IndexOf(szemaz[i])]++;
                }
                else
                {
                    szemelyek.Add(szemaz[i]);
                    athaladas.Add(1);
                }
            }
            for (int i = 0; i < szemelyek.Count - 1; i++)
            {
                int minhely = i;
                for (int j = i + 1; j < szemelyek.Count; j++)
                {
                    if (szemelyek[j] < szemelyek[minhely])
                    {
                        minhely = j;
                    }
                }
                if(minhely != i)
                {
                    int csere = szemelyek[i];
                    szemelyek[i] = szemelyek[minhely];
                    szemelyek[minhely] = csere;
                    csere = athaladas[i];
                    athaladas[i] = athaladas[minhely];
                    athaladas[minhely] = csere;
                }
            }
            StreamWriter sw = new StreamWriter("athaladas.txt");
            for (int i = 0; i < szemelyek.Count; i++)
            {
                sw.WriteLine(szemelyek[i] + " " + athaladas[i]);
            }
            sw.Close();
        }

        private static void feladat_2()
        {
            Console.WriteLine("\n2. Feladat");
            Console.WriteLine("Az első belépő: {0}", szemaz[0]);
            Console.WriteLine("Az utolsó kilépő: {0}", utolso_kilepo());
        }

        private static object utolso_kilepo()
        {
            int i = beki.Count - 1;
            while (i >= 0 && beki[i] != "ki")
            {
                i--;
            }
            if (i >= 0)
            {
                return szemaz[i];
            }
            else
            {
                return -1;
            }
        }

        private static void feladat_1()
        {
            StreamReader sr = new StreamReader("ajto.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(' ');
                ora.Add(int.Parse(adatok[0]));
                perc.Add(int.Parse(adatok[1]));
                szemaz.Add(int.Parse(adatok[2]));
                beki.Add(adatok[3]);
            }
            sr.Close();
        }
    }
}
