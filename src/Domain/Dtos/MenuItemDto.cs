using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Domain.Dtos;

public class MenuItemDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public MenuCategoryDto MenuCategory { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public string ImageThumbnailUrl { get; set; }
    public string Ingrediants { get; set; }
}