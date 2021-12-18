namespace PizzaCastle.MenuService.Domain.Dtos;

public class PizzaDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public string Ingrediants { get; set; }
}