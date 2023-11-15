using SQLite;

namespace ExpenseMaster.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        //Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        //Task UpdateAsync(T entity);
        //Task DeleteAsync(int id);
    }
}
