using Microsoft.AspNetCore.Identity;
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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //Cria os perfis de usuário (User e Admin)

        //builder.Entity<IdentityRole>().HasData(new IdentityRole
        //{
        //    Name = "User",
        //    NormalizedName = "USER",
        //    Id = Guid.NewGuid().ToString(),
        //    ConcurrencyStamp = Guid.NewGuid().ToString()
        //});


        //builder.Entity<IdentityRole>().HasData(new IdentityRole
        //{
        //    Name = "Admin",
        //    NormalizedName = "ADMIN",
        //    Id = Guid.NewGuid().ToString(),
        //    ConcurrencyStamp = Guid.NewGuid().ToString()
        //});
    }


}
