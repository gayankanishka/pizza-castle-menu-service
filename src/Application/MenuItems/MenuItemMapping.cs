using AutoMapper;
using PizzaCastle.MenuService.Domain.Dtos;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.MenuItems;

public class MenuItemMapping : Profile
{
    public MenuItemMapping()
    {
        CreateMap<MenuItem, MenuItemDto>();
    }
}