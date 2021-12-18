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
    
    public IQueryable<MenuItem> GetMenuItems()
    {
        return _context.MenuItems;
    }

    public async Task<MenuItem?> GetMenuItemAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _context.MenuItems
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync(cancellationToken);
    }
}