using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.Common;

public interface IMenuCategoryRepository
{
    IQueryable<MenuCategory> GetAll();
}