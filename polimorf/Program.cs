using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poliform
{
    // polimorf
    class Ember
    {
        public string Nev { get; set; }
        private string bemut = "Üdvözlöm a nevem";
        public Ember(string nev) { Nev = nev; }
        public string beszel() { return bemut + Nev; }
    }
    class Ferfi : Ember
    {
        public int Kor { get; set; }
        public Ferfi(string nev, int kor) : base(nev)
        {
            Kor = kor;
        }
    }
    class Woman : Ember
    {
        public string SzemSzin { get; set; }
        public Woman(string nev, string szemszin) : base(nev)
        {
            SzemSzin = szemszin;
        }
    }
    class Haz
    {
        private List<Ember> lakok = new List<Ember>();
        public void hazajon(Ember obj)
        {
            this.lakok.Add(obj);
        }
        public void csenget()
        {
            int i;
            Random rd = new Random();
            // Ha vannak a házban, akkor véletlen szerűen kijön valaki és beszél
            if (lakok.Count > 0)
            {
                i = rd.Next(0, lakok.Count - 1);
                Console.WriteLine(lakok[1].beszel());
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Feladat alpaeset:
            // Ház , vannak lakók: nő és férfiak, ha becsenget valaki n ő vagy férfi nyit ajtót
            //polimorfizmus példa: mindegy hogy nő v férfi megy kinyitni ugyanazt metódust használjuk
            //Felépítjük a házat ( A hátz példányositása)
            Haz otthon = new Haz();

            // Példanyosítjuk a szereplőket
            //Hölgyek
            Woman eva = new Woman("Éva", "zöld");
            Woman kati = new Woman("Kati", "barna");
            Woman sari = new Woman("Sári", "kék");
            Woman zsuzsa = new Woman("Zsuzsa", "Zöld");

            //Férfiak
            Ferfi adam = new Ferfi("Ádám", 26);
            Ferfi dani = new Ferfi("Dani", 26);
            Ferfi gergo = new Ferfi("Gergő", 26);
            Ferfi atti = new Ferfi("Atti", 26);

            //Beköltöznek a szereplők házba
            if (eva is Ember) otthon.hazajon(eva as Ember);
            otthon.hazajon((Ember)eva);
            otthon.hazajon((Ember)kati);
            otthon.hazajon((Ember)sari);
            otthon.hazajon((Ember)zsuzsa);
            otthon.hazajon((Ember)adam);
            otthon.hazajon((Ember)dani);
            otthon.hazajon((Ember)gergo);
            otthon.hazajon((Ember)atti);

            // Jönnek idegenek és csemegetnek
            bool tovabb = true;
            do
            {
                otthon.csenget();
                tovabb = (Console.ReadLine() == string.Empty) ?
                    false : true;
            } while (tovabb);
        }
    }
}