using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Practical7.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Practical7.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly string _path;
        private SeedData _seed;

        public GroupRepository(string path)
        {
            _path = path;
            _seed = JsonConvert.DeserializeObject<SeedData>(File.ReadAllText(_path));
        }
        public Task<IEnumerable<Group>> GetAllAsync() =>
            Task.FromResult(_seed.Groups.AsEnumerable());
        public Task<Group> GetByIdAsync(int id) =>
            Task.FromResult(_seed.Groups.FirstOrDefault(g => g.Id == id));
        public Task AddAsync(Group group)
        {
            group.Id = _seed.Groups.Any() ? _seed.Groups.Max(u => u.Id) + 1 : 1;
            _seed.Groups.Add(group);
            return Task.CompletedTask;
        }
        public Task UpdateAsync(Group group)
        {
            var idx = _seed.Groups.FindIndex(x => x.Id == group.Id);
            if (idx >= 0) _seed.Groups[idx] = group;
            return Task.CompletedTask;
        }
        public Task DeleteAsync(int id)
        {
            _seed.Groups.RemoveAll(g => g.Id == id);
            return Task.CompletedTask;
        }
        public async Task SaveAsync()
        {
            var content = JsonConvert.SerializeObject(_seed, Formatting.Indented);
            await File.WriteAllTextAsync(_path, content);
        }
    }
}