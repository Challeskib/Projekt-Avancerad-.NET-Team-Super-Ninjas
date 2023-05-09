using Microsoft.Identity.Client;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Services
{
    public class TimeReportRepository : IRepository<TimeReport>
    {
        private DataContext _context;
        public TimeReportRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<TimeReport> Create(TimeReport obj)
        {
            if (obj != null)
            {
                _context.TimeReports.Add(obj);
                await _context.SaveChangesAsync();
                return obj;
            } 
            else
            {
                return null;
            }
        }

        public async Task<TimeReport> Delete(int id)
        {
            TimeReport trToDelete = await GetById(id);
            if (trToDelete != null)
            {
                _context.TimeReports.Remove(trToDelete);
                await _context.SaveChangesAsync();
                return trToDelete;
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<TimeReport>> GetAll()
        {
            return await _context.TimeReports.ToListAsync();
        }

        public async Task<TimeReport> GetById(int id)
        {
            return await _context.TimeReports.FirstOrDefaultAsync(tr => tr.Id == id);
        }

        public async Task<TimeReport> Update(TimeReport obj)
        {
            TimeReport trToUpdate = await GetById(obj.Id);
            if (trToUpdate != null)
            {
                trToUpdate.Start = obj.Start;
                trToUpdate.End = obj.End;
                trToUpdate.EmployeeId = obj.EmployeeId;
                trToUpdate.WorkHours = obj.End.Subtract(obj.Start);
                await _context.SaveChangesAsync();
                return trToUpdate;
            }
            else
            {
                return null;
            }
        }
    }
}
