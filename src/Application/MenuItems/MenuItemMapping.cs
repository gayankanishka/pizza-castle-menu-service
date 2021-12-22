using AutoMapper;
using PizzaCastle.MenuService.Application.MenuItems.Commands.AddMenuItem;
using PizzaCastle.MenuService.Domain.Dtos;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.MenuItems;

public class MenuItemMapping : Profile
{
    public MenuItemMapping()
    {
        CreateMap<MenuItem, MenuItemDto>();
        CreateMap<AddMenuItemCommand, MenuItem>();
    }
}