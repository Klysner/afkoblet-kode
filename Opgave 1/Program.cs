using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThreeCases
{
    internal class DanseMenu
    {
        class Person
        {
            private int age;
            private string name;
            public Person(string nm)
            { name = nm; }

            public string getName()
            { return name; }

        }
        static void Main(string[] args)
        {
            Person p = new Person("David");
            Console.WriteLine(p.getName());
            Console.ReadKey();
        }
    }
    }

