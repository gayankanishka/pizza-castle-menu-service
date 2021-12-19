using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItemTypes.Queries.GetMenuItemTypes;

public record GetMenuItemTypesQuery() : IRequest<IEnumerable<MenuItemTypeDto>>;