using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurvManager.Models;

namespace SurvManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ManagerContext _context;

        public ProjectsController(ManagerContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Project> GetAllProjects()
        {
            return _context.Projects.ToList();
        }
    }
}
