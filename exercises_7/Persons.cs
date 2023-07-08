using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_7
{
    public class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }

        public Person()
        {
            Name = "Noname";
            Age = 0;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
