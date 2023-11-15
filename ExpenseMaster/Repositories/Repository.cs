using SQLite;
using System.Linq;

namespace ExpenseMaster.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        readonly SQLiteAsyncConnection _database;

        public Repository()
        {
            //if (_database == null)
            //{
            //    return;
            //}

            _database = new SQLiteAsyncConnection(Constants.Constants.DBPath, Constants.Constants.Flags);
            _database.CreateTableAsync<T>().Wait(); 
        }

        public async Task AddAsync(T entity)
        {
            await _database.InsertAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _database.Table<T>().ToListAsync();
        }
    }
}
