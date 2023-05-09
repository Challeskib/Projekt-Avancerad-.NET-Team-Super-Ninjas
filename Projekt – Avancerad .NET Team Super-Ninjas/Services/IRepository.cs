namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Services
{
    public interface IRepository<T>
    {

        public Task<T> GetAll();
        public Task<T> GetById(int id);
        public Task<T> Create(T obj);
        public Task<T> Update(T obj);  
        public Task<T> Delete(int id);

    }
}
