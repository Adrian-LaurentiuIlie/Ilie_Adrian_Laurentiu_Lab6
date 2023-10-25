using Microsoft.EntityFrameworkCore;
namespace Ilie_Adrian_Laurentiu_Lab6.Models
{
    public class ExpenseContext :DbContext
    {
            public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
