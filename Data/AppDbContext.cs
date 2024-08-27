using ConfApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Calibration> Calibrations { get; set; }
    public DbSet<Weight> Weights { get; set; }
    public DbSet<Customer> Customers {  get; set; }
    public DbSet<Scale> Scales { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Calibration>().HasMany(_ => _.Weights);
    }
}
