namespace Homework7
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id);
        Task AddAsync(User user);
        Task<List<User>> GetAllAsync();
        Task<bool> RemoveAsync(Guid id);
    }
}