using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Asp_Document_Reader.Server.Data;

public class AppDbContext : IdentityDbContext
{


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

  
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{

    //    modelBuilder.Entity<MenuItem>().HasNoKey();
    
    //}


    public DbSet<MenuItem> MenuItems { get; set; }


}
