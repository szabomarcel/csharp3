using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        //  Adatok beolvasása fájlból vagy generálása a programban, majd elhelyezése listában.
       
        private void setFilename()
        {
            StreamWriter f = new StreamWriter(@"C:\Users\Lenovo\Source\Repos\csharp\BaratokOOP\bin\Debug\fajlnev");
            List<string> listFriend = new List<string>();
        }
        
        // Új barát felvétele a listába
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

        // Barát törlése a listából név alapján


        // Annak ellenőrzése, hogy egy személy szerepel-e a listában


        // Lista kiíratása fájlba.A fájl neve: baratok.csv


        // 1.-B Barátok osztály bővítése
        // Táblázatba kiíratja a szülő osztályt + bővítés



        /*
        * 1.-C Barátok osztály bővítése
        * Lapozás előre-hátra képernyőnként 20 rekord kiírással kalkulálva!
        * A lapozást a PageUp és PageDown gombokkal lehessen megvalósítani!
        * Ezenfelül a Home billentyűvel lehessen az első, az End billentyűvel az utolsó lapra ugorni!
        */



        /*
        * 1.-D Barátok osztály bővítése
        * A szülő osztályt új metódussal bővítjük, amely a lista alapján határozza meg,
        * hogy van-e elég olyan barátunk, akikkel egy születésnapi bulit tudunk összehozni!
        * Ehhez olyan barátokra van szükségünk, akik életkora hasonló a miénkhez(+/- 3 év) és bulizási hajlama legalább 5-ös skálaértékű.A buli minimális létszáma 10 fő.
        * Amennyiben van elég barátunk, írjuk ki a neveiket a buli.csv fájlba!
        */



    }
}
