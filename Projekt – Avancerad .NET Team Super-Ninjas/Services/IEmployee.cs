using Projekt___Avancerad_.NET_Team_Super_Ninjas.DTOs;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Services
{
    public interface IEmployee
    {
        public Task<EmployeeDto> GetEmployeeWithReports(int id);
        public Task<Employee> GetEmployeeWorkTime(int id, DateOnly startDate, DateOnly endDate);
        public Task<IEnumerable<EmployeeProjectDto>> GetEmployeesInProject(int id);
    }
}
