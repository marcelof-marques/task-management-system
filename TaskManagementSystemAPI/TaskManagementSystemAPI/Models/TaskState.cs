namespace TaskManagementSystemAPI.Models
{
    /// <summary>
    /// Estados das Tarefas
    /// </summary>
    public class TaskState
    {
        /// <summary>
        /// Ientificador do Estado da Tarefa
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Nome do Estado da Tarefa
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Descrição do Estado da Tarefa
        /// </summary>
        public string? Description { get; set; }
    }
}
