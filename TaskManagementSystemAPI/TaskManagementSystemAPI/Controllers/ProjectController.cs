using TaskManagementSystemAPI.Data;
using TaskManagementSystemAPI.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProjectController : ControllerBase
    {
        readonly TaskManagamentSystemDBContext context = new();
        private readonly ILogger<ProjectController> _logger;

        public ProjectController(ILogger<ProjectController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Vai buscar todos os projetos incluindo as suas tarefas e utilizadores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Project> GetProjects()
        {
            return context.Projects
                .Include(p => p.Users)
                .Include(p => p.Tasks);
        }
    }
}
