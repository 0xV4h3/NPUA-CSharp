using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Practical7.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Practical7.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly string _path;
        private SeedData _seed;

        public DepartmentRepository(string path)
        {
            _path = path;
            _seed = JsonConvert.DeserializeObject<SeedData>(File.ReadAllText(_path));
        }

        public Task<IEnumerable<Department>> GetAllAsync() =>
            Task.FromResult(_seed.Departments.AsEnumerable());

        public Task<Department> GetByIdAsync(int id) =>
            Task.FromResult(_seed.Departments.FirstOrDefault(d => d.Id == id));

        public Task AddAsync(Department department)
        {
            department.Id = _seed.Departments.Any() ? _seed.Departments.Max(d => d.Id) + 1 : 1;
            _seed.Departments.Add(department);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Department department)
        {
            var idx = _seed.Departments.FindIndex(x => x.Id == department.Id);
            if (idx >= 0) _seed.Departments[idx] = department;
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            _seed.Departments.RemoveAll(d => d.Id == id);
            return Task.CompletedTask;
        }

        public async Task SaveAsync()
        {
            var content = JsonConvert.SerializeObject(_seed, Formatting.Indented);
            await File.WriteAllTextAsync(_path, content);
        }
    }
}