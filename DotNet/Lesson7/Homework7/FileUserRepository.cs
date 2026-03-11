using System.Text.Json;
namespace Homework7
{
    public class FileUserRepository : IUserRepository
    {
        private readonly string _path;
        public FileUserRepository(string path)
        {
            _path = path;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var users = await GetAllAsync();
            return users.FirstOrDefault(u => u.Id == id);
        }

        public async Task AddAsync(User user)
        {
            var users = await GetAllAsync();
            users.Add(user);
            var newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_path, newJson);
        }

        public async Task<List<User>> GetAllAsync()
        {
            if (!File.Exists(_path))
                return new List<User>();
            var json = await File.ReadAllTextAsync(_path);
            var users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            return users;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var users = await GetAllAsync();
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
                var newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                await File.WriteAllTextAsync(_path, newJson);
                return true;
            }
            return false;
        }
    }
}