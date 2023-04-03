using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NegyszogOOP
{
    internal class Program : Negyszog
    {
        static void Main(string[] args)
        {
            Negyszog negyszog = new Negyszog();
            negyszog.i = 0;
            negyszog.y = 0;
            negyszog.x = 0;
            negyszog.ran = 0;
            Console.ReadKey();
        }
    }
}
