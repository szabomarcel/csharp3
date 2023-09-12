using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFAvilagranglista
{
    internal class Fifa
    {
        string Csapat;
        int HeIyezes;
        int Valtozas;
        int Pontszam;

        public string Csapat1 { get => Csapat; set => Csapat = value; }
        public int HeIyezes1 { get => HeIyezes; set => HeIyezes = value; }
        public int Valtozas1 { get => Valtozas; set => Valtozas = value; }
        public int Pontszam1 { get => Pontszam; set => Pontszam = value; }

        public Fifa(string csapat, int heIyezes, int valtozas, int pontszam, string csapat1, int heIyezes1, int valtozas1, int pontszam1)
        {
            Csapat = csapat;
            HeIyezes = heIyezes;
            Valtozas = valtozas;
            Pontszam = pontszam;
            Csapat1 = csapat1;
            HeIyezes1 = heIyezes1;
            Valtozas1 = valtozas1;
            Pontszam1 = pontszam1;
        }

       public Fifa(string csapat1)
        {
            string[] csapat = csapat1.Split(';');
            this.HeIyezes1 = csapat1[1];
            this.Valtozas1 = csapat1[2];
            this.Pontszam1 = csapat1[3];
        }        
    }
}
