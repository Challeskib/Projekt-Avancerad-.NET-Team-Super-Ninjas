using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Projekt___Avancerad_.NET_Team_Super_Ninjas.Services;
using TimeReportModels;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeReportController : ControllerBase
    {
        private readonly IRepository<TimeReport> _trRepo;
        public TimeReportController(IRepository<TimeReport> trRepo)
        {
            _trRepo = trRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTimeReports()
        {
            try
            {
                return Ok(await _trRepo.GetAll());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Unable to retrieve data, internal server error.");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTimeReportById(int id)
        {
            try
            {
                var timeReport = await _trRepo.GetById(id);
                if (timeReport == null)
                {
                    return NotFound();
                }
                return Ok(timeReport);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Unable to retrieve data, internal server error.");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTimeReport(TimeReport timeReport)
        {
            if (timeReport != null)
            {
                _trRepo.Update(timeReport);
                return Ok(timeReport);
            }
            return NotFound($"Time report with Id {timeReport.Id} not found.");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteTimeReport(int id)
        {
            try
            {

                if (await _trRepo?.Delete(id) != null)
                {
                    return Ok();
                }
                else
                {
                    return NotFound($"Time report with Id {id} not found.");
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Unable to complete request, internal server error.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateTimeReport(int empId, DateTime start, DateTime end)
        {
            try
            {
                var trToCreate = new TimeReport(start, end) { EmployeeId = empId };
                return Ok(await _trRepo.Create(trToCreate));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Unable to complete request, internal server error.");
            }
        }
    }
}
