using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_es_maximum_kereses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1000; //minimum érték egyenlő
            int max = -1; //maximum érték egyenlő
            int minIdx = 0; //minimum Index érték egyenlő 
            int maxIdx = 0; //maximum Index érték egyenlő

            // végigjárás a for-ciklussal, olvasás és írásra (eldöndendő a minimumra és a maximumnra)
            for (int i = 0; i < 30; ++i)
            {
                // minimumra hozzás
                if (array[i] < min)
                {
                    min = array[i];
                    minIdx = i;
                }

                // végigjárás a for-ciklussal, olvasás és írásra (maximumra hozzás)
                if (array[i] > max)
                {
                    max = array[i];
                    maxIdx = i;
                }
            }
    }
}
