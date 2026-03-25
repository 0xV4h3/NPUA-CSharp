using Practical7.Repositories;
using Practical7.Services;
using Practical7.Views;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var path = System.IO.Path.Combine("Data", "seed.json");

        var upRepo = new UserProfileRepository(path);
        var upService = new UserProfileService(upRepo);
        var upView = new UserProfileCliView(upService);

        var depRepo = new DepartmentRepository(path);
        var depService = new DepartmentService(depRepo);
        var depView = new DepartmentCliView(depService);

        var grRepo = new GroupRepository(path);
        var grService = new GroupService(grRepo);
        var grView = new GroupCliView(grService);

        var memRepo = new UserGroupMembershipRepository(path);
        var memService = new UserGroupMembershipService(memRepo);
        var memView = new UserGroupMembershipCliView(memService);

        while (true)
        {
            Console.WriteLine("\n==== PRACTICAL7 MENU ====");
            Console.WriteLine("1. User Profiles");
            Console.WriteLine("2. Departments");
            Console.WriteLine("3. Groups");
            Console.WriteLine("4. Memberships");
            Console.WriteLine("5. Exit");
            Console.Write("Select: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    await upView.RunAsync();
                    break;
                case "2":
                    await depView.RunAsync();
                    break;
                case "3":
                    await grView.RunAsync();
                    break;
                case "4":
                    await memView.RunAsync();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
            }
        }
    }
}