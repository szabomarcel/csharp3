using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace TestApp
{
    class Person
    {
        public Person() { }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Name = "István"
            };
            Console.WriteLine(p.Name);
            Console.ReadKey();
        }
    }
}