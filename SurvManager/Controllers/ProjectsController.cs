using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SurvManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public void GetProjects()
        {

        }
    }
}
