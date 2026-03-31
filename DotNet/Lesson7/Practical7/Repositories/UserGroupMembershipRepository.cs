using Microsoft.EntityFrameworkCore;
using Practical7.Data;
using Practical7.Models;

namespace Practical7.Repositories
{
    public class UserGroupMembershipRepository : IUserGroupMembershipRepository
    {
        private readonly ApplicationDbContext _context;
        public UserGroupMembershipRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserGroupMembership>> GetAllAsync() =>
            await _context.UserGroupMemberships.AsNoTracking().ToListAsync();

        public async Task<UserGroupMembership> GetByIdAsync(int id) =>
            await _context.UserGroupMemberships.FindAsync(id);

        public async Task AddAsync(UserGroupMembership membership)
        {
            await _context.UserGroupMemberships.AddAsync(membership);
        }

        public Task UpdateAsync(UserGroupMembership membership)
        {
            _context.UserGroupMemberships.Update(membership);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.UserGroupMemberships.FindAsync(id);
            if (entity != null) _context.UserGroupMemberships.Remove(entity);
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}