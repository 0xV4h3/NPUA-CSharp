using Practical9.Models;

namespace Practical9.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> _students = new List<Student>
        {
            new Student{ Id = 1, Name = "Anna", Age = 19 },
            new Student{ Id = 2, Name = "Karen", Age = 22 },
        };

        public IEnumerable<Student> GetAll() => _students;
        public Student? GetById(int id) => _students.FirstOrDefault(s => s.Id == id);

        public void Add(StudentCreateModel model)
        {
            var nextId = (_students.Count > 0) ? _students.Max(s => s.Id) + 1 : 1;
            _students.Add(new Student
            {
                Id = nextId,
                Name = model.Name,
                Age = model.Age
            });
        }
    }
}