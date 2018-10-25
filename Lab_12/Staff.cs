using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Staff : Person
    {
        string Name;
        string Address;
        string School;
        double Pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            Name = name;
            Address = address;

            School = school;
            Pay = pay;
        }
        public override void Play()
        {
            Console.WriteLine("I am {0} and live in a {1}, I work for {2}. They pay me {3} per class!", Name, Address, School, Pay);
        }
    }
}
