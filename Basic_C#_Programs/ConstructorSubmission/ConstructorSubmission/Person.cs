using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class Person
    {
        // Chaining two constructors
        public Person(string name) : this(name, 0)
        {
        }

        public Person(string name, int age)
        {
            name = name;
            age = age;
        }

        public string name { get; set; }
        public int age { get; set; }
    }
}
