using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

namespace PaymentAPI.Data
{
    public class PaymentServiceContext : DbContext
    {
        public PaymentServiceContext(DbContextOptions<PaymentServiceContext> options)
            : base(options)
        {
        }
        public DbSet<Payment> Payment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Payment>().HasQueryFilter(f => !f.IsDeleted);
        }
    }
}
