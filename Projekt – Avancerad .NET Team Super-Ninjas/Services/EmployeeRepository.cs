namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Services
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public Task<Employee> Create(Employee obj)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Update(Employee obj)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Employee>> IRepository<Employee>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
