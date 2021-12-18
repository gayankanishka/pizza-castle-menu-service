using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetAllMenuItems;

public record GetAllMenuItemsQuery() : IRequest<IEnumerable<MenuItemDto>>;