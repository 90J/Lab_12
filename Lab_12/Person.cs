using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Person
    {
        string Name;
        string Address;

        public Person(string name, string address)
        {
        Name = name;
        Address = address;
        }

        public virtual void Play()
        {
            Console.WriteLine("I am {0} and live in {1}", Name, Address);
        }

    }
}
