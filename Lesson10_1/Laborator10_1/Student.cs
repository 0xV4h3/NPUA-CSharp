using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator10_1
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public override string ToString() => $"{Name}: {Grade}";
    }
}
