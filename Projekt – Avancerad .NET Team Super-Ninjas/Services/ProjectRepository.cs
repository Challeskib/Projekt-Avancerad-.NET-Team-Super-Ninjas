namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Services
{

    public class ProjectRepository : IRepository<Project>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ProjectRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        async Task<IEnumerable<Project>> IRepository<Project>.GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetById(int id)
        {
            return await _context.Projects.FirstOrDefaultAsync(p => p.ProjectId == id);
        }

        public async Task<Project> Create(Project obj)
        {
            var addedProject = await _context.Projects.AddAsync(obj);
            await _context.SaveChangesAsync();
            return addedProject.Entity;
        }

        public async Task<Project> Delete(int id)
        {
            var projectToDelete = await GetById(id);

            if (projectToDelete != null)
            {
                _context.Projects.Remove(projectToDelete);
                await _context.SaveChangesAsync();
                return projectToDelete;
            }
            return null;
        }

        public async Task<Project> Update(Project obj)
        {
            var projectToUpdate = await GetById(obj.ProjectId);



            if (projectToUpdate != null)
            {
                projectToUpdate.Name = obj.Name;
                projectToUpdate.Description = obj.Description;
                await _context.SaveChangesAsync();
                return projectToUpdate;
            }
            return null;
        }
    }
}
