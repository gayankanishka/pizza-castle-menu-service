using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemsByTypeId;

public record GetMenuItemsByTypeIdQuery(Guid TypeId) : IRequest<IEnumerable<MenuItemDto>>;