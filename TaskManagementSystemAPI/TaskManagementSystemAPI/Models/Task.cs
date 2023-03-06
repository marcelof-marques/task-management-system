namespace TaskManagementSystemAPI.Models
{
    public class Task
    {
        public long ID { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public long TypeID { get; set; }

        public long StateID { get; set; }

        public TaskType Type { get; set; } = null!;

        public TaskState State { get; set; } = null!;
    }
}
