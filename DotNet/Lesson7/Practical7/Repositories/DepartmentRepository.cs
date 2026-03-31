using Microsoft.EntityFrameworkCore;
using Practical7.Data;
using Practical7.Models;

namespace Practical7.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetAllAsync() =>
            await _context.Departments.AsNoTracking().ToListAsync();

        public async Task<Department> GetByIdAsync(int id) =>
            await _context.Departments.FindAsync(id);

        public async Task AddAsync(Department department)
        {
            await _context.Departments.AddAsync(department);
        }

        public Task UpdateAsync(Department department)
        {
            _context.Departments.Update(department);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Departments.FindAsync(id);
            if (entity != null) _context.Departments.Remove(entity);
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}