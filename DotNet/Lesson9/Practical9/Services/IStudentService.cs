using Practical9.Models;

namespace Practical9.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student? GetById(int id);
        void Add(StudentCreateModel model);
    }
}