using ExpenseMaster.Models;
using SQLite;

namespace ExpenseMaster.Repositories
{
    public class ExpensesItemRepository : IExpenseItemRepository
    {
        private readonly IRepository<Expense> _repository;

        public ExpensesItemRepository()
        {
            _repository = DependencyService.Get<IRepository<Expense>>();
        }

        public async Task AddAsync(Expense entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            return await _repository.GetAll();
        }
    }
}
