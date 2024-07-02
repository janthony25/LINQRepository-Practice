using LINQRepository_Practice.Models;
using Microsoft.EntityFrameworkCore;

namespace LINQRepository_Practice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblCustomer> tblCustomer { get; set; }
    }
}
