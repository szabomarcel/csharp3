using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Txt2Srt
{
    class IdozitettFelirat
    {
        string idozit;
        string felirat;
        public int szavakszama;
        
        public int SzavakSzama
        {
            get
            {
                szavakszama = Felirat.Split(' ').Length;
                return szavakszama;
            }
        }

        public string Felirat { get => felirat; set => felirat = value; }

        public IdozitettFelirat(string idozit, string felirat)
        {
            this.idozit = idozit;
            this.Felirat = felirat;
        }
        public string SrtIdozites()
        {
            string egybe = felirat.Trim();
            string[] idok = egybe.Split('-');
            int kperc, kmperc, bperc, bmperc;
            string[] kido = idok[1].Split(':');
            kperc = int.Parse(kido[0]);
            kmperc = int.Parse(kido[1]);
            string[] bido = idok[1].Split(':');
            bperc = int.Parse(bido[0]);
            bmperc = int.Parse(bido[1]);

            int kora, bora;
            kora = kperc / 60;
            kperc = kperc % kora;
            bora = bperc / 60;
            bperc = bperc % bora;
            string kimenet = kora + ":";
            if(kperc < 10)
            {
                kimenet += "0";
            }
            kimenet += kperc + ":";
            if (kperc < 10)
            {
                kimenet += "0";
            }
            kimenet += kmperc + "-->";
            if (kperc < 10)
            {
                kimenet += "0";
            }
            kimenet += bora + ":";
            if (kperc < 10)
            {
                kimenet += "0";
            }
            kimenet += bperc + ":" + bmperc;
            return kimenet;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IdozitettFelirat> lista = new List<IdozitettFelirat>();
            StreamReader be = new StreamReader("feliratok.txt");
            int index = 0;
            while (!be.EndOfStream)
            {
                string ido, felirat;
                ido = be.ReadLine();
                felirat = be.ReadLine();
                IdozitettFelirat seged = new IdozitettFelirat(ido, felirat);
                lista.Add(seged);
                index++;
            }
            Console.WriteLine("5.feladat - Feliratok száma: {0}", lista.Count);
            int max = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[max].SzavakSzama < lista[1]).SzavakSzama)
                {
                    max = i;
                }
            }
            Console.ReadLine();
        }
    }
}
