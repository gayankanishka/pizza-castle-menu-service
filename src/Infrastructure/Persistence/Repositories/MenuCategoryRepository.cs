using Microsoft.EntityFrameworkCore;
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

    public async Task<MenuCategory?> GetMenuCategoryAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _context.MenuCategories
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<MenuCategory> AddAsync(MenuCategory menuCategory, CancellationToken cancellationToken)
    {
        await _context.MenuCategories.AddAsync(menuCategory, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return menuCategory;
    }
}