using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ceges.auto
{
    internal class Program
    {
        struct Adatok 
        {
            public int nap;
            public string ido;
            public string rendszam;
            public int azonosito;
            public int km_szamlalo;
            public int allapot;
        }
        struct Km_mero
        {
            public int kezdet;
            public int veg;
        }
        static void Main(string[] args)
        {
            #region 1.Feladat
            List<Adatok> ceg = new List<Adatok>();
            string sor;
            Adatok seged;
            StreamReader sr = new StreamReader("autok.txt");

            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                seged.nap = Convert.ToInt32(sor.Split(' ')[0]);
                seged.ido = (sor.Split(' ')[1]);
                seged.rendszam = (sor.Split(' ')[2]);
                seged.azonosito = Convert.ToInt32(sor.Split(' ')[3]);
                seged.km_szamlalo = Convert.ToInt32(sor.Split(' ')[4]);
                seged.allapot = Convert.ToInt32(sor.Split(' ')[5]);
                ceg.Add(seged);

            }
            sr.Close();
            for (int i = 0; i < ceg.Count; i++)
            {
                Console.WriteLine(ceg[i].rendszam);
            }
            #endregion 1.Feladat
            #region 2.Feladat
            Console.WriteLine("2. Feladat");
            for (int i = ceg.Count - 1; i >=0; i--)
            {
                if (ceg[i].allapot == 0)
                {
                    Console.WriteLine("{0}. nap rendszám: {1}", ceg[i].nap, ceg[i].rendszam);
                    break;
                }
            }
            #endregion 2.Feladat
            #region 3.Feladat
            int be_nap;
            Console.WriteLine("3. Feladat");
            Console.Write("Nap: ");
            be_nap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Forgalom a(z) {0}. napon: ", be_nap);
            for (int i = 0; i < ceg.Count; i++)
            {
                if (ceg[i].nap == be_nap && ceg[i].allapot == 0)
                {
                    Console.WriteLine("{0} {1} {2} ki", ceg[i].ido, ceg[i].rendszam, ceg[i].azonosito);
                }
                else if (ceg[i].nap == be_nap && ceg[i].allapot == 1)
                {
                    Console.WriteLine("{0} {1} {2} be", ceg[i].ido, ceg[i].rendszam, ceg[i].azonosito);
                }
            }
            Console.ReadLine();
            #endregion 3.Feladat
            #region 4.Feladat
            Console.WriteLine("4. Feladat");
            int ki_vitel = 0, be_vitel = 0;
            for (int i = 0; i < ceg.Count; i++)
            {
                if (ceg[i].allapot == 0)
                {
                    ki_vitel++;
                }
                else
                {
                    be_vitel++;
                }
            }
            Console.WriteLine("A ónap végén {0} autót nem hoztak vissza.", ki_vitel - be_vitel);
            #endregion 4.Feladat
            #region 5.Feladat
            Console.WriteLine("5. Feladat");
            Km_mero[] km = new Km_mero[10];
            int index = 0;

            for (int i = 0; i < 10; i++)
            {
                km[i].kezdet = 0;
                km[i].veg = 0;
            }
            for (int i = 0; i < ceg.Count; i++)
            {
                index = ceg[i].rendszam[5] - '0';
                if (km[index].kezdet == 0 && ceg[i].allapot == 0)
                {
                    km[index].kezdet = ceg[i].km_szamlalo;
                }
                else if (ceg[i].km_szamlalo == 1)
                {
                    km[index].veg = ceg[i].km_szamlalo;
                }
                // Console.WriteLine(index);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} {1} km", i, km[i].veg - km[i].kezdet);
            }
            Console.ReadLine();
            #endregion 5.Feladat
            #region 6.Feladat
            Console.WriteLine("6. Feladat");
            int kivalasztott_szemely = 0, leghosszabb = 0;
            for (int i = 0; i < ceg.Count - 1; i++)
            {
                if (ceg[i].allapot == 0)
                {
                    for (int j = 0; j < ceg.Count; j++)
                    {
                        if (ceg[i].azonosito == ceg[j].azonosito)
                        {
                            if(leghosszabb < (ceg[j].km_szamlalo - ceg[i].km_szamlalo))
                            {
                                leghosszabb = (ceg[j].km_szamlalo - ceg[i].km_szamlalo);
                                kivalasztott_szemely = ceg[i].azonosito;
                            }
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Leghosszabb út: {0} km, személy: {1}", leghosszabb, kivalasztott_szemely);
            Console.ReadLine();
            #endregion 6.Feladat
            #region 7.Feladat
            Console.WriteLine("7. Feladat");
            string be_rendszam;
            bool van_par = false;
            Console.Write("Rednszám: ");
            be_rendszam = Console.ReadLine();
            StreamWriter sw = new StreamWriter(be_rendszam + "_menetlevel.txt");
            for (int i = 0; i < ceg.Count; i++)
            {
                if (ceg[i].rendszam == be_rendszam)
                {
                    van_par = false;
                    for (int j = 0; j < ceg.Count; j++)
                    {
                        if(ceg[i].azonosito == ceg[j].azonosito)
                        {
                            sw.Write("{0}\t{1}.\t{2}\t{3} km\t{4}.\t{5}\t{6} km\n", ceg[i].azonosito, ceg[i].nap, ceg[i].km_szamlalo, ceg[j].azonosito, ceg[j].nap, ceg[j].km_szamlalo);
                            van_par = true;
                            i = j;
                            break;
                        }
                    }
                    if (!van_par)
                    {
                        sw.Write("{0}\t{1}.\t{2}\t{3} km\n", ceg[i].azonosito, ceg[i].nap, ceg[i].km_szamlalo);
                    }
                }
            }
            sw.Close();
            Console.WriteLine("Menetlevél kész.");
            Console.ReadLine();
            #endregion 7.Feladat
        }
    }
}
