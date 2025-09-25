using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int StudentId { get; set; }
        public static int Count { get; private set; }

        public Student() : this("Unknown", 0, 0) { }
        public Student(string name) : this(name, 0, 0) { }
        public Student(string name, int age) : this(name, age, 0) { }
        public Student(string name, int age, int studentId)
        {
            Name = name;
            Age = age;
            StudentId = studentId;
            Count++;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Id: {StudentId}";
        }
    }
}
