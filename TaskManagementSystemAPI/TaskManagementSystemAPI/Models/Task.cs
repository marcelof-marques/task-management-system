namespace TaskManagementSystemAPI.Models
{
    /// <summary>
    /// Tarefas
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Identificador da Tarefa
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Nome da Tarefa
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Descrição da Tarefa
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Identificador do Tipo de Tarefa
        /// </summary>
        public long TypeID { get; set; }

        /// <summary>
        /// Identificador do Estado da Tarefa
        /// </summary>
        public long StateID { get; set; }

        /// <summary>
        /// Identificador do Utilizador ao qual esta Tarefa está associada
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// Tipo da Tarefa
        /// </summary>
        public TaskType Type { get; set; } = null!;

        /// <summary>
        /// Utilizador ao qual esta Tarefa está associada
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Estado da Tarefa
        /// </summary>
        public TaskState State { get; set; } = null!;
    }
}
