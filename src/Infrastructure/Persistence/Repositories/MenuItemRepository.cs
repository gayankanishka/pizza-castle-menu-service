using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Infrastructure.Persistence.Repositories;

public class MenuItemRepository : IMenuItemRepository
{
    private readonly ApplicationDbContext _context;
    
    public MenuItemRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IQueryable<MenuItem> GetAll()
    {
        return _context.MenuItems;
    }

    public async Task<MenuItem?> GetMenuItemAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _context.MenuItems
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public IQueryable<MenuItem> GetMenuItemsByCategoryId(Guid categoryId)
    {
        return _context.MenuItems
            .Where(x => x.MenuCategory.Id == categoryId);
    }

    public async Task<MenuItem> AddAsync(MenuItem menuItem, CancellationToken cancellationToken)
    {
        await _context.MenuItems.AddAsync(menuItem, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return menuItem;
    }
}