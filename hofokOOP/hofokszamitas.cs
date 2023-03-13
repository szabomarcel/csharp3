using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hofokOOP
{
    struct NapiAdat
    {
        public string honap; // Hónap neve
        public int nap, hofok; // A nap sorszáma // Hőmérséklet
    } 
    struct HaviAdat
    {
        public string honap; // Hónap neve
        public int hofok; // Havi átlaghőmérséklete
    }

    internal class hofokszamitas
    {
        // Osztályváltozók
        private int[,] adat = null; // Hőfokok tárolására
        private int[] haviAtlag = new int[12]; //Havi atlaghőfokok
        private NapiAdat napiMax, napiMin; // Legmagasabb hőmérsékletű nap adatai // Legalacsonyabb hőmérsékletű nap adatai
        private HaviAdat haviMax, haviMin; // Legmagasabb átlaghőmérsékletű hónap adatai // Legalacsonyabb átlaghőmérsékletű hónap adatai
        private NapiAdat[] otMinusz = new NapiAdat[5]; // Öt minuszos nap tömbje
        static string[] honapok = { "január", "február", "március", "április", "május", "június", "július", "augusztust", "szeptember", "október", "november", "december" };

        // Konstructor
        public hofokszamitas(int[,]p) 
        {
            this.adat = p;
        }

        //Eredmények átadó metódusok
        public NapiAdat getNapiMin()
        {
            return napiMin;
        }
        public NapiAdat getNapiMax()
        {
            return napiMax;
        }
        public HaviAdat getHaviMin()
        {
            return haviMin;
        }
        public HaviAdat getHaviMax()
        {
            return haviMax;
        }
        public NapiAdat[] getOtMinusz()
        {
            return otMinusz;
        }


        // Számítások
        public void szamitas()
        {
            // Leghidegebb és legmelegebb napok kiszámítása
            setNapiMax();
            setNapiMin();

            // Leghidegebb és legmelegebb hónpok kiszámítás
            setHaviAtlag();
            setHaviMaxMin();

            // Folyamatos 5 minuszis nap liszámítása
            // setOtMinusz();

        }

        private void setHaviAtlag()
        {
            int osszeg = 0; //Gyűjtés
            for(int i = 0; i < adat.GetLength(0); i++) // Hónapok
            {
                osszeg = 0;
                for (int j = 0; j < adat.GetLength(1); j++) // Napok
                {
                    osszeg += adat[i, j];
                }
                this.haviAtlag[i] = osszeg / adat.GetLength(1);
            }
        }

        private void setOtMinusz()
        {
            int mDB = 0; // Ezzel számolod, hogy hanyadik minuszos napon tartunk
            for (int i = 0; i < adat.GetLength(0); i++) // Hónap
            {
                for (int j = 0; j < adat.GetLength(1); j++) // Napok
                { 
                    if (this.adat[i,j] < 0)
                    {
                        this.otMinusz[mDB].honap = honapok[i];
                        this.otMinusz[mDB].nap = j + i;
                        this.otMinusz[mDB].hofok = this.adat[i,j];
                        mDB++;
                    }
                    else
                    {
                        for (int k = 0; k < mDB + 1; k++)
                        {
                            this.otMinusz[k].honap = String.Empty;
                            this.otMinusz[k].nap = 0;
                            this.otMinusz[k].hofok = 0;
                        }
                        mDB = 0;
                    }
                }
            }
        }

        private void setHaviMaxMin()
        {
            int max = int.MinValue,
                maxInd = 0;
            int min = int.MaxValue, 
                minInd = 0;
            for (int i = 0; i < this.haviAtlag.Length; i++)
            {
                if (this.haviAtlag[i] > max)
                {
                    max = this.haviAtlag[i];
                    maxInd = i;
                }else

                if(this.haviAtlag[i] < min)
                {
                    min = this.haviAtlag[i];
                    minInd = i;
                }
            }
            this.haviMax.hofok = max;
            this.haviMax.honap = honapok[maxInd];
        }

        private void setNapiMin()
        {
            int min = int.MaxValue,
                minI = 0,
                minJ = 0;

            for (int i = 0; i < adat.GetLength(0); i++) // Hónapok ciklusa
            {
                for (int j = 0; j < adat.GetLength(1); j++) // Napok ciklusa
                {
                    if (this.adat[i, j] > min)
                    {
                        min = this.adat[i, j];
                        minI = i;
                        minJ = j;
                    }
                    // Eredmény átadása a tömbnek
                    this.napiMax.honap = honapok[minI];
                    this.napiMax.nap = minJ + 1; // MIvel nulladik nap nincs a hónapban ezért hozzá kell adni 1-t
                    this.napiMax.hofok = min;
                }
            }
        }

        private void setNapiMax()
        {
            int max = int.MinValue,
                maxI = 0,
                maxJ = 0;
            
            for (int i = 0; i < adat.GetLength(0); i++) // Hónapok ciklusa
            {
                for (int j = 0; j < adat.GetLength(1); j++) // Napok ciklusa
                {
                    if (this.adat[i,j] > max)
                    {
                        max = this.adat[i,j];
                        maxI = i;
                        maxJ = j;
                    }
                    // Eredmény átadása a tömbnek
                    this.napiMax.honap = honapok[maxI];
                    this.napiMax.nap = maxJ + 1; // Mivel nulladik nap nincs a hónapban ezért hozzá kell adni 1-t
                    this.napiMax.hofok = max;
                }
            }
        }
    }
}
