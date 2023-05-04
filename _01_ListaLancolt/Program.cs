using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ListaLancolt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lista = new LinkedList<string>();
            
            // Hozáadás
            lista.AddLast("egy");
            lista.AddLast("példa");
            lista.AddLast("program");
            lista.AddLast("lenne");

            // Balról bővítés 
            lista.AddFirst("Ez");

            // Beszúrás
            lista.AddAfter(lista.Find("példa"), "Beszúr mögé");
            lista.AddBefore(lista.Find("példa"), "Beszúr elé");

            Console.WriteLine("Lánc elemek száma: {0}\n",lista.Count);
            Console.WriteLine("Lánc tartalma előre: ");

            foreach(var elem in lista)
            {
                Console.Write("{0} ",elem);
            }
            Console.WriteLine("\nLánctartalma vissza: ");
            var vissza = lista.Last;
            while(vissza != null)
            {
                Console.Write("{0} ", vissza.Value);
                vissza = vissza.Previous;
            }
            Console.ReadKey();
        }
    }
}
