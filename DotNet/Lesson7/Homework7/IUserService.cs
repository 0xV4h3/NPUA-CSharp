namespace Homework7
{
    public interface IUserService
    {
        Task<User?> GetByIdAsync(Guid id);
        Task<bool> CreateUserAsync(string name, int age);
        Task<List<User>> GetAllUsersAsync();
        Task<bool> DeleteUserAsync(Guid id);
    }
}