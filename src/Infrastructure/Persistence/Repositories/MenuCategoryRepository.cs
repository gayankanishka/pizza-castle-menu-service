using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Infrastructure.Persistence.Repositories;

public class MenuCategoryRepository : IMenuCategoryRepository
{
    private readonly ApplicationDbContext _context;

    public MenuCategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IQueryable<MenuCategory> GetAll()
    {
        return _context.MenuCategories;
    }

    public async Task<MenuCategory> AddAsync(MenuCategory menuCategory)
    {
        await _context.MenuCategories.AddAsync(menuCategory);
        await _context.SaveChangesAsync();

        return menuCategory;
    }
}