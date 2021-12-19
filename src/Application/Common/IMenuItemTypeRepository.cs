using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.Common;

public interface IMenuItemTypeRepository
{
    IQueryable<MenuItemType> GetAll();
}