using Practical7.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practical7.Repositories
{
    public interface IUserProfileRepository
    {
        Task<IEnumerable<UserProfile>> GetAllAsync();
        Task<UserProfile> GetByIdAsync(int id);
        Task AddAsync(UserProfile user);
        Task UpdateAsync(UserProfile user);
        Task DeleteAsync(int id);
        Task SaveAsync();
    }
}