using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystemAPI.Models
{
    /// <summary>
    /// Projetos
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Identificador do Projeto
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Nome do Projeto
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Descrição do Projeto
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Uilizadores ao qual teem acesso a este Projeto
        /// </summary>
        public ICollection<User> Users { get; set; } = null!;

        /// <summary>
        /// Tarefas criadas para este Projeto
        /// </summary>
        public ICollection<Task> Tasks { get; set; } = null!;
    }
}
