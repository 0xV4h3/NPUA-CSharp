using Newtonsoft.Json;
using Practical7.Models;

namespace Practical7.Data
{
    public class DbInitializer
    {
        public static async Task SeedAsync(ApplicationDbContext context, string seedFilePath)
        {
            if (context.Departments.Any())
                return;

            var json = await File.ReadAllTextAsync(seedFilePath);
            var seed = JsonConvert.DeserializeObject<SeedData>(json);

            context.Departments.AddRange(seed.Departments);
            context.Groups.AddRange(seed.Groups);
            context.UserProfiles.AddRange(seed.UserProfiles);
            context.UserGroupMemberships.AddRange(seed.UserGroupMemberships);

            await context.SaveChangesAsync();
        }
    }
}