using AutoMapper;
using PizzaCastle.MenuService.Domain.Dtos;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.MenuItemTypes;

public class MenuItemTypeMapping : Profile
{
    public MenuItemTypeMapping()
    {
        CreateMap<MenuItemType, MenuItemTypeDto>();
    }
}