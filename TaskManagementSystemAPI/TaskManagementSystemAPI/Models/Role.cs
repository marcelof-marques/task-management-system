namespace TaskManagementSystemAPI.Models
{
    /// <summary>
    /// Cargos de Utilizadores
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Identificador do Cargo
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Nome do Cargo
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Descrição do Cargo
        /// </summary>
        public string? Description { get; set; }
    }
}