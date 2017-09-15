using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS
{
    public abstract class Person
    {
        public Person(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public Person() : this("?","???-??-????")
        {

        }

        public string Name { get; protected set; }
        public string Id { get; protected set; }

        public abstract override string ToString();

        public virtual void Display()
        {
            Console.WriteLine("Person Information:");
            Console.Write("\tName: " + this.Name);
            Console.Write("\tId number: " + this.Id);

        }

    }
}
