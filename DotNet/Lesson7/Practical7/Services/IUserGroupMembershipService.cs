using System.Collections.Generic;
using System.Threading.Tasks;
using Practical7.DTOs;

namespace Practical7.Services
{
    public interface IUserGroupMembershipService
    {
        Task<IEnumerable<UserGroupMembershipDto>> GetAllAsync();
        Task<UserGroupMembershipDto> GetByIdAsync(int id);
        Task CreateAsync(UserGroupMembershipDto dto);
        Task UpdateAsync(UserGroupMembershipDto dto);
        Task DeleteAsync(int id);
    }
}