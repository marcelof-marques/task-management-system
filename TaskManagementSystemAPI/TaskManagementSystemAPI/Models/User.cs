using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystemAPI.Models
{
    public class User
    {
        [Key]
        public long ID { get; set; }

        public string Name { get; set; } = null!;

        public string? Email { get; set; }

        public long RoleID { get; set; }

        public Role Role { get; set; } = null!;

        public ICollection<Project> Projects { get; set; } = null!;
    }
}
