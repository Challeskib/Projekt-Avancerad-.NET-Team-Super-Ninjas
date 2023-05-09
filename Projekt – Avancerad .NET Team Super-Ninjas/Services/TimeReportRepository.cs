namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Services
{
    public class TimeReportRepository : IRepository<TimeReport>
    {
        public Task<TimeReport> Create(TimeReport obj)
        {
            throw new NotImplementedException();
        }

        public Task<TimeReport> Delete(int id)
        {
            throw new NotImplementedException();
        }


        public Task<TimeReport> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TimeReport> Update(TimeReport obj)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TimeReport>> IRepository<TimeReport>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
