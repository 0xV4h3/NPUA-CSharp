using Practical7.Services;
using Practical7.DTOs;
using System;
using System.Threading.Tasks;

namespace Practical7.Views
{
    public class UserGroupMembershipCliView
    {
        private readonly IUserGroupMembershipService _service;

        public UserGroupMembershipCliView(IUserGroupMembershipService service)
        {
            _service = service;
        }

        public async Task RunAsync()
        {
            while (true)
            {
                Console.WriteLine("\n1. List Memberships\n2. Add Membership\n3. Edit Membership\n4. Delete Membership\n5. Exit");
                Console.Write("Select> ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var memberships = await _service.GetAllAsync();
                        foreach (var m in memberships)
                        {
                            string toDateStr = m.ToDate.HasValue ? m.ToDate.Value.ToString("yyyy-MM-dd") : "null";
                            Console.WriteLine($"{m.Id}: UserProfileId={m.UserProfileId}, GroupId={m.GroupId}, Primary={m.IsPrimary}, From={m.FromDate:yyyy-MM-dd}, To={toDateStr}");
                        }
                        break;
                    case "2":
                        Console.Write("UserProfileId: ");
                        int.TryParse(Console.ReadLine(), out int userId);
                        Console.Write("GroupId: ");
                        int.TryParse(Console.ReadLine(), out int groupId);
                        Console.Write("Primary (y/n): ");
                        var isPrimary = Console.ReadLine()?.Trim().ToLower() == "y";
                        Console.Write("From (yyyy-MM-dd): ");
                        DateTime.TryParse(Console.ReadLine(), out DateTime fromDate);
                        Console.Write("To (yyyy-MM-dd) [Leave empty for null]: ");
                        var toDateStr2 = Console.ReadLine();
                        DateTime? toDate = string.IsNullOrWhiteSpace(toDateStr2) ? (DateTime?)null : DateTime.Parse(toDateStr2);

                        await _service.CreateAsync(new UserGroupMembershipDto
                        {
                            UserProfileId = userId,
                            GroupId = groupId,
                            IsPrimary = isPrimary,
                            FromDate = fromDate,
                            ToDate = toDate
                        });
                        Console.WriteLine("Membership added.");
                        break;
                    case "3":
                        Console.Write("Membership Id to edit: ");
                        int.TryParse(Console.ReadLine(), out int editId);
                        Console.Write("UserProfileId: ");
                        int.TryParse(Console.ReadLine(), out int editUserId);
                        Console.Write("GroupId: ");
                        int.TryParse(Console.ReadLine(), out int editGroupId);
                        Console.Write("Primary (y/n): ");
                        var editIsPrimary = Console.ReadLine()?.Trim().ToLower() == "y";
                        Console.Write("From (yyyy-MM-dd): ");
                        DateTime.TryParse(Console.ReadLine(), out DateTime editFromDate);
                        Console.Write("To (yyyy-MM-dd) [Leave empty for null]: ");
                        var editToDateStr = Console.ReadLine();
                        DateTime? editToDate = string.IsNullOrWhiteSpace(editToDateStr) ? (DateTime?)null : DateTime.Parse(editToDateStr);

                        await _service.UpdateAsync(new UserGroupMembershipDto
                        {
                            Id = editId,
                            UserProfileId = editUserId,
                            GroupId = editGroupId,
                            IsPrimary = editIsPrimary,
                            FromDate = editFromDate,
                            ToDate = editToDate
                        });
                        Console.WriteLine("Membership updated.");
                        break;
                    case "4":
                        Console.Write("Membership Id to delete: ");
                        int.TryParse(Console.ReadLine(), out int delId);
                        await _service.DeleteAsync(delId);
                        Console.WriteLine("Membership deleted.");
                        break;
                    case "5":
                        return;
                }
            }
        }
    }
}