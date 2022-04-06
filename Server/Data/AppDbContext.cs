
using Microsoft.EntityFrameworkCore;

namespace Asp_Document_Reader.Server.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<MenuItem> MenuItems { get; set; }





    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(
    //        @"Data Source=138.97.105.135;Initial Catalog=asplan;User ID=asplan2;Password=setasp@3305;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true");
    //}

}
