using Microsoft.EntityFrameworkCore;

namespace Asp_Document_Reader.Server.Data;

public class AppDbContext : DbContext
{


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<MenuItem>();
    
    }


    public DbSet<MenuItem> MenuItems { get; set; }


}
