using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1lap
{
    class JegyzetLap
    {
        private string szov;
        private char szin;
        private int szavakszama;
        public JegyzetLap(string szovege, char szine)
        {
            this.Szov = szovege;
            this.Szin = szine;
            this.Szavakszama = szavak_szama(this.Szov); // Paraméterként meg kapja a szöveget
        }
        public void szincsere()
        {
            char[] szinek = new char[] { 's', 'k', 'z' };
            Random vel = new Random();
            char ujszin = this.Szin;
            while (ujszin == this.Szin)
            {
                ujszin = szinek[vel.Next(0, szinek.Length)];
            }
            this.Szin = ujszin;
        }
        public int betukszama()
        {
            return this.Szov.Length;
        }
        public int szavakdb()
        {
            return this.Szavakszama;
        }
        private int szavak_szama(string szoveg)
        {
            int db = 0;
            foreach (char kar in szoveg)
            {
                if (kar == ' ')
                {
                    db++;
                }
            }
            return db + 1;
        }

        public string Szov
        {
            get { return szov; }
            set {
                if (value.Length <= 250)
                {
                    szov = value;
                    this.Szavakszama = szavak_szama(this.Szov);
                }
                else throw new FormatException("Túl hosszú a szöveg!");
            } // Automatán kap értéket 
        }
        public string lap_szine()
        {
            string sz = "";
            switch (this.Szin)
            {
                case 's': sz = "sárga"; break;
                case 'k': sz = "kék"; break;
                case 'z': sz = "zöld"; break;
                default: break;
            }
            return sz;
        }
        private char Szin 
        { get => szin;
            set
            {
                if (value == 's' || value == 'k' || value == 'z')
                    szin = value;
                else throw new FormatException("Nem létező szín!");
            }
        }
        private int Szavakszama
        {
            get { return szavakszama; }
            set => szavakszama = value;
        }
        public string lap_info()
        {
            return (this.Szov + " (" + this.lap_szine() + ")");
        }
        public string rovidebbnevu_adatai_pldny(JegyzetLap b) // a nevű példány kap meg
        {
            // return (this.betukszama() < b.Szov.Length) ? this.Szov + " (" + this.Szov + ") " : b.Szov + " (" + b.Szin + ")"; // Igaz és hamis érték megadása.
            return (this.betukszama() < b.Szov.Length) ? this.lap_info() + " (" + this.lap_szine() + ") " : b.lap_info();
        }
        public static string rovidebbnevu_adatai(JegyzetLap a, JegyzetLap b) // Osztlyszintű tag
        {
            // return (a.betukszama() < b.Szov.Length) ? a.Szov + " (" + a.Szov + ") " : b.Szov + " (" + b.Szin + ")"; // Igaz és hamis érték megadása.
            return (a.betukszama() < b.Szov.Length) ? a.lap_info() : b.lap_info();
        }
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            // JegyzetLap jl = new JegyzetLap("Jegyzetlap", 'k');
            // Console.WriteLine(jl.lap_szine());

            JegyzetLap[] jfuzet = new JegyzetLap[3];
            jfuzet[0] = new JegyzetLap("Első lap", 's');
            jfuzet[1] = new JegyzetLap("Második lap", 'k');
            jfuzet[2] = new JegyzetLap("Harmadik lap", 'z');
            Console.WriteLine("A jegyzettömb tartalma: ");
            foreach (JegyzetLap jlap in jfuzet)
            {
                Console.WriteLine(jlap.lap_info());
            }

            Console.WriteLine("A második elem módosiítása: ");
            // Metódusok
            jfuzet[1].Szov = "Módodított második lap";
            Console.WriteLine("Az új szöveg: ", jfuzet[1].Szov);
            Console.WriteLine("Szavak száma: {0} db, betűk száma: {1} db.", jfuzet[1].szavakdb(), jfuzet[1].betukszama());
            Console.WriteLine("Színcsere előtt: " + jfuzet[1].lap_szine());
            jfuzet[1].szincsere();
            Console.WriteLine("Színcsere után: " + jfuzet[1].lap_szine());
            Console.WriteLine("A rövidebb jegyzetlap tartalma osztály szintű: " + JegyzetLap.rovidebbnevu_adatai(jfuzet[0], jfuzet[1]));
            Console.WriteLine("A rövidebb jegyzetlap tartalma pldny szintű: " + jfuzet[0].rovidebbnevu_adatai_pldny(jfuzet[1]));
            Console.WriteLine("A rövidebb jegyzetlap tartalma pldny szintű: " + jfuzet[1].rovidebbnevu_adatai_pldny(jfuzet[0]));


            Console.ReadLine();
        }
    }
}
