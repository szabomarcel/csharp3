using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozatOOP
{
    struct Lista
    {
        public string Namecar; // Autó nev változó
        public DateTime gyartas; // Gyártási év változója
        public char rendszam; // Rendszám változó
        public int uzemanyag;  // Üzemanyga változó
        public int szin; // Meghatározó szín változó
        public int abroncsmeret; // Abroncsméretű változó
        public int kilometerallas; // Mennyirt futott az autó változó
        public int uleszam; // Utasokkal ellátott változó
    }
    internal class auto
    {
        #region Kontrucktor
        // Üres konstructor a classhoz
        public auto() { }
        #endregion Kontrucktor
        #region Metodusok
        #region Marka
        // Az autó márkája bekérése és elndöntése
        private static string path = "..\\..\\"; // link deklarálásra vonatkozik ami lehet 4 byte is
        private static string intfile = "automarka.csv"; // link deklarálásra vonatkozik ami lehet 4 byte is
        public static void autonev()
        {
            FileStream fs = new FileStream(path + intfile, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                List<auto> marakanev = new List<auto>(); // Márkanév listázása 
                Console.WriteLine("Írja be az autó markáját: ");
                string marka = Console.ReadLine();
                int i; // index változó
                while (marka.Length != 20) // 20 karakteres szöveg generálásas, hogy belefér a márkája vagy nem
                {
                    marka = Console.ReadLine();
                }
                for (i = 0; i < marka.Length; i++)
                {
                    Console.WriteLine(marka[i]);
                }
            }
        }
        #endregion Marka

        #region Rendszam
        // Az autó rendszáma bekérése és eldöntése
        public static void rendszam()
        {
            List<auto> rendszam = new List<auto>();
            string betu = Console.ReadLine();
            int i;
            while (betu.Length != 20) // 20 karakteres szöveg generálása // és eldönti hogy belefér a rendszám vagy nem
            {
                Console.WriteLine("Írja be a rendszámát: ");
                betu = Console.ReadLine();
            }
            for (i = 0; i < betu.Length; i++)
            {
                Console.WriteLine(betu[i]);
            }
        }
        #endregion Rendszam

        #region gyartasiev
        // Gyártási éve, hogy melyik évbe gyártották az autóját
        public static void gyartas()
        {
            List<auto> gyartas = new List<auto>();
            Console.WriteLine("Írja be a gyártási évet: ");
            int i = 0;
            foreach (auto item in gyartas)
            {
                if(i <= 2000)
                {
                    Console.WriteLine("Az autó idős.");
                }else if(i > 2000 && i < 2010)
                {
                    Console.WriteLine("Az autó használható állapotban van.");
                }else if (i > 2010 && i < 2023)
                {
                    Console.WriteLine("Az autó biztoságos és használható állapotban van.");
                }
            }
        }
        #endregion Rendszam

        #region uzemanagy
        // Üzemanyag eldöntése, hogy milyen üzemanyaggal megy az autója(bentinnel/dissel-lel/hibryddel/electromosan)
        public static void uzemAnyag()
        {
            int benzin = 0; // Benzin változó
            int dizel = 0; // Disel változó
            int hibryd = 0; // Hibryd változó
            int elektromos = 0; // Elektromos változó
            List<auto> uzemanyag = new List<auto>(); // Listázva van, hogy melyik üzemannyaggal megy
            Console.WriteLine("Írja be milyen üzemanyaggal működik az autója: ");
            foreach(auto item in uzemanyag)
            {
                if (uzemanyag = benzin)
                {
                    Console.WriteLine("Nem a leggyorsabb, de a városban az egyik legjobb autó. :) ");
                }
                else if (uzemanyag = dizel)
                {
                    Console.WriteLine("Sokkal károssabb mint a hibryd és a benzin, cserében gyorsan megy. :( ");
                }
                else if(uzemanyag = hibryd)
                {
                    Console.WriteLine("Hajlik a zöld környezett fellé. Mert tudja saját magát tölteni is. :) ");
                }
                else if(uzemanyag = elektromos)
                {
                    Console.WriteLine("Az egyik leggyorsabb és semmilyen káros anyagot nem bocst ki. :) ");
                }
                else
                {
                    Console.WriteLine("Ilyen üzemanyag nem létezik.");
                }
            }
        }
        #endregion uzemanagy

        #region szin
        // A tulaj eldönti hogy milyen színben van az autója. 
        public static void szin() // Szín kibálasztós tömb 
        {
            string[,] szin = new string[,] {{ "piros", "barna", "kék", "fehér", "fekete", "szürke", "bordó", "sárga", "hupikék", "világoszöld"}}; // Több dimenziós tömb -> feltöltve színekkel
            Console.WriteLine("Ezek a színek közül lehet választani: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}" + szin); // Kiíratása és választása
        }
        #endregion szin

        #region abroncsok
        // Abroncsméret, hogy mennyi a méret 11 és 20 között. Ha ettől nagyobb vagy kisebb akkor eldönti
        public static void abroncsmeret()
        {
            int abroncsok = 0;
            if(abroncsok <= 11) // Eldöntödik, hogy mennyi lesz az adott autó abroncsméreta
            {
                Console.WriteLine("Az átlagosnál alacsonyabb az abroncsok.");
            }else if( abroncsok >= 20)
            {
                Console.WriteLine("Az átlagosnál nagyobb az abromcsok.");
            }
            else
            {
                Console.WriteLine("Elérte az átlagos határt az abroncosknál.");
            }
        }
        #endregion abroncs

        #region kilometer
        // Kilométer állás mennyit futott az autó
        public static void kilometerallas()
        {
            List<auto> kilometerallas = new List<auto>(); // Lista, hogy mennyi kilométert tett, meg az autó
            int kilometer;
            do // Hátultesztelő kilométerállá
            {
                kilometer = 0;
                switch(kilometer)
                {
                    case 200000:
                        if(kilometerallas.Count <= 200000)
                        Console.WriteLine("Akkor még alkalmas még a vezetésre.");
                        break;
                    case 300000:
                        if (kilometerallas.Count <= 300000)
                            Console.WriteLine("Ideje lassan az autó át nézzetni.");
                        break;
                    case 400000:
                        if (kilometerallas.Count <= 400000)
                            Console.WriteLine("Érdemes a bontoba vinni vagy új motor készítetni.");
                        break;
                    case 500000:
                        if (kilometerallas.Count >= 500000)
                            Console.WriteLine("Érdemes új autót venni.");
                        break;
                }
            }while(kilometerallas.Count > 0); // Elöltesztelő kilométerállás
        }
        #endregion kilometer

        #region ajtokszama
        // Ajtók száma az autón
        public static void ajtokszama()
        {
            Console.WriteLine("Írja be mennyi ajtaja van az autóján: ");
            List<auto> ajtoszama = new List<auto>(); // Amikor listázva van az ajtó
            int ajto = 0;
            if(ajto <= 5)
            {
                Console.WriteLine("Ez egy átlagos autó.");
            }
            else
            {
                Console.WriteLine("Az átlagos felhasználotól nagyobb.");
            }
        }
        #endregion ajtokszama

        #region szemelyszam
        // Eltönti az szeméyl hogy mehet e az autóval vagy nem.
        public static void uleshely()
        {
            List<auto> uleshely = new List<auto>(); // Listázza az üléshelyet
            int hely = 0;
            Console.WriteLine("Írja be hogy hány személyes az autója: ");
            if(hely <= 5) // Amikor 5-nél kevesebb nagy úgyanannyi a hely
            {
                Console.WriteLine("Négy + a sőfőr utazhat az autóban.");
            }else if ( hely >= 5) // Amikor 5-nél Nagyobb nagy úgyanannyi a hely
            {
                Console.WriteLine("Az átlagosnál több ember utazhat az autóban.");
            }
            else // Amikor egyikse jó és az már sok
            {
                Console.WriteLine("Ez nem autó hanem busz.");
            }
        }
        #endregion szemelyszam

        #region kinezet
        // Az autó kihasználatósága
        public static void kinezetek()
        {
            int kinezet; //kinázet változó
            var kombi = new kinezet(1); 
            var sedan = new kinezet(2);
            var bogarhatu = new kinezet(3);
            Console.WriteLine("Milyen az autó kinézete: ");
            if (kinezet = kombi) // Output használat
                Console.WriteLine("Családi autó, meg hosszú távra");
            if (kinezet = sedan) // Output használat
                Console.WriteLine("Családi autó, meg város autó, meg hosszú távra is jó");
            if (kinezet = bogarhatu) // Output használat
                Console.WriteLine("Leginkább város és A-ból B-be furikálás");
        }
        #endregion kinezet
        #endregion Metodusok
    }
}
