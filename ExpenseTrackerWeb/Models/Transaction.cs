namespace ExpenseTrackerWeb.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount{ get; set; }
        public DateTime Date { get; set; }
        public DateTime EntryDate { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
