using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Student : Person
    {
        string Name;
        string Address;
        string Program;
        double Fee;
        int Year;

        public Student(string name, string address, string program, double fee, int year) : base(name, address)
        {
            Name = name;
            Address = address;

            Program = program;
            Fee = fee;
            Year = year;
        }
        public override void Play()
        {
            Console.WriteLine("I am {0} from {1} I am in the {2} Program and am paying {3}. It's currently {4}", Name, Address, Program, Fee, Year );
        }
    }
}
