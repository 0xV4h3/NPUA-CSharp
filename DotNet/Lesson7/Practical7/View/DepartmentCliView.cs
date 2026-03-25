using Practical7.Services;
using Practical7.DTOs;
using System;
using System.Threading.Tasks;

namespace Practical7.Views
{
    public class DepartmentCliView
    {
        private readonly IDepartmentService _service;

        public DepartmentCliView(IDepartmentService service) => _service = service;

        public async Task RunAsync()
        {
            while (true)
            {
                Console.WriteLine("\n1. List Departments\n2. Add Dept\n3. Edit Dept\n4. Del Dept\n5. Exit");
                Console.Write("Select> ");
                var ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        foreach (var d in await _service.GetAllAsync())
                            Console.WriteLine($"{d.Id}: {d.Name}");
                        break;
                    case "2":
                        Console.Write("Dept name: ");
                        var name = Console.ReadLine();
                        await _service.CreateAsync(new DepartmentDto { Name = name });
                        Console.WriteLine("Added.");
                        break;
                    case "3":
                        Console.Write("Id: "); int id; int.TryParse(Console.ReadLine(), out id);
                        Console.Write("New name: "); var n = Console.ReadLine();
                        await _service.UpdateAsync(new DepartmentDto { Id = id, Name = n });
                        Console.WriteLine("Updated.");
                        break;
                    case "4":
                        Console.Write("Id: "); int did; int.TryParse(Console.ReadLine(), out did);
                        await _service.DeleteAsync(did); Console.WriteLine("Deleted."); break;
                    case "5": return;
                }
            }
        }
    }
}