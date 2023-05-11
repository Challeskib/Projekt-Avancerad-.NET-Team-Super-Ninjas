using AutoMapper;
using Projekt___Avancerad_.NET_Team_Super_Ninjas.DTOs;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Services
{
    public class EmployeeRepository : IRepository<Employee>, IEmployee
    {
        private DataContext _context;
        private readonly IMapper _mapper;
        public EmployeeRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        async Task<IEnumerable<Employee>> IRepository<Employee>.GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
        }

        public async Task<Employee> Create(Employee obj)
        {
            var addedEmployee = await _context.Employees.AddAsync(obj);
            await _context.SaveChangesAsync();
            return addedEmployee.Entity;
        }

        public async Task<Employee> Delete(int id)
        {
            var empToDelete = await GetById(id);

            if (empToDelete != null)
            {
                _context.Employees.Remove(empToDelete);
                await _context.SaveChangesAsync();
                return empToDelete;
            }
            return null;
        }

        public async Task<Employee> Update(Employee obj)
        {
            var empToUpdate = await GetById(obj.EmployeeId);

            if (empToUpdate != null)
            {
                empToUpdate.Name = obj.Name;
                empToUpdate.Email = obj.Email;
                await _context.SaveChangesAsync();
                return empToUpdate;
            }
            return null;
        }

        public async Task<EmployeeDto> GetEmployeeWithReports(int id)
        {
            var emp = await _context.Employees
                .Include(e => e.TimeReports)
                .Where(e => e.EmployeeId == id)
                .Select(employee => _mapper.Map<EmployeeDto>(employee))
                .FirstOrDefaultAsync();
            return emp;
            
        }

        public Task<Employee> GetEmployeeWorkTime(int id, DateOnly startDate, DateOnly endDate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeProjectDto>> GetEmployeesInProject(int id)
        {
            var employeesInProject = _context.Employees
                .Join(_context.EmployeeProjects,
                e => e.EmployeeId,
                ep => ep.EmployeeId,
                (e, ep) => new JoinedEmpProj
                {
                    EmployeeId = e.EmployeeId,
                    Name = e.Name,
                    ProjectId = ep.ProjectId,
                    ProjectName = ep.Project.Name
                })
                .Where(p => p.ProjectId == id)
                .Select(employee => _mapper.Map<EmployeeProjectDto>(employee));
            // Check if list is empty
            if (employeesInProject.FirstOrDefault() == null)
            {
                return null;
            }

            return employeesInProject;
        }
    }
}
