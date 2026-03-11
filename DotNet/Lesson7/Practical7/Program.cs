using Practical7.Data;
using Practical7.Models;

namespace Practical7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var seed = SeedData.GetSeed();

            Console.WriteLine("Departments:");
            foreach (var dept in seed.Departments)
            {
                Console.WriteLine($"Id: {dept.Id}, Name: {dept.Name}");
            }

            Console.WriteLine("\nGroups:");
            foreach (var group in seed.Groups)
            {
                Console.WriteLine($"Id: {group.Id}, Name: {group.Name}, Year: {group.Year}, DeptId: {group.DepartmentId}");
            }

            Console.WriteLine("\nUser Profiles:");
            foreach (var profile in seed.UserProfiles)
            {
                Console.WriteLine($"Id: {profile.Id}, Name: {profile.FirstName} {profile.LastName}, Role: {profile.Role}, Email: {profile.Email}, Active: {profile.IsActive}");
            }

            Console.WriteLine("\nUser Group Memberships:");
            foreach (var mem in seed.UserGroupMemberships)
            {
                Console.WriteLine($"Id: {mem.Id}, UserId: {mem.UserProfileId}, GroupId: {mem.GroupId}, Primary: {mem.IsPrimary}, From: {mem.FromDate:yyyy-MM-dd}");
            }
        }
    }
}