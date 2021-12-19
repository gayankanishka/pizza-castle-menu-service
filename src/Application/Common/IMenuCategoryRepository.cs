using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.Common;

public interface IMenuCategoryRepository
{
    IQueryable<MenuCategory> GetAll();
    Task<MenuCategory> AddAsync(MenuCategory menuCategory, CancellationToken cancellationToken);
}