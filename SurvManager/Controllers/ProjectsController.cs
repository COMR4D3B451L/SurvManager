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
        public ActionResult<IEnumerable<Project>> GetAllProjects()
        {
            var projects = _context.Projects.ToList();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProject(Guid id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        [HttpPost]
        public async Task<ActionResult<Project>> PostProject(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                "GetProject",
                new { id = project.Id },
                project);
        }
    }
}
