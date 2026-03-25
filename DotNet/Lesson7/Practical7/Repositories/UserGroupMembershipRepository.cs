using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Practical7.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Practical7.Repositories
{
    public class UserGroupMembershipRepository : IUserGroupMembershipRepository
    {
        private readonly string _path;
        private SeedData _seed;

        public UserGroupMembershipRepository(string path)
        {
            _path = path;
            _seed = JsonConvert.DeserializeObject<SeedData>(File.ReadAllText(_path));
        }
        public Task<IEnumerable<UserGroupMembership>> GetAllAsync() =>
            Task.FromResult(_seed.UserGroupMemberships.AsEnumerable());
        public Task<UserGroupMembership> GetByIdAsync(int id) =>
            Task.FromResult(_seed.UserGroupMemberships.FirstOrDefault(m => m.Id == id));
        public Task AddAsync(UserGroupMembership membership)
        {
            membership.Id = _seed.UserGroupMemberships.Any() ? _seed.UserGroupMemberships.Max(u => u.Id) + 1 : 1;
            _seed.UserGroupMemberships.Add(membership);
            return Task.CompletedTask;
        }
        public Task UpdateAsync(UserGroupMembership membership)
        {
            var idx = _seed.UserGroupMemberships.FindIndex(x => x.Id == membership.Id);
            if (idx >= 0) _seed.UserGroupMemberships[idx] = membership;
            return Task.CompletedTask;
        }
        public Task DeleteAsync(int id)
        {
            _seed.UserGroupMemberships.RemoveAll(m => m.Id == id);
            return Task.CompletedTask;
        }
        public async Task SaveAsync()
        {
            var content = JsonConvert.SerializeObject(_seed, Formatting.Indented);
            await File.WriteAllTextAsync(_path, content);
        }
    }
}