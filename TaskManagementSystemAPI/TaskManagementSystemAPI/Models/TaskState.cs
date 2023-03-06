namespace TaskManagementSystemAPI.Models
{
    public class TaskState
    {
        public long ID { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }
    }
}
