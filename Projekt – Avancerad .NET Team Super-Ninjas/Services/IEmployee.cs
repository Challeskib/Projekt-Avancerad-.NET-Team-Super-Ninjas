using TimeReportModels.DTOs;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Services
{
    public interface IEmployee
    {
        public Task<EmployeeDto> GetEmployeeWithReports(int id);
        public Task<Employee> GetEmployeeWorkTime(int id, DateOnly startDate, DateOnly endDate);
    }
}
