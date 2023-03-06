namespace TaskManagementSystemAPI.Models
{
    public class Role
    {
        public long ID { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}