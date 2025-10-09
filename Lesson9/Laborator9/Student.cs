using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student(string name, int grade) { Name = name; Grade = grade; }
        public int CompareTo(Student? other) => Grade.CompareTo(other?.Grade ?? 0);
        public override string ToString() => $"{Name}: {Grade}";
    }
}
