using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemById;

public record GetMenuItemByIdQuery(Guid Id) : IRequest<MenuItemDto?>;