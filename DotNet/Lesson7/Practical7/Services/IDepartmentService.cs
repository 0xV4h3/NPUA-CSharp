using System.Collections.Generic;
using System.Threading.Tasks;
using Practical7.DTOs;

namespace Practical7.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllAsync();
        Task<DepartmentDto> GetByIdAsync(int id);
        Task CreateAsync(DepartmentDto dto);
        Task UpdateAsync(DepartmentDto dto);
        Task DeleteAsync(int id);
    }
}