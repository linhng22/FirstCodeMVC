using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using labW03.Models;

namespace labW03.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<Province> Province { get; set; } = default!;

public DbSet<City> City { get; set; } = default!;

protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<City>().Property(m => m.ProvinceCode).IsRequired();
        builder.Entity<Province>().ToTable("Province");
        builder.Entity<City>().ToTable("City");

        builder.Seed();
    }

    
}
