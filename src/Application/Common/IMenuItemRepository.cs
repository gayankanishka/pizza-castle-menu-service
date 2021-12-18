using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.Common;

public interface IMenuItemRepository
{
    IQueryable<MenuItem> GetMenuItems();
    Task<MenuItem?> GetMenuItemAsync(Guid id, CancellationToken cancellationToken);
}