using Microsoft.EntityFrameworkCore;
using Practical7.Data;
using Practical7.Models;

namespace Practical7.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly ApplicationDbContext _context;
        public GroupRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Group>> GetAllAsync() =>
            await _context.Groups.AsNoTracking().ToListAsync();

        public async Task<Group> GetByIdAsync(int id) =>
            await _context.Groups.FindAsync(id);

        public async Task AddAsync(Group group)
        {
            await _context.Groups.AddAsync(group);
        }

        public Task UpdateAsync(Group group)
        {
            _context.Groups.Update(group);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Groups.FindAsync(id);
            if (entity != null) _context.Groups.Remove(entity);
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}