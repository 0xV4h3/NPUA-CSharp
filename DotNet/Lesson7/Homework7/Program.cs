using Microsoft.Extensions.DependencyInjection;

namespace Homework7
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Select repository type:");
            Console.WriteLine("1: File repository");
            Console.WriteLine("2: In-memory repository");
            Console.Write("Enter your choice (1 or 2): ");
            var repoChoice = Console.ReadLine();

            var services = new ServiceCollection();
            if (repoChoice == "1")
                services.AddSingleton<IUserRepository>(new FileUserRepository("users.json"));
            else
                services.AddSingleton<IUserRepository, InMemoryUserRepository>();

            services.AddTransient<IUserService, UserService>();
            var provider = services.BuildServiceProvider();
            var userService = provider.GetRequiredService<IUserService>();

            Console.WriteLine("\nSelect action:");
            Console.WriteLine("1: Create user");
            Console.WriteLine("2: Find user by id");
            Console.WriteLine("3: Show all users");
            Console.WriteLine("4: Delete user by id");
            Console.WriteLine("5: Exit");

            while (true)
            {
                Console.Write("\nEnter your choice (1-5): ");
                var action = Console.ReadLine();

                if (action == "1")
                {
                    Console.Write("Enter user name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.TryParse(Console.ReadLine(), out int tmpAge) ? tmpAge : 0;
                    var user = new User { Id = Guid.NewGuid(), Name = name, Age = age };
                    var result = await userService.CreateUserAsync(user.Name, user.Age);
                    if (result)
                        Console.WriteLine($"User created. Id: {user.Id}");
                    else
                        Console.WriteLine("Invalid data; user not created.");
                }
                else if (action == "2")
                {
                    Console.Write("Enter user id: ");
                    Guid id = Guid.TryParse(Console.ReadLine(), out Guid tmpId) ? tmpId : Guid.Empty;
                    if (id == Guid.Empty)
                    {
                        Console.WriteLine("Invalid id format.");
                        continue;
                    }
                    var user = await userService.GetByIdAsync(id);
                    if (user == null)
                        Console.WriteLine("User not found.");
                    else
                        Console.WriteLine($"User found: {user.Name}, Age: {user.Age}, Id: {user.Id}");
                }
                else if (action == "3")
                {
                    var users = await userService.GetAllUsersAsync();
                    if (users.Count == 0)
                        Console.WriteLine("No users found.");
                    else
                    {
                        Console.WriteLine("Users list:");
                        foreach (var user in users)
                            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
                    }
                }
                else if (action == "4")
                {
                    Console.Write("Enter user id to delete: ");
                    Guid id = Guid.TryParse(Console.ReadLine(), out Guid tmpId) ? tmpId : Guid.Empty;
                    if (id == Guid.Empty)
                    {
                        Console.WriteLine("Invalid id format.");
                        continue;
                    }
                    var deleted = await userService.DeleteUserAsync(id);
                    Console.WriteLine(deleted ? "User deleted." : "User not found.");
                }
                else if (action == "5")
                {
                    Console.WriteLine("Exiting.");
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown action selected.");
                }
            }
        }
    }
}