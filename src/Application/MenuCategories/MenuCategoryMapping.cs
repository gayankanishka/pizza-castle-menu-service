using AutoMapper;
using PizzaCastle.MenuService.Application.MenuCategories.Commands.AddMenuCategory;
using PizzaCastle.MenuService.Domain.Dtos;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.MenuCategories;

public class MenuCategoryMapping : Profile
{
    public MenuCategoryMapping()
    {
        CreateMap<MenuCategory, MenuCategoryDto>();
        CreateMap<AddMenuCategoryCommand, MenuCategory>();
    }
}