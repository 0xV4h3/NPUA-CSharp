using Microsoft.EntityFrameworkCore;
using Practical7.Data;
using Practical7.Models;

namespace Practical7.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ApplicationDbContext _context;
        public UserProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserProfile>> GetAllAsync() =>
            await _context.UserProfiles.AsNoTracking().ToListAsync();

        public async Task<UserProfile> GetByIdAsync(int id) =>
            await _context.UserProfiles.FindAsync(id);

        public async Task AddAsync(UserProfile user)
        {
            await _context.UserProfiles.AddAsync(user);
        }

        public Task UpdateAsync(UserProfile user)
        {
            _context.UserProfiles.Update(user);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.UserProfiles.FindAsync(id);
            if (entity != null) _context.UserProfiles.Remove(entity);
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}