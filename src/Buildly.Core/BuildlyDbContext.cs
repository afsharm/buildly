using Microsoft.EntityFrameworkCore;

public class BuildlyDbContext : DbContext
{
    public BuildlyDbContext(DbContextOptions<BuildlyDbContext> options) : base(options) { }
    public DbSet<Building> Buildings { get; set; }

}