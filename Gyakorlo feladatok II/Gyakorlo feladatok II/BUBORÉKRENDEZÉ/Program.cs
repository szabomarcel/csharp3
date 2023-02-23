using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUBORÉKRENDEZÉS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // első változatt for ciklussal
            for (int i = 0, i < sor.Length - 1; ++i) // végigjárás a for-ciklussal, olvasás és írásra (eldöntendő ciklus az ++i-re)
            {
                for (int j = sor.Length - 1; > i; --j) // végigjárás a for-ciklussal, olvasás és írásra (eldöntendő ciklus a --i-re)
                {
                    int tmp = sor[j]; // egyenlő a sor és a tömbjével
                    sor[j] = sor[j - 1]; // egyenlő a sor és a tömbjével
                    sor[j - 1] = tmp; // egyenlő a tmp-vel
                }
            }

            // második változatt for ciklussal
            for (int i = 1; i < sor.Length; ++i) // végigjárás for ciklussal, olvasás és írásra (elágazás az i-re)
            {
                int y = sor[i]; // egyenlő a sor és a tömbjével
                int j = i - 1; // egyenlő a j az i - 1-el
                while (j > -1 && y < sor[j]) //while ciklus eldöntendő, hogy nagyobb a j mint a -1 és/vagy az y kisebb a sor j tömbjével
                {
                    sor[j + 1] = sor[j];
                    --j;
                }
                sor[j + 1] = y
        }
    }
}
