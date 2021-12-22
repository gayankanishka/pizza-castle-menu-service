using System.ComponentModel.DataAnnotations;
using PizzaCastle.MenuService.Domain.Common;

namespace PizzaCastle.MenuService.Domain.Entities;

public class MenuItem : AuditableEntity
{
    public Guid Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public string Description { get; set; }
    public Guid MenuCategoryId { get; set; }
    public MenuCategory MenuCategory { get; set; }
    [Required]
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public string ImageThumbnailUrl { get; set; }
    public string Ingrediants { get; set; }
}