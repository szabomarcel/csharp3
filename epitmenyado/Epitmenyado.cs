using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;

namespace epitmenyado
{
    internal class Epitmenyado 
    {
        struct Telkek
        {
            public int Adoszam;
            public string Utca;
            public string Haz_szam;
            public char Sav;
            public int Alap_terulet;
        }
        static public int A_sav = 0;
        static public int B_sav = 0;
        static public int C_sav = 0;
        static int ado(char Ado_sav, int Ter)
        {
            int Negyzetm = 0;
            if (Ado_sav == 'A')
            {
                Negyzetm = A_sav;
            }
            if (Ado_sav == 'B')
            {
                Negyzetm = B_sav;
            }
            if (Ado_sav == 'C')
            {
                Negyzetm = C_sav;
            }
            int Fiz_ado = Negyzetm * Ter;
            if (Fiz_ado < 10000)
            {
                Fiz_ado = 0;
            }
            return Fiz_ado;
        }
        static void Main(string[] args)
        {
            List<Telkek> adatok = new List<Telkek>();
            string[] darabol;
            Telkek adat = new Telkek();
            StreamReader sr = new StreamReader("utca.txt", Encoding.Default);
            darabol = sr.ReadLine().Split(' ');
            A_sav = Convert.ToInt32(darabol[0]);
            B_sav = Convert.ToInt32(darabol[0]);
            C_sav = Convert.ToInt32(darabol[0]);
            while (!sr.EndOfStream)
            {
                darabol = sr.ReadLine().Split(' ');
                adat.Adoszam = Convert.ToInt32(darabol[0]);
                adat.Utca = darabol[1];
                adat.Haz_szam = darabol[2];
                adat.Sav = Convert.ToChar(darabol[3]);
                adat.Alap_terulet = Convert.ToInt32(darabol[4]);
                adatok.Add(adat);
            }
            sr.Close();
            Console.WriteLine($"2. Feladat: A mintában {adatok.Count} telek szereoek. "); // Counttal ki lehet íratni, hogy mennyi eleme van a kistának.
            Console.WriteLine("3. Feladat: Egy tulajdonos adószám: ");
            int megadott = Convert.ToInt32(Console.ReadLine());
            int db = 0;
            int A_ossz = 0;
            int B_ossz = 0;
            int C_ossz = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Adoszam == megadott)
                {
                    Console.WriteLine($"{adatok[i].Utca} utca {adatok[i].Haz_szam}");
                    db++;
                }
                if (adatok[i].Sav == 'A')
                {
                    A_ossz += ado(adatok[i].Sav, adatok[i].Alap_terulet);
                }
                if (adatok[i].Sav == 'B')
                {
                    B_ossz += ado(adatok[i].Sav, adatok[i].Alap_terulet);
                }
                if (adatok[i].Sav == 'C')
                {
                    C_ossz += ado(adatok[i].Sav, adatok[i].Alap_terulet);
                }
            }
            if (db == 0)
            {
                Console.WriteLine("Nem szerepel az adatállományban.");
            }
            Console.WriteLine("5. Feladat: ");
            Console.WriteLine($"A sávba {adatok.Count(x => x.Sav == 'A')} telek esik, az adó {A_ossz} Ft");
            Console.WriteLine($"B sávba {adatok.Count(x => x.Sav == 'B')} telek esik, az adó {B_ossz} Ft");
            Console.WriteLine($"C sávba {adatok.Count(x => x.Sav == 'C')} telek esik, az adó {C_ossz} Ft");
            Console.WriteLine("6. Feladat: A több sávba sorolt utcák: ");
            string akt_utca = adatok[0].Utca;
            char akt_adosav = adatok[0].Sav;
            bool tobb_sav = false;
            for (int i = 1; i < adatok.Count; i++)
            {
                if (akt_utca == adatok[i].Utca && akt_adosav != adatok[i].Sav)
                {
                    tobb_sav = true;
                }
                if (akt_utca != adatok[i].Utca)
                {
                    if (tobb_sav)
                    {
                        Console.WriteLine($"{akt_utca}");
                    }
                    akt_utca = adatok[i].Utca;
                    akt_adosav = adatok[i].Sav;
                    tobb_sav = false;
                }
            }
            int[] adoszamok = adatok.Select(x => x.Adoszam).Distinct().ToArray();
            int[] fiz_adok = new int[adoszamok.Length];
            StreamWriter sw = new StreamWriter("fizetendo.txt");
            for (int i = 0; i < adoszamok.Length; i++)
            {
                for (int j = 0; j < adatok.Count; j++)
                {
                    if (adoszamok[i] == adatok[j].Adoszam)
                    {
                        fiz_adok[i] += ado(adatok[j].Sav, adatok[j].Alap_terulet);
                    }
                }
                sw.WriteLine($"{adoszamok[i]} {fiz_adok[i]}");
            }
            sw.Close();
            Console.ReadLine();
        }
    }
}
