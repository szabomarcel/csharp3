using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    class DisposableClass : IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Console.WriteLine("Takarítunk...");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // managed erõforrások felszabadítása 
                }
                // unmanaged erõforrások felszabadítása

                disposed = true;
            }
        }

        ~DisposableClass()
        {
            Dispose(false);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (DisposableClass dc = new DisposableClass()) ;
            {

            }

            Console.ReadKey();
        }
    }
}
