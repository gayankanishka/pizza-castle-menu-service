using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuCategories.Queries.GetMenuCategories;

public record GetMenuCategoriesQuery() : IRequest<IEnumerable<MenuCategoryDto>>;