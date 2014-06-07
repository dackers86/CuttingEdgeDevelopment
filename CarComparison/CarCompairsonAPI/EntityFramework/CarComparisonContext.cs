using CarCompairsonAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
public class CarComparisonContext : DbContext
{
    public CarComparisonContext()
        : base("CarComparison")
    {
        this.Configuration.ProxyCreationEnabled = false;
    }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Model> Models { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}