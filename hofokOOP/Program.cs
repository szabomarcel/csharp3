using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hofokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hőmérséklet tömbje
            int[,] data = new int[12, 30];

            // Hőmérsékelet tömb feltöltése adatokkal
            setMatrix(data);

            // Kiíratés a tömb adatait
            kiirMatrix(data);

            // Példányositás
            hofokszamitas afok = new hofokszamitas(data);

            //Elvégeztetem vele a számításokat
            afok.szamitas();

            // Kiíratom a legmelegebb napot
            prLegmelegebbNap(afok);

            // Kiíratom a leghidegebb napot
            prLeghidegebbNap(afok);

            // Kiíratom a legmelegebb hónap
            prLeghidegebbHonap(afok);

            // Kiíratom a leghidegebb hónap
            prLegmelegebbHonap(afok);

            // Kiíratom az összefüggő 5 minuszos napot
            // prOtMinusz(afok);


            Console.ReadKey();  


        }

        private static void prOtMinusz(hofokszamitas p)
        {
            NapiAdat[] napiAdats = new NapiAdat[5];
            napiAdats = p.getOtMinusz();


            if (napiAdats[0].hofok < 0)
            {
                Console.WriteLine("Az öt összeföggő minuszos nap a következő: ");
                for (int i = 0; i < napiAdats.Length; i++)
                {
                    Console.WriteLine("{0} {1}: {2}", napiAdats[i].honap, napiAdats[i].nap, napiAdats[i].hofok);
                }
            }
            else
            {
                Console.WriteLine("Nem volt 5 minuszosösszefüggő nap");
            }
        }

        private static void prLeghidegebbHonap(hofokszamitas afok)
        {
            HaviAdat adat = new HaviAdat();
            adat = afok.getHaviMax();
            Console.WriteLine("Az év leghidegebb hónap: {0} {1} fok", adat.honap, adat.hofok);

        }
        private static void prLegmelegebbHonap(hofokszamitas afok)
        {
            HaviAdat adat = new HaviAdat();
            adat = afok.getHaviMax();
            Console.WriteLine("Az év legmelegebb hónap: {0} {1} fok", adat.honap, adat.hofok);
        }

        private static void prLeghidegebbNap(hofokszamitas afok)
        {
            Console.WriteLine("Az év legmelegebb napja: {0} {1}: {2} fok", afok.getNapiMin().honap, afok.getNapiMin().nap, afok.getHaviMin().hofok);
        }

        private static void prLegmelegebbNap(hofokszamitas afok)
        {
            NapiAdat adat = new NapiAdat();
            adat = afok.getNapiMax();
            Console.WriteLine("Az év legmelegebb napja: {0} {1}: {2} fok", adat.honap, adat.nap, adat.hofok);
        }

        private static void kiirMatrix(int[,] data)
        {
            Console.WriteLine("\n Az éves hőmérséklet adatok:");
            for(int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("\n {0}.hónap: ", i++);
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0}, ", data[i,j]);
                }
            }
        }

        private static void setMatrix(int[,] data)
        {
            // Havi min és max hőmérsékletek tömbje
            int[,] minmax =
            {
                { -20, 5},
                { -12, 5},
                { -7, 14},
                { -2, 17},
                { 10, 19},
                { 19, 32},
                { 25, 38},
                { 25, 30},
                { 12, 25},
                { 5, 19},
                { -7, 18},
                { -10, 5},
            };

            // Munkaváltozók
            Random rn = new Random();

            for(int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rn.Next(minmax[i, 0], minmax[i, 1]);
                }
                
            }
        }
    }
}
