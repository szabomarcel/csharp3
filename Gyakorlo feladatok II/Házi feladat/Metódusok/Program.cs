using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metódusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "egyik"; // egyenlő az egyik-kel
            string b = "másik"; // egyenlő a másik-kal
            int x = String.Compare(a, b);
            if (x == 0) // végigjárás a for-ciklussal, olvasás és írásra eldöntendő: ha x == a 0-val
            {
                Console.WriteLine("A két string egyenlő"); // Kiíratás a számra
            }
            else if (x < 0) // végigjárás a for-ciklussal, olvasás és írásra eldöntendő: ha x < mint a 0
            {
                Console.WriteLine("A 'a' a kisebb");// Kiíratás ha [a] kisebb 
            }
            else //végigjárás a for-ciklussal, olvasás és írásra  eldöntendő: ha eltér
            {
                Console.WriteLine("A 'b' a kisebb");// Kiíratás ha [b] számra
            }
            Console.ReadKey();
        }
    }
}
