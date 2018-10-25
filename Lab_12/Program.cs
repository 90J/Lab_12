using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];
            person[0] = new Student("Jay", "Macomb", "dev.build", 250000.0, 2018);
            person[1] = new Staff("Tim", "Dungeon", "GC", 500000.0);
            person[2] = new Person("Chelle", "Toledo");
            //person[3] = new StaffStudent("Betty", "NC", "Retired", "House", 25, 50, 1947); //See note in StaffStudent


             

            foreach (Person character in person)
            {
                character.Play();
            }



        }
    }
}
