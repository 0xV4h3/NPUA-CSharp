using System.Collections.Generic;
using System.Threading.Tasks;
using Practical7.Models;

namespace Practical7.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllAsync();
        Task<Department> GetByIdAsync(int id);
        Task AddAsync(Department department);
        Task UpdateAsync(Department department);
        Task DeleteAsync(int id);
        Task SaveAsync();
    }
}