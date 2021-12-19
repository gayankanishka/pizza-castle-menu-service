using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Infrastructure.Persistence.Repositories;

public class MenuItemTypeRepository : IMenuItemTypeRepository
{
    private readonly ApplicationDbContext _context;

    public MenuItemTypeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IQueryable<MenuItemType> GetAll()
    {
        return _context.MenuItemTypes;
    }
}