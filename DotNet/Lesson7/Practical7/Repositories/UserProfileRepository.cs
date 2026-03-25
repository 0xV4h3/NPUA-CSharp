using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Practical7.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Practical7.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly string _path;
        private SeedData _seed;

        public UserProfileRepository(string path)
        {
            _path = path;
            _seed = JsonConvert.DeserializeObject<SeedData>(File.ReadAllText(_path));
        }
        public Task<IEnumerable<UserProfile>> GetAllAsync() =>
            Task.FromResult(_seed.UserProfiles.AsEnumerable());
        public Task<UserProfile> GetByIdAsync(int id) =>
            Task.FromResult(_seed.UserProfiles.FirstOrDefault(u => u.Id == id));
        public Task AddAsync(UserProfile user)
        {
            user.Id = _seed.UserProfiles.Any() ? _seed.UserProfiles.Max(u => u.Id) + 1 : 1;
            _seed.UserProfiles.Add(user);
            return Task.CompletedTask;
        }
        public Task UpdateAsync(UserProfile user)
        {
            var idx = _seed.UserProfiles.FindIndex(x => x.Id == user.Id);
            if (idx >= 0) _seed.UserProfiles[idx] = user;
            return Task.CompletedTask;
        }
        public Task DeleteAsync(int id)
        {
            _seed.UserProfiles.RemoveAll(u => u.Id == id);
            return Task.CompletedTask;
        }
        public async Task SaveAsync()
        {
            var content = JsonConvert.SerializeObject(_seed, Formatting.Indented);
            await File.WriteAllTextAsync(_path, content);
        }
    }
}