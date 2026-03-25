using System.Collections.Generic;
using Practical7.DTOs;
using Practical7.Models;
using Practical7.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Practical7.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repo;

        public DepartmentService(IDepartmentRepository repo) => _repo = repo;

        public async Task<IEnumerable<DepartmentDto>> GetAllAsync()
        {
            var departments = await _repo.GetAllAsync();
            return departments.Select(ToDto);
        }

        public async Task<DepartmentDto> GetByIdAsync(int id)
        {
            var d = await _repo.GetByIdAsync(id);
            return ToDto(d);
        }

        public async Task CreateAsync(DepartmentDto dto)
        {
            var d = new Department { Name = dto.Name };
            await _repo.AddAsync(d);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(DepartmentDto dto)
        {
            var dep = await _repo.GetByIdAsync(dto.Id);
            if (dep != null)
            {
                dep.Name = dto.Name;
                await _repo.UpdateAsync(dep);
                await _repo.SaveAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
            await _repo.SaveAsync();
        }

        private static DepartmentDto ToDto(Department d) =>
            d == null ? null : new DepartmentDto { Id = d.Id, Name = d.Name };
    }
}