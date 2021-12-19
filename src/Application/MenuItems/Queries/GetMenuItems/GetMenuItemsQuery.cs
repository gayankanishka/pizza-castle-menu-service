using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItems;

public record GetMenuItemsQuery() : IRequest<IEnumerable<MenuItemDto>>;