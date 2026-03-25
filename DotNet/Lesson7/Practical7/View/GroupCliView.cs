using Practical7.Services;
using Practical7.DTOs;
using System;
using System.Threading.Tasks;

namespace Practical7.Views
{
    public class GroupCliView
    {
        private readonly IGroupService _service;

        public GroupCliView(IGroupService service)
        {
            _service = service;
        }

        public async Task RunAsync()
        {
            while (true)
            {
                Console.WriteLine("\n1. List Groups\n2. Add Group\n3. Edit Group\n4. Delete Group\n5. Exit");
                Console.Write("Select> ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var groups = await _service.GetAllAsync();
                        foreach (var g in groups)
                            Console.WriteLine($"{g.Id}: {g.Name}, Year: {g.Year}, DeptId: {g.DepartmentId}");
                        break;
                    case "2":
                        Console.Write("Group name: ");
                        var name = Console.ReadLine();
                        Console.Write("Year: ");
                        int.TryParse(Console.ReadLine(), out int year);
                        Console.Write("Department Id: ");
                        int.TryParse(Console.ReadLine(), out int depId);
                        await _service.CreateAsync(new GroupDto { Name = name, Year = year, DepartmentId = depId });
                        Console.WriteLine("Added.");
                        break;
                    case "3":
                        Console.Write("Group Id to edit: ");
                        int.TryParse(Console.ReadLine(), out int editId);
                        Console.Write("New name: ");
                        var newName = Console.ReadLine();
                        Console.Write("New year: ");
                        int.TryParse(Console.ReadLine(), out int newYear);
                        Console.Write("New Department Id: ");
                        int.TryParse(Console.ReadLine(), out int newDepId);
                        await _service.UpdateAsync(new GroupDto { Id = editId, Name = newName, Year = newYear, DepartmentId = newDepId });
                        Console.WriteLine("Updated.");
                        break;
                    case "4":
                        Console.Write("Group Id to delete: ");
                        int.TryParse(Console.ReadLine(), out int delId);
                        await _service.DeleteAsync(delId);
                        Console.WriteLine("Deleted.");
                        break;
                    case "5":
                        return;
                }
            }
        }
    }
}