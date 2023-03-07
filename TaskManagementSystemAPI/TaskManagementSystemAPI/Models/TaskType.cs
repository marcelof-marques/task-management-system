namespace TaskManagementSystemAPI.Models
{
    /// <summary>
    /// Tipos de Tarefas
    /// </summary>
    public class TaskType
    {
        /// <summary>
        /// Identificador do Tipo de Tarefa
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Nome do Tipo de Tarefa
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Descrição do Tipo de Tarefa
        /// </summary>
        public string? Description { get; set; }
    }
}
