using Microsoft.EntityFrameworkCore;
using TaskManagementSystemAPI.Models;

namespace TaskManagementSystemAPI.Data
{
    public class TaskManagamentSystemDBContext : DbContext
    {
        public DbSet<Project> Projects { get; set;} = null!;
        public DbSet<User> Users { get; set;} = null!;
        public DbSet<Role> Roles { get; set;} = null!;
        public DbSet<Models.Task> Tasks { get; set; } = null!;
        public DbSet<TaskState> TaskStates { get; set; } = null!;
        public DbSet<TaskType> TaskTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MARCELO;Initial Catalog=TaskManagementSystemDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
