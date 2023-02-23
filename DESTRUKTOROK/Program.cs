using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESTRUKTOROK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foglalt memória: {0}", GC.GetTotalMemory(false));
            int[][] array = new int[10][];
            for (int i = 0; i < 10; ++i)
            {
                array[i] = new int[1000];
            }
            WeakReference wr = new WeakReference(array);
            array = null;
            if (wr.Target != null) 
            {
                int[][] array = (int[][])wr.Target;
            }
            Console.WriteLine("Foglalt memória: {0}", GC.GetTotalMemory(false));
            GC.Collect(); // meghívjuk a szemétgyűjtőt 
            Console.WriteLine("Foglalt memória: {0}", GC.GetTotalMemory(false));
            Console.ReadKey();
        }
    }
}
