using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.Common;

public interface IMenuCategoryRepository
{
    IQueryable<MenuCategory> GetAll();
    Task<MenuCategory?> GetMenuCategoryAsync(Guid id, CancellationToken cancellationToken);
    Task<MenuCategory> AddAsync(MenuCategory menuCategory, CancellationToken cancellationToken);
}