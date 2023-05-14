using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BaratokOOP
{
    internal class Baratok
    {
        // Osztályváltozók
        private string fileName;
        private FileMode fileMode;
        private FileAccess fileAccess;
        private FileStream fs;
        private StreamReader sr;

        // Konstruktor
        public Baratok()
        {
            setFilename(); // Fájl nevének bekérése
            setFileMode(); // MEgnyitás módjának bekérése
            setFileAccess(); // Hozzásférés módjánakbeállitása
            eletkor(); // Az életkor eldöntése
            egySzemely(); // Egy személy ellenőrtzése a listába amikor egy van.
        }
        //  Adatok beolvasása fájlból vagy generálása a programban, majd elhelyezése listában.
       
        private void setFilename()
        {
            StreamWriter f = new StreamWriter(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
            List<string> listFriend = new List<string>();
        }

        // Új barát felvétele a listába
        // 1.-B Barátok osztály bővítése
        // Táblázatba kiíratja a szülő osztályt + bővítés
        private void setFileMode()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adja meg a műveletet: "); // Létrehoz egy új fájl, ha már létezik, a tartalmát kitörli
            Console.WriteLine("     cr:  Create"); // Mint előbb, de ha már létezik a fájl, akkor kivételt dob
            Console.WriteLine("     crn: CreateNew"); //Megnyit egy fájlt, ha nem létezik, akkor kivételt dob
            Console.WriteLine("     o:   Open"); // Mint előbb, de ha nem létezik a fájl, akkor kivételt dob
            Console.WriteLine("     oc:  OpenOrCreate"); // Mint előbb, de ha nem létezik, akkor létrehozza a fájlt.
            Console.WriteLine("     a:   Append"); // Megnyit egy fájlt és automatikusan a végére áll. Ha nem létezik, létrehozza.
            Console.WriteLine("     t:   Truncate"); // Megnyit egy létező fájlt és törli a tartalmát.  Ebben a módban a fájl  tartalmát nem lehet olvasni (egyébként kivételt dob).
            do
            {
                ismet = false;
                s = Console.ReadLine();
                switch (s)
                {
                    case "cr": fileMode = FileMode.Create; break;
                    case "crn": fileMode = FileMode.CreateNew; break;
                    case "o": fileMode = FileMode.Open; break;
                    case "oc": fileMode = FileMode.OpenOrCreate; break;
                    case "a": fileMode = FileMode.Append; break;
                    case "t": fileMode = FileMode.Truncate; break;
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet = true;
                        break;
                }
            } while (ismet);
        }
        private void setFileAccess()
        {
            bool ismet;
            string s;

            Console.WriteLine("Adj meg a fájl hozzáférést: ");
            Console.WriteLine("     r:  Olvasás");
            Console.WriteLine("     w:  Írás");
            Console.WriteLine("     rw: Olvasás és írás");

            do
            {
                ismet = false;
                s = Console.ReadLine();
                switch (s)
                {
                    case "r": fileAccess = FileAccess.Read; break;
                    case "w": fileAccess = FileAccess.Write; break;
                    case "rw": fileAccess = FileAccess.ReadWrite; break;                    
                    default:
                        Console.WriteLine("Hibás adat! Ismételje meg!");
                        ismet = true; break;
                }
            } while (ismet);
        }
        private void listafeltoltes() // Lista feltöltés az új nevekhez + baráttal
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 11; i++)
                list.Add(i);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        // Barát törlése a listából név alapján
        private void torles() // Barát + lista törlése
        {
            for (int i = fileName.Length - 1; i >= 0; i--)
            {
                if (fileName[i] % 2 == 0)
                {
                    fileName.RemoveAt(i);
                }
            }
            return;
        }

        // Annak ellenőrzése, hogy egy személy szerepel-e a listában
        private string egySzemely()
        {
            listafeltoltes();
            Console.WriteLine("A lista elemei: ");
            foreach(var elem in listafeltoltes())
            {
                Console.WriteLine(elem);
            }
        }

        // Lista kiíratása fájlba.A fájl neve: baratok.csv
        private void fajlkiiras()
        {
            Baratok a = new Baratok();
            StreamWriter f = new StreamWriter(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
            string[] s;
            double atl = 0, sz = 0;
            while (g.Peek() != -1)
            {
                s = g.Readline().Split('_');
                a.nev = s[0];
                a.eletkor = int.Parse(s[1]);
                atl = atl + a.eletkor;
                sz++;
            }
        }

    /*
    * 1.-C Barátok osztály bővítése
    * Lapozás előre-hátra képernyőnként 20 rekord kiírással kalkulálva!
    * A lapozást a PageUp és PageDown gombokkal lehessen megvalósítani!
    * Ezenfelül a Home billentyűvel lehessen az első, az End billentyűvel az utolsó lapra ugorni!
    */

    private static int aktuális = 2;

        private void btnTovább_Click(object sender, EventArgs e)
        {
            aktuális++;
            aktuális = aktuális > 6 ? 1 : aktuális;
            Baratok.Bal = "" + (aktuális - 1 < 1 ? 6 : aktuális - 1).ToString() + "";
            Baratok.Középső = "" + (aktuális).ToString() + "";
            Baratok.Jobb = "" + (aktuális + 1 > 6 ? 1 : aktuális + 1).ToString() + "";

        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            aktuális--;
            aktuális = aktuális < 1 ? 6 : aktuális;
            Baratok.Bal = "" + (aktuális - 1 < 1 ? 6 : aktuális - 1).ToString() + "";
            Baratok.Középső = "" + (aktuális).ToString() + "";
            Baratok.Jobb = "" + (aktuális + 1 > 6 ? 1 : aktuális + 1).ToString() + "";

        }

        /*
        * 1.-D Barátok osztály bővítése
        * A szülő osztályt új metódussal bővítjük, amely a lista alapján határozza meg,
        * hogy van-e elég olyan barátunk, akikkel egy születésnapi bulit tudunk összehozni!
        * Ehhez olyan barátokra van szükségünk, akik életkora hasonló a miénkhez(+/- 3 év) és bulizási hajlama legalább 5-ös skálaértékű.A buli minimális létszáma 10 fő.
        * Amennyiben van elég barátunk, írjuk ki a neveiket a buli.csv fájlba!
        */

        private void eletkor()
        {
            int a = 0, b = 0; // Válzozó bekérés
            bool a_ertek_helyes_e = false; // Eldöntöm, hogy igaz e vagy hamis az a_érték
            bool b_ertek_helyes_e = false; // Eldöntöm, hogy igaz e vagy hamis az b_érték
            while (a_ertek_helyes_e != true) // Elöltesztelő a a_értékre amikor igaz
            {
                Console.Write("Kérem adja meg az életévét");
                a = int.Parse(Console.ReadLine());
                if (a >= 3 && a <= 3) a_ertek_helyes_e = true;
            }
            while (b_ertek_helyes_e != true) // Elöltesztelő a b_értékre amikor igaz
            {
                Console.Write("Kérem adja meg az életévét");
                b = int.Parse(Console.ReadLine());
                if (b >= 3 && b <= 3) b_ertek_helyes_e = true;
            }
            if (a > b) // Amikor az a > mint a b akkor eldöntse, hogy mehet e bulizni vagy nem.
            {
                int x = a - b;
                if (x < 3 || x > 3)
                {
                    Console.WriteLine("Nem mehetsz Bulizni! ");
                }
                else
                    Console.WriteLine("Mehetsz bulizni.");
            }
        }
    }
}
