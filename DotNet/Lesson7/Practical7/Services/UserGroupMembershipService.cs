using System.Collections.Generic;
using Practical7.DTOs;
using Practical7.Models;
using Practical7.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Practical7.Services
{
    public class UserGroupMembershipService : IUserGroupMembershipService
    {
        private readonly IUserGroupMembershipRepository _repo;

        public UserGroupMembershipService(IUserGroupMembershipRepository repo) => _repo = repo;

        public async Task<IEnumerable<UserGroupMembershipDto>> GetAllAsync()
            => (await _repo.GetAllAsync()).Select(ToDto);

        public async Task<UserGroupMembershipDto> GetByIdAsync(int id)
            => ToDto(await _repo.GetByIdAsync(id));

        public async Task CreateAsync(UserGroupMembershipDto dto)
        {
            var m = new UserGroupMembership
            {
                UserProfileId = dto.UserProfileId,
                GroupId = dto.GroupId,
                IsPrimary = dto.IsPrimary,
                FromDate = dto.FromDate,
                ToDate = dto.ToDate
            };
            await _repo.AddAsync(m);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(UserGroupMembershipDto dto)
        {
            var m = await _repo.GetByIdAsync(dto.Id);
            if (m != null)
            {
                m.UserProfileId = dto.UserProfileId;
                m.GroupId = dto.GroupId;
                m.IsPrimary = dto.IsPrimary;
                m.FromDate = dto.FromDate;
                m.ToDate = dto.ToDate;
                await _repo.UpdateAsync(m);
                await _repo.SaveAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
            await _repo.SaveAsync();
        }

        private static UserGroupMembershipDto ToDto(UserGroupMembership m)
            => m == null ? null : new UserGroupMembershipDto
            {
                Id = m.Id,
                UserProfileId = m.UserProfileId,
                GroupId = m.GroupId,
                IsPrimary = m.IsPrimary,
                FromDate = m.FromDate,
                ToDate = m.ToDate
            };
    }
}