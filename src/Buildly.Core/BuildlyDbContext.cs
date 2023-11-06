using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class BuildlyDbContext : IdentityDbContext
{
    public BuildlyDbContext(DbContextOptions<BuildlyDbContext> options) : base(options) { }
    public DbSet<Building> Buildings { get; set; }

}