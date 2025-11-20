using System;

namespace Laborator14
{
    public class Student
    {
        public string Name { get; }
        public int Age { get; }

        public Student(string name, int age) => (Name, Age) = (name, age);

        public override string ToString() => $"{Name} ({Age})";
    }
}