using Practical7.Services;
using Practical7.DTOs;
using System;
using System.Threading.Tasks;

namespace Practical7.Views
{
    public class UserProfileCliView
    {
        private readonly IUserProfileService _profileService;

        public UserProfileCliView(IUserProfileService profileService)
        {
            _profileService = profileService;
        }

        public async Task RunAsync()
        {
            while (true)
            {
                Console.WriteLine("\n1. List profiles\n2. Get profile by Id\n3. Add profile\n4. Delete profile\n5. Exit");
                Console.Write("Select: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var profiles = await _profileService.GetAllAsync();
                        foreach (var p in profiles)
                            Console.WriteLine($"{p.Id}: {p.FullName} ({p.Email}) [{p.Role}, Active: {p.IsActive}]");
                        break;
                    case "2":
                        Console.Write("Enter Id: ");
                        if (int.TryParse(Console.ReadLine(), out int id2))
                        {
                            var p = await _profileService.GetByIdAsync(id2);
                            if (p != null)
                                Console.WriteLine($"{p.Id}: {p.FullName} ({p.Email}) [{p.Role}, Active: {p.IsActive}]");
                            else Console.WriteLine("Not found");
                        }
                        break;
                    case "3":
                        Console.Write("Full name: ");
                        var name = Console.ReadLine();
                        Console.Write("E-mail: ");
                        var email = Console.ReadLine();
                        Console.Write("Role: ");
                        var role = Console.ReadLine();
                        Console.Write("Active (y/n): ");
                        var isActive = Console.ReadLine()?.ToLower() == "y";
                        await _profileService.CreateAsync(new UserProfileDto { FullName = name, Email = email, Role = role, IsActive = isActive });
                        Console.WriteLine("Created.");
                        break;
                    case "4":
                        Console.Write("Enter Id to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int id3))
                        {
                            await _profileService.DeleteAsync(id3);
                            Console.WriteLine("Deleted.");
                        }
                        break;
                    case "5":
                        return;
                }
            }
        }
    }
}