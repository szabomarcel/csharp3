using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Snooker
{
    internal class Snook
    {
        int Helyezes;
        string Nev;
        string Orszag;
        int Nyeremeny;

        public int Helyezes1 { get => Helyezes; set => Helyezes = value; }
        public string Nev1 { get => Nev; set => Nev = value; }
        public string Orszag1 { get => Orszag; set => Orszag = value; }
        public int Nyeremeny1 { get => Nyeremeny; set => Nyeremeny = value; }

        public Snook(int helyezes, string nev, string orszag, int nyeremeny, int helyezes1, string nev1, string orszag1, int nyeremeny1)
        {
            Helyezes = helyezes;
            Nev = nev;
            Orszag = orszag;
            Nyeremeny = nyeremeny;
            Helyezes1 = helyezes1;
            Nev1 = nev1;
            Orszag1 = orszag1;
            Nyeremeny1 = nyeremeny1;
        }
        public Snook(string beolvastatottSOr)
        {
            string[] strings = beolvastatottSOr.Split(';');
            Helyezes = int.Parse(strings[0]);
            Nev = strings[1];
            Orszag = strings[2];
            Nyeremeny = int.Parse(strings[3]);
        }
    }
}
