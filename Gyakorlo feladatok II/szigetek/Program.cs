using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islandCount = 0; // islandCount egyenlő a nullával
            int maxIslandLength = 0; // maxIslandLength egyenlő a nullával
            int i = 0; // az i egyenlő a nullával

            while (i < data.Length)
            {
                if (data[i] == '1') // végigjárás a for-ciklussal, olvasás és írásra
                {
                    ++islandCount;
                    int j = i; // A j egyenlő az i-vel
                    int tmp = 0; // a tmp egyenlő a 0-val/számmal
                    while (j < data.Length && data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > maxIslandLength) { maxIslandLength = tmp; } // végigjárás a for-ciklussal, olvasás és írásra 
                }
                else
                {
                    ++i;
                }
            }
    }
}
