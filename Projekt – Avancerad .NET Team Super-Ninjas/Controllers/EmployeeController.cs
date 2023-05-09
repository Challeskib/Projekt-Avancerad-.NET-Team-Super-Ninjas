using Microsoft.AspNetCore.Mvc;
using Projekt___Avancerad_.NET_Team_Super_Ninjas.Services;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository<Employee> _empRepo;
        public EmployeeController(IRepository<Employee> context)
        {
            _empRepo = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _empRepo.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            try
            {
                var emp = await _empRepo.GetById(id);
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
        public async Task<IActionResult> CreateEmployee(Employee newEmp)
        {
            try
            {
                if (newEmp == null)
                {
                    return BadRequest();
                }
                var createdEmp = await _empRepo.Create(newEmp);
                return CreatedAtAction(nameof(GetEmployeeById), new { id = createdEmp.EmployeeId }, createdEmp);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {
                var deletedEmp = await _empRepo.Delete(id);
                if (deletedEmp == null)
                {
                    return NotFound($"Could not find Employee with id: {id}");
                }
                return Ok(deletedEmp);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public async Task<ActionResult<Employee>> UpdateEmployee(Employee obj)
        {
            try
            {
                if(obj == null)
                {
                    return BadRequest();
                }

                var updatedEmp = await _empRepo.Update(obj);

                return Ok(updatedEmp);
                

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }



        }



    }
}
