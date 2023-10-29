using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class ModelDB : DbContext
    {
        public ModelDB(DbContextOptions options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Sell> SellOrders { get; set; }
    }
}
