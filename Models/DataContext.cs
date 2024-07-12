using Microsoft.EntityFrameworkCore;

namespace ApplicationsRiley.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Apps> apps { get; set; }
}