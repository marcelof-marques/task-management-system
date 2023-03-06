using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystemAPI.Models
{
    public class Project
    {
        [Key]
        public long ID { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public ICollection<User> Users { get; set; } = null!;

        public ICollection<Task> Tasks { get; set; } = null!;
    }
}
