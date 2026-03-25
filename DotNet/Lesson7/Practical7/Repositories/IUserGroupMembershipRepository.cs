using System.Collections.Generic;
using System.Threading.Tasks;
using Practical7.Models;

namespace Practical7.Repositories
{
    public interface IUserGroupMembershipRepository
    {
        Task<IEnumerable<UserGroupMembership>> GetAllAsync();
        Task<UserGroupMembership> GetByIdAsync(int id);
        Task AddAsync(UserGroupMembership membership);
        Task UpdateAsync(UserGroupMembership membership);
        Task DeleteAsync(int id);
        Task SaveAsync();
    }
}