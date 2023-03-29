using Microsoft.EntityFrameworkCore;
using PaginationDemo.Models;

namespace PaginationDemo.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
