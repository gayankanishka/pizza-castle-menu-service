using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.Common;

public interface IMenuItemRepository
{
    IQueryable<MenuItem> GetAll();
    Task<MenuItem?> GetMenuItemAsync(Guid id, CancellationToken cancellationToken);
    IQueryable<MenuItem> GetMenuItemsByCategoryId(Guid categoryId);
    Task<MenuItem> AddAsync(MenuItem menuItem, CancellationToken cancellationToken);
}