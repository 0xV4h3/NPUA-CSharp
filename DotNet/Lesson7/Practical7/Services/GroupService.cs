using System.Collections.Generic;
using Practical7.DTOs;
using Practical7.Models;
using Practical7.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Practical7.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _repo;

        public GroupService(IGroupRepository repo) => _repo = repo;

        public async Task<IEnumerable<GroupDto>> GetAllAsync()
            => (await _repo.GetAllAsync()).Select(ToDto);

        public async Task<GroupDto> GetByIdAsync(int id)
            => ToDto(await _repo.GetByIdAsync(id));

        public async Task CreateAsync(GroupDto dto)
        {
            var g = new Group
            {
                Name = dto.Name,
                Year = dto.Year,
                DepartmentId = dto.DepartmentId
            };
            await _repo.AddAsync(g);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(GroupDto dto)
        {
            var group = await _repo.GetByIdAsync(dto.Id);
            if (group != null)
            {
                group.Name = dto.Name;
                group.Year = dto.Year;
                group.DepartmentId = dto.DepartmentId;
                await _repo.UpdateAsync(group);
                await _repo.SaveAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
            await _repo.SaveAsync();
        }

        private static GroupDto ToDto(Group g)
            => g == null ? null : new GroupDto
            {
                Id = g.Id,
                Name = g.Name,
                Year = g.Year,
                DepartmentId = g.DepartmentId
            };
    }
}