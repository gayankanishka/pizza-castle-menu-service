using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemsByCategoryId;

public record GetMenuItemsByCategoryIdQuery(Guid CategoryId) : IRequest<IEnumerable<MenuItemDto>>;