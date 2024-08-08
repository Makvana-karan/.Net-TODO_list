using Microsoft.EntityFrameworkCore;
using MyWeb;


namespace MyApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }
        public DbSet<Catagory> Catagories { get; set; }
    }
}
