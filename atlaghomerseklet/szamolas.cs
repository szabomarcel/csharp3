using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace atlaghomerseklet
{
    internal class program
    {
        static void Main()
        {
            List<honap> yearTemp = new List<honap>();
            for (int i = 0; i < 12; i++)
            {
                yearTemp.Add(new honap());
            }
        }
    }
    class honap
    {
        Random random = new Random();
        private int[] Honap;

        public honap()
        {
            Honap = new int[30];
            for (int i = 0; i < Honap.Length; i++) { Honap[i] = random.Next(-20, 43); }
        }
        public int GetTemp(int index)
        {
            return Honap[ index];
        }
        public int GetMaxTemp()
        {
            int MaxValue = -20;
            foreach (int curTemp in Honap)
            {
                if (curTemp > MaxValue) MaxValue = curTemp;
            }
            return MaxValue;
        }
        public int GetMinTemp()
        {
            int MinValue = 43;
            foreach (int curTemp in Honap)
            {
                if (curTemp < MinValue) MinValue = curTemp;
            }
            return MinValue;
        }
    }
}