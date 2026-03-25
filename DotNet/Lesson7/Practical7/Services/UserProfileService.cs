using System.Collections.Generic;
using Practical7.DTOs;
using Practical7.Models;
using Practical7.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Practical7.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _repo;

        public UserProfileService(IUserProfileRepository repo) => _repo = repo;

        public async Task<IEnumerable<UserProfileDto>> GetAllAsync()
            => (await _repo.GetAllAsync()).Select(ToDto);

        public async Task<UserProfileDto> GetByIdAsync(int id)
            => ToDto(await _repo.GetByIdAsync(id));

        public async Task CreateAsync(UserProfileDto dto)
        {
            var p = new UserProfile
            {
                FirstName = dto.FullName.Split(' ')[0],
                LastName = dto.FullName.Split(' ').Length > 1 ? dto.FullName.Split(' ')[1] : "",
                Email = dto.Email,
                Role = dto.Role,
                IsActive = dto.IsActive
            };
            await _repo.AddAsync(p);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(UserProfileDto dto)
        {
            var user = await _repo.GetByIdAsync(dto.Id);
            if (user != null)
            {
                user.FirstName = dto.FullName.Split(' ')[0];
                user.LastName = dto.FullName.Split(' ').Length > 1 ? dto.FullName.Split(' ')[1] : "";
                user.Email = dto.Email;
                user.Role = dto.Role;
                user.IsActive = dto.IsActive;
                await _repo.UpdateAsync(user);
                await _repo.SaveAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
            await _repo.SaveAsync();
        }

        private static UserProfileDto ToDto(UserProfile user)
            => user == null ? null :
                new UserProfileDto
                {
                    Id = user.Id,
                    FullName = $"{user.FirstName} {user.LastName}",
                    Email = user.Email,
                    Role = user.Role,
                    IsActive = user.IsActive
                };
    }
}