namespace Homework7
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public Task<User?> GetByIdAsync(Guid id) =>
            _repo.GetByIdAsync(id);

        public async Task<bool> CreateUserAsync(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name) || age <= 0)
                return false;
            var user = new User { Id = Guid.NewGuid(), Name = name, Age = age };
            await _repo.AddAsync(user);
            return true;
        }

        public Task<List<User>> GetAllUsersAsync() =>
            _repo.GetAllAsync();

        public Task<bool> DeleteUserAsync(Guid id) =>
            _repo.RemoveAsync(id);
    }
}