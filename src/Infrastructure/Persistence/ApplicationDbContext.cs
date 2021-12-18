using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public DbSet<MenuItem> MenuItems { get; set; } = default!;
    public DbSet<MenuItemType> MenuItemTypes { get; set; } = default!;

}