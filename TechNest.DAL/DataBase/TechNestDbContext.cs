


namespace TechNest.DAL.DataBase
{
    public class TechNestDbContext : DbContext
    {
        public TechNestDbContext(DbContextOptions<TechNestDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        }
}
