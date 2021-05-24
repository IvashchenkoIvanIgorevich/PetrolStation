using System.Collections;
using System.Collections.Generic;

namespace PetrolStation.Model
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int ID { get; }
        public Staff Type { get; set; }
        public IEnumerable<Person> SubOrdinates { get; set; }

        public Person(string staffName, Staff staffType)
        {
            Name = staffName;
            Type = staffType;
        }
    }
}
