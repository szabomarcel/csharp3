using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetekobj
{
    internal class Szigetszamolas
    {
        // Osztályváltózok
        int islandCount = 0,
            maxIslandLength = 0,
            i = 0;
        string data = string.Empty;

        //Kontruktorok
        public Szigetszamolas() { }
        public Szigetszamolas(string data)
        {
            this.data = data;
        }

        //Metódus
        public void setData(string data) { this.data = data; }
        public string getData() { return data; }
        public int getIslandCount() { return this.islandCount; }
        public int getMaxIslandLenght() { return this.maxIslandLength; }
        public void szamol()
        {
            while (i < data.Length)
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0;
                    while (j < data.Length && data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > this.maxIslandLength) { this.maxIslandLength = tmp; }
                }
                else
                {
                    ++i;
                }
            }
        }
    }
}
