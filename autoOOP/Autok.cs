using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Remoting.Lifetime;

namespace autoOOP
{
    struct Auto
    {
        public string marka; // Autó nev változó
        public int gyartas; // Gyártási év változója
        public string rendszam; // Rendszám változó
        public int uzemanyag;  // Üzemanyga változó 1-benzin, 2-Gázolaj, 3-Elektromos, 4-Gáz
        public int szin; // Meghatározó szín változó
        public int abroncsmeret; // Abroncsméretű változó
        public int kilometerallas; // Mennyirt futott az autó változó
        public int ulesszam; // Utasokkal ellátott változó
        public int kinezet; // String változó való kinézet
        public int ajtokszama; // Szám változó való ajtókszáma
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
            ak.rendszam = rendszam();
            ak.gyartas = gyartasev();
            ak.uzemanyag = uzemanyag();
            ak.szin = szin();
            ak.abroncsmeret = abroncsmeret();
            ak.kilometerallas = kilometerallas();
            ak.ajtokszama = ajtokszama();
            ak.ulesszam= szemelyszam();
            ak.kinezet = kinezet();
            autok.Add(ak);
        }
        #endregion Auto adatainak beolvasása
        #region Márka
        public string marka()
        {
            Console.WriteLine("Adja meg az autó márkáját: ");
            string strmarka = Console.ReadLine();
            Console.ReadLine();
            return strmarka;
        }
        #endregion Márka

        #region Rendszám
        public string rendszam()
        {
            Console.WriteLine("Írja be az autó rendszámét: ");            
            string strrendszam = Console.ReadLine();
            Console.ReadLine();
            return strrendszam;
        }
        #endregion Rendszám

        #region GyártásiÉv
        public int gyartasev()
        {
            Console.WriteLine("Írja be a évjáratát az autójának: 1-2000, 2-2000 és 2010 közt,3-2010 és 2020, 4-2020");
            int strgyartasev = Convert.ToInt32(Console.ReadLine());
            if(strgyartasev == 1)
            {
                Console.WriteLine("Az autó idős az használatra.");
            }
            else if (strgyartasev == 2)
            {
                Console.WriteLine("Még használható állapotban van az autó.");
            } 
            else if(strgyartasev == 3)
            {
                Console.WriteLine("Az autó majdnem új állapotban van.");
            }
            else if (strgyartasev == 4)
            {
                Console.WriteLine("Az autó új szerű és friss.");
            }
            Console.ReadLine();
            return strgyartasev;
        }
        #endregion GyártásiÉv

        #region Üzemanyag
        public int uzemanyag()
        {
            Console.WriteLine("Írja be az üzemanyagot, hogy mivel használja az autóját: 1-benzin, 2-Gázolaj, 3-Elektromos, 4-Gáz");
            int struzemanyag = Convert.ToInt32(Console.ReadLine());
         
            if(struzemanyag == 1)
            {
                Console.WriteLine("Az autója környezet tudatos és a városban az egyik legjobb autó.");
            } 
            else if(struzemanyag == 2)
            {
                Console.WriteLine("Akkor az autója nem a városba való hanem a városon kivülre.");
            }
            else if(struzemanyag == 4)
            {
                Console.WriteLine("Ez az autó azért jó mert önmagát is tudja tölteni.");
            }
            else if(struzemanyag == 3)
            {
                Console.WriteLine("Ez az autója környezet barát és gyorsulásra is jó az autó.");
            }
            Console.ReadLine();
            return struzemanyag;
        }
        #endregion Üzemanyag

        #region Szín
        public int szin()
        {
            Console.WriteLine("Írja be a szín autójának a színét: Ezek küzül választhat 1-Zold, 2-Kék, 3-Barna, 4-Szürke, 5-Fehér, 6-Fekete");
            int strszin = Convert.ToInt32(Console.ReadLine());
            if(strszin == 1)
            {
                Console.WriteLine("Az egyik legszebb szín ami kitűn az autók többi színeibből.");
            }
            else if(strszin == 2)
            {
                Console.WriteLine("Ez majdnem megegyezik a ég színével.");
            }
            else if(strszin == 3)
            {
                Console.WriteLine("Ez is az egyik olyan autó ami kitűn a többi autó köz.");
            }
            else if(strszin == 4)
            {
                Console.WriteLine("Ez egy átlagos autó szín.");
            }
            else if(strszin == 5)
            {
                Console.WriteLine("Ez is egy átlagos szín, de még megy egy ünnepséghez is.");
            }
            else if(strszin == 6)
            {
                Console.WriteLine("Ez is egy átlagos szín, csak túl sok van belőle.");
            }
            Console.ReadLine();
            return strszin;
        }
        #endregion Szín

        #region Abroncs méret
        public int abroncsmeret()
        {
            Console.WriteLine("Írja be az autó abroncs méretét: ");
            int strabroncsmeret = Convert.ToInt32(Console.ReadLine());
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
            return strabroncsmeret;
        }
        #endregion Abroncs méret

        #region Kilométerállás
        public int kilometerallas()
        {
            Console.WriteLine("Írja be a kilométer állását, hogy mennyi ment az autója: ");
            int kmallas = Convert.ToInt32(Console.ReadLine());
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
            Console.ReadLine();
            return kmallas;
        }
        #endregion Kilométerállás

        #region Ajtókszáma
        public int ajtokszama()
        {
            Console.WriteLine("Írja 1-től 5-ig írja be, hogy az autó hány ajtók számmal rendelkezik: 1-3, 2-4, 4-5");
            int strajtok = Convert.ToInt32(Console.ReadLine());
            if (strajtok == 1)
            {
                Console.WriteLine("Ez az autó leginkább sportautó.");
            }
            else if(strajtok == 3)
            {
                Console.WriteLine("Ez az autó leginkább családi és limuzin használatú autó.");
            }
            else if(strajtok == 4)
            {
                Console.WriteLine("Valószínűleg az autója kombi vagy rövidhájú és könnyeben tud pakolni a cuccait.");
            }
            else
            {
                Console.WriteLine("Ez sajnos saját elképzelésű az autója és nem gyerekjáték.");
            }
            Console.ReadLine();
            return strajtok;
        }
        #endregion Ajtókszáma

        #region Személyekszáma
        public int szemelyszam()
        {
            Console.WriteLine("Írja be hogy hány személy utazhat az autójában: 1-4, 2-5, 3-10");
            int strszemelyek = 0;
            if(strszemelyek == 1 && strszemelyek == 2)
            {
                Console.WriteLine("Elférnek az autóban.");
            }
            else if(strszemelyek == 2)
            {
                Console.WriteLine("Épp hogy elférnek az autóban.");
            }
            else if(strszemelyek == 3)
            {
                Console.WriteLine("Ez nem autó lesz hanem kisbusz vagy nagybusz.");
            }
            Console.ReadLine();
            return strszemelyek;
        }
        #endregion Személyekszáma

        #region Kinézet
        public int kinezet()
        {
            Console.WriteLine("Adja meg, hogy milyen a kinézete az autójának: (választható: 1-kombi, 2-sedan, 3-bogárhátú): ");
            int strkinezet = Convert.ToInt32(Console.ReadLine());
            if(strkinezet == 1)
            {
                Console.WriteLine("Ez az az autó ami könnyű a pakolási lehetőség és minden másra.");
            }
            else if (strkinezet == 2)
            {
                Console.WriteLine("Ez az az autó leginkább limunzin fajtához képzelhető el.");
            }
            else if (strkinezet == 3)
            {
                Console.WriteLine("Ez az az autó leginkább a városba jó közlekedni mert kisebb helyen is elfér.");
            }
            else
            {
                Console.WriteLine("Ez az autó nem fér el a megadott osztáyba.");
            }
            return strkinezet;
        }
        #endregion Kinézet
        #endregion Metódusok
    }
}
