using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Domain.Entities;
using PizzaCastle.MenuService.Infrastructure.Persistence.Configuration;

namespace PizzaCastle.MenuService.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MenuCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new MenuItemConfiguration());
    }

    public DbSet<MenuItem> MenuItems { get; set; } = default!;
    public DbSet<MenuCategory> MenuCategories { get; set; } = default!;

}