using ExpenseTrackerWeb.Data.Enum;

namespace ExpenseTrackerWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }

        public TransType TransType { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
