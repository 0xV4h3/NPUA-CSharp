using System.Collections.Generic;
using System.Threading.Tasks;
using Practical7.Models;

namespace Practical7.Repositories
{
    public interface IGroupRepository
    {
        Task<IEnumerable<Group>> GetAllAsync();
        Task<Group> GetByIdAsync(int id);
        Task AddAsync(Group group);
        Task UpdateAsync(Group group);
        Task DeleteAsync(int id);
        Task SaveAsync();
    }
}