using SQLite;

namespace ExpenseMaster.Models
{
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string ExpensesName { get; set; }

        public string Currency { get; set; }

        public double ExpenseSum { get; set; }

        public DateTime ExpenseDay { get; set; }

        public string ExpenseCategory { get; set; }

        public string ExpenseNote { get; set; }

    }
}
