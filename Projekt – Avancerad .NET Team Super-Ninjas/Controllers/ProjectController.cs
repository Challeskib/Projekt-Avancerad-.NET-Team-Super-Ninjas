using Microsoft.AspNetCore.Mvc;
using Projekt___Avancerad_.NET_Team_Super_Ninjas.Services;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly IRepository<Project> _projectRepo;
        public ProjectController(IRepository<Project> projectRepo)
        {
            _projectRepo = projectRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _projectRepo.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProjectById(int id)
        {
            try
            {
                var emp = await _projectRepo.GetById(id);
                if (emp == null)
                {
                    return NotFound();
                }
                return Ok(emp);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
               
        
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Project newProject)
        {
            try
            {
                if (newProject == null)
                {
                    return BadRequest();
                }
                var createdProject = await _projectRepo.Create(newProject);
                return CreatedAtAction(nameof(GetProjectById), new { id = createdProject.ProjectId }, createdProject);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Project>> DeleteEmployee(int id)
        {
            try
            {
                var deletedProject = await _projectRepo.Delete(id);
                if (deletedProject == null)
                {
                    return NotFound($"Could not find Project with id: {id}");
                }
                return Ok(deletedProject);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public async Task<ActionResult<Project>> UpdateEmployee(Project obj)
        {
            try
            {
                if (obj == null)
                {
                    return BadRequest();
                }

                var updatedProject = await _projectRepo.Update(obj);

                return Ok(updatedProject);


            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
