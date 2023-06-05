using System;
using System.Collections.Generic;

namespace autoOOP
{
    struct Auto
    {
        public string marka; // Autó nev változó
        public DateTime gyartas; // Gyártási év változója
        public char rendszam; // Rendszám változó
        public int uzemanyag;  // Üzemanyga változó
        public int szin; // Meghatározó szín változó
        public int abroncsmeret; // Abroncsméretű változó
        public int kilometerallas; // Mennyirt futott az autó változó
        public int uleszam; // Utasokkal ellátott változó
    }
    internal class Autok
    {
        #region Kontrucktor
        // Üres konstructor a classhoz
        public Autok() { }
        #endregion Kontrucktor
        #region Változók
        private List<Auto> autok = new List<Auto>();
        #endregion Változók
        #region Metódusok
        #region Auto adatainak beolvasása
        public void setAuto()
        { 
            Auto ak = new Auto();
            ak.marka = marka();
            rendszam();
            gyartasev();
            uzemanyag();
            szin();
            abroncsmeret();
            kilometerallas();
            ajtokszama();
            szemelyszam();
            kinezet();
            autok.Add(ak);
        }
        #endregion Auto adatainak beolvasása
        #region Márka
        public string marka()
        {
            Console.WriteLine("Adja meg az autó márkályát: ");
            string strmarka = Console.ReadLine();
            Random z = new Random();
            int i = z.Next();
            while (strmarka.Length >= 20) // 20 szöveg generálása
            {
                strmarka = Console.ReadLine();
            }
            Console.WriteLine(i);
            Console.ReadLine();
            return strmarka;
        }
        #endregion Márka

        #region Rendszám
        public string rendszam()
        {
            Console.WriteLine("Írja be az autó rendszámét: ");            
            string strrendszam = Console.ReadLine();
            while (strrendszam != "Ez rendszám-e?")
            {
                Console.WriteLine("Ez nem rendzsám, kérem adja meg újra!");
            }
            Random r = new Random();
            int j = r.Next(0, 101);
            if (j == 0)
            {
                Console.WriteLine("Igen");
            }
            else if (j == 1)
            {
                Console.WriteLine("Nem");
            }
            Console.WriteLine(j);
            Console.ReadLine();
            return strrendszam;
        }
        #endregion Rendszám

        #region GyártásiÉv
        public int gyartasev()
        {
            Console.WriteLine("Írja be a évjáratát az autójának: ");
            int strgyartasev = 0;
            if(strgyartasev < 2000)
            {
                Console.WriteLine("Az autó idős az használatra.");
            }
            else if (strgyartasev > 2000 && strgyartasev < 2010)
            {
                Console.WriteLine("Még használható állapotban van az autó.");
            } 
            else if(strgyartasev > 2010 && strgyartasev < 2020)
            {
                Console.WriteLine("Az autó majdnem új állapotban van.");
            }
            else
            {
                Console.WriteLine("Az autó új szerű és friss.");
            }
            Console.WriteLine(strgyartasev);
            Console.ReadLine();
            return strgyartasev;
        }
        #endregion GyártásiÉv

        #region Üzemanyag
        public string uzemanyag()
        {
            Console.WriteLine("Írja be az üzemanyagot, hogy mivel használja az autóját: ");
            string struzemanyag = "";/*
            if (uzemanyag = benzin)
            {

            }*/
            Console.WriteLine(struzemanyag);
            Console.ReadLine();
            return struzemanyag;
        }
        #endregion Üzemanyag

        #region Szín
        public string szin()
        {
            Console.WriteLine("Írja be a szín autójának a színét: ");
            string strszin = "";
            Console.WriteLine();
            Console.ReadLine();
            return strszin;
        }
        #endregion Szín

        #region Abroncs méret
        public int abroncsmeret()
        {
            Console.WriteLine("Írja be az autó abroncs méretét: ");
            int strabroncsmeret = 0;
            if(strabroncsmeret < 11)
            {
                Console.WriteLine("A méret kisebb, mint az átlag.");
            }
            else if(strabroncsmeret > 20)
            {
                Console.WriteLine("A méret az átlagnál nagyobb.");
            }
            else if(strabroncsmeret != 15)
            {
                Console.WriteLine("Megegyezik a szám a mérettel.");
            }
            Console.WriteLine(strabroncsmeret);
            Console.ReadLine();
            return strabroncsmeret;
        }
        #endregion Abroncs méret

        #region Kilométerállás
        public int kilometerallas()
        {
            Console.WriteLine("Írja be a kilométer állását, hogy mennyi ment az autója: ");
            int kmallas = 0;
            if(kmallas < 100000)
            {
                Console.WriteLine("Az adott kilométer jó mert az autó még a páyla futása elején van.");
            }
            else if(kmallas > 100000 && kmallas < 200000)
            {
                Console.WriteLine("Az autó halladó részében van. És még használjható.");
            }
            else if(kmallas > 200000 && kmallas < 300000)
            {
                Console.WriteLine("Érdemes új alkatrészkre cserélni az autó egyes részeit.");
            }
            else if(kmallas > 300000 && kmallas < 400000)
            {
                Console.WriteLine("Az autó kezd a pálya futása vége fele érni.");
            }
            else if(kmallas > 400000 && kmallas < 500000)
            {
                Console.WriteLine("Érdemes a bontoba vinni vagy új autótt venni.");
            }
            Console.WriteLine(kmallas);
            Console.ReadLine();
            return kmallas;
        }
        #endregion Kilométerállás

        #region Ajtókszáma
        public int ajtokszama()
        {
            Console.WriteLine("Írja 1-től 5-ig írja be, hogy az autó ajtó száma mennyi van rajta: ");
            int strajtok = 0;

            return strajtok;
        }
        #endregion Ajtókszáma

        #region Személyekszáma
        public int szemelyszam()
        {
            Console.WriteLine("Írja be hogy hány személy utazhat az autójában: ");
            int strszemelyek = 0;
            return strszemelyek;
        }
        #endregion Személyekszáma

        #region Kinézet
        public string kinezet()
        {
            Console.WriteLine("Adja meg, hogy milyen a kinézete az autójának: (választható: kombi, sedan, bogárhátú): ");
            string strkinezet = "";
            return strkinezet;
        }
        #endregion Kinézet
        #endregion Metódusok
    }
}
