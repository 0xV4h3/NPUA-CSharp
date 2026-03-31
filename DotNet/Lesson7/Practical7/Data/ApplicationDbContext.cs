using Microsoft.EntityFrameworkCore;
using Practical7.Models;

namespace Practical7.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserGroupMembership> UserGroupMemberships { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}