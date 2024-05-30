using Microsoft.EntityFrameworkCore;

namespace TaskManager.Api.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectAdmin> ProjectAdmins { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
            if (Users != null && Users.Any(u => u.Status == UserStatus.Admin) == false)
            {
                var admin = new User("nikolay", "pomogaev", "klagefurt@gmail.com", "qwerty123",UserStatus.Admin );
                Users.Add(admin);
                SaveChanges();
            }
        }
    }
}
