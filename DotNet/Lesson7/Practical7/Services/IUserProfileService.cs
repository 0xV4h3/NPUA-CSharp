using System.Collections.Generic;
using System.Threading.Tasks;
using Practical7.DTOs;

namespace Practical7.Services
{
    public interface IUserProfileService
    {
        Task<IEnumerable<UserProfileDto>> GetAllAsync();
        Task<UserProfileDto> GetByIdAsync(int id);
        Task CreateAsync(UserProfileDto dto);
        Task UpdateAsync(UserProfileDto dto);
        Task DeleteAsync(int id);
    }
}