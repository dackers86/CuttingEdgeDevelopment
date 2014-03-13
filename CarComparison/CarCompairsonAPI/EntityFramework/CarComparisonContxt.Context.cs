
using CarCompairsonAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
public class CarComparisonContext : DbContext
{
    public CarComparisonContext() : base("CarComparisonEntities")
    {
    }
    public DbSet<Car> Cars { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasKey(p => p.Id);
        modelBuilder.Entity<Car>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        base.OnModelCreating(modelBuilder);
    }
}