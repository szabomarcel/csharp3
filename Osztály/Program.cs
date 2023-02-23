using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// poliformizmus
namespace osztály
{
    class Kutya
    {
        // Properties / osztályvátozók / osztály tagjai
        private string nev;
        public string Fajta { get; set; }
        private int gender;
        public void setGender(string gender)
        {
            switch (gender)
            {
                case "Kan":
                    this.gender = 1; break;
                case "Szuka":
                    this.gender = 2; break;
                default: this.gender = 3; break;
            }
        }

        public string getGender()
        {
            switch (this.gender)
            {
                case 1:
                    return "kan";
                case 2:
                    return "szuka";
                default: return "ismeretlen";
            }
        }
        // Konstruktorok
        public Kutya(string nev) { this.nev = nev; }
        public Kutya() { }
        public string getNev() => this.nev; // Lambda operátoros fekírás
        public void setNev(string nev) { this.nev = nev; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya kutya1 = new Kutya();
            kutya1.setNev("Tacsi");
            Console.WriteLine("A kutya1 neve: {0}", kutya1.getNev());

            Kutya zeusz = new Kutya("zeusz");
            Console.WriteLine("A zeusz neve: {0}", zeusz.getNev());
            zeusz.Fajta = "Német juhász";
            Console.WriteLine("A zeusz fajtája. {0}", zeusz.Fajta);

            Console.ReadKey();
        }
    }
}
