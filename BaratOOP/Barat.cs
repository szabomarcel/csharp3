using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace BaratOOP
{
    struct Szemely
    {
        public string Name; // Szöveges név változó
        public DateTime szulido; // Dátum változó DateTime-ban
        public char nem; // Nem változó char-ban
        public int hajlam;  // Hajlam int-be
    }
    internal class Barat
    {
        private static string path = "..\\..\\"; // link deklarálásra vonatkozik ami lehet 4 byte is
        private static string intfile = "teszt.csv"; // link deklarálásra vonatkozik ami lehet 4 byte is
        private static string outfile = "barat.csv"; // link deklarálásra vonatkozik ami lehet 4 byte is
        private List<Szemely> list = new List<Szemely>();
        #region Konstructor
        public Barat() { }
        #endregion Konstructor
        #region Metódusok
        #region Beolvasás
        public void beolvas() // File beolvasás és hozzádas
        {
            FileStream fs = new FileStream(path + intfile, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {      
                    this.list.Add(convert(sr.ReadLine().Split(';')));
                }
            }
        }
        #endregion Beolvasás
        #region Konvertálás tömből
        private Szemely convert(string[] line) // Konvertálás személyekkel
        {
            Szemely s = new Szemely();
            s.Name = line[0];
            s.szulido = Convert.ToDateTime(line[1]);
            s.nem = Convert.ToChar(line[2]);
            s.hajlam = Convert.ToInt32(line[3]);
            return s;
        }
        #endregion Konvertálás tömből
        #region Újbarát hozzáadás
        public void insertBarat(string[] t)
        {
            this.list.Add(convert(t));
        }
        #endregion Újbarát hozzáadás
        #region Törlés
        public void delete(string nev)
        {
            this.list.Remove(this.list.Find(list => list.Name == nev)); // Adatstruktrura -> beágyazása + törlés
        }
        #endregion Törlés
        #region Keresés
        public bool kereses(string nev)
        {
            // bool b = false;
            Szemely vane = new Szemely();
               vane = this.list.Find(list => list.Name == nev);
            if (vane.Name == nev)
            {
                return true;
            }
            return false;

        }
        #endregion Keresés
        #region Kiíratás
        public void kiir()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(path + outfile, FileMode.Create, FileAccess.Write), Encoding.UTF8))            
            {
                foreach (Szemely item in this.list)
                {
                    sw.WriteLine(item.Name,";",item.szulido, ";",item.nem, ";",item.hajlam);
                }
            }
        }
        #endregion Kiíratás
        #endregion Metódusok
    }
}
