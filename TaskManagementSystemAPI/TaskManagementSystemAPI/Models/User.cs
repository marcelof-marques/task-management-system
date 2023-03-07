using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystemAPI.Models
{
    /// <summary>
    /// Utilizador 
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identificador do Utilizador
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Nome do Utlizador
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Email do Utilizador
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Identificador da Cargo do Utilizador
        /// </summary>
        public long RoleID { get; set; }

        /// <summary>
        /// Cardo do Utilizador
        /// </summary>
        public Role Role { get; set; } = null!;

        /// <summary>
        /// Tarefas que estão associadas ao Utilizador
        /// </summary>
        public ICollection<Task>? Tasks { get; set; }

        /// <summary>
        /// Projetos ao qual o Utilizador pertence
        /// </summary>
        public ICollection<Project>? Projects { get; set; }
    }
}
