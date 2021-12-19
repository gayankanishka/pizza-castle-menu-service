using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuCategories.Commands.AddMenuCategory;

public record AddMenuCategoryCommand(AddMenuCategoryDto AddMenuCategoryDto) : IRequest<MenuCategoryDto>;