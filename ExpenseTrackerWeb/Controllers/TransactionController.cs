using ExpenseTrackerWeb.Data;
using ExpenseTrackerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ExpenseTrackerWeb.Controllers
{
    public class TransactionController : Controller
    {
        private readonly AppDbContext _dbContext;

        public TransactionController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var _lst = _dbContext.Transactions.Include(i => i.Category).ToList();

            return View(_lst);
        }
    }
}
