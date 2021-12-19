using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Commands.AddMenuItem;

public record AddMenuItemCommand(Guid CategoryId, AddMenuItemDto AddMenuItemDto) : IRequest<MenuItemDto>;