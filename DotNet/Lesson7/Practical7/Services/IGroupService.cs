using System.Collections.Generic;
using System.Threading.Tasks;
using Practical7.DTOs;

namespace Practical7.Services
{
    public interface IGroupService
    {
        Task<IEnumerable<GroupDto>> GetAllAsync();
        Task<GroupDto> GetByIdAsync(int id);
        Task CreateAsync(GroupDto dto);
        Task UpdateAsync(GroupDto dto);
        Task DeleteAsync(int id);
    }
}