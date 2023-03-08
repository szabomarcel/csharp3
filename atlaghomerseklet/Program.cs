using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlaghomerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            var homerseklet = new List<int>();
            var random = new Random();
            for (int i = 1; i < 10; i++)
            {
                homerseklet.Add(random.Next(-20, 43));
            }
            int min = homerseklet.Min();
            Console.WriteLine("Legkisebb: " + min);
            Console.WriteLine("Legnagyobb: " + homerseklet.Max());
            Console.WriteLine("Melyik nap a leghidegebb: " + (homerseklet.IndexOf(min) + 1));
            homerseklet.Sort();
            Console.WriteLine("Növekvő sorrend: " + string.Join(", ",homerseklet));
            #endregion

            #region
            var homerseklet2 = new List<int>();
            var Random = new Random();
            for (int i = 1; i < 10; i++)
            {
                homerseklet2.Add(Random.Next(-20, 43));
            }
            int Min = homerseklet2.Min();
            Console.WriteLine("Legkisebb: " + Min);
            Console.WriteLine("Legnagyobb: " + homerseklet2.Max());
            Console.WriteLine("Melyik hónapban a leghidegebb: " + (homerseklet2.IndexOf(Min) + 1));
            homerseklet.Sort();
            Console.WriteLine("Növekvő sorrend: " + string.Join(", ", homerseklet2));
            #endregion
        }

    }
}
