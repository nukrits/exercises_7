using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_7
{
    public class Student
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public double GPA { get; set; }

        public Student(string name, string lastName, double gpa)
        {
            Name = name;
            LastName = lastName;
            gpa = GPA;
        }
    }
}
