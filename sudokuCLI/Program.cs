using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sudokuCLI
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader sr = new StreamReader("feladvanyok.txt");
            while (!sr.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3.Feladat: Beolvasva {0} felavány", feladvanyok.Count);

            int meret;
            string adat;
            do // Hátultesztelő ciklus
            {
                Console.WriteLine("4. Feladat: Kérem a feladat méretét[4..9]: ");
                // meret = int.Parse(Console.ReadLine());
            }
            while (!int.TryParse(Console.ReadLine(), out meret) || meret < 4 || meret > 9); // Le futatja az aleső felélt a kifejezés első felét, meg nézi hogy igaz vagy nem. Ha igaz lesz akkor igaz lesz. Ha hamis akkor amist lesz az érték.

           
            List<Feladvany> nElemiFeladvanyok = new List<Feladvany>();
            foreach(var f in feladvanyok)
            {
                if(f.Meret == meret)
                {
                    nElemiFeladvanyok.Add(f);
                }
            }
            Console.WriteLine("{0}×{0} méretű feladaványból {1} darab van tárolva", meret, nElemiFeladvanyok.Count);

            Random rand = new Random();
            int index = rand.Next(nElemiFeladvanyok.Count);
            var keresettFeladvany = nElemiFeladvanyok[index];

            Console.WriteLine("5. Feladat: A kiválasztott feladvány: ");
            Console.WriteLine(keresettFeladvany.Kezdo);

            double db = 0; // decimál át alakitása.
            foreach(char szamjegy in keresettFeladvany.Kezdo)
            {
                if(szamjegy != '0')
                {
                    db++;
                }
            }
            Console.WriteLine("6. Feladat: A feladvány kitöltöttsége: {0:f0}%)", 100 * db / keresettFeladvany.Kezdo.Length);
            Console.WriteLine("7. Feladat: A feladvány kirajzolva: ");
            keresettFeladvany.Kirajzol();

            String fajlnev = string.Format("sudoku{0}.txt", meret);
            StreamWriter sw = new StreamWriter(fajlnev);
            foreach(var f in nElemiFeladvanyok)
            {
                sw.Write(f.Kezdo);
            }
            sw.Close();
            Console.WriteLine("8. Feladat: {0} állomány {1} darab faládvánnyal létrehozva", fajlnev,nElemiFeladvanyok.Count);

        }
    }
}
