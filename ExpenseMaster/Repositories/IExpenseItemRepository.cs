using ExpenseMaster.Models;
using SQLite;

namespace ExpenseMaster.Repositories
{
    public interface IExpenseItemRepository
    {
        Task<IEnumerable<Expense>> GetAll();
        //Task<T> GetByIdAsync(int id);
        Task AddAsync(Expense entity);
    }
}
