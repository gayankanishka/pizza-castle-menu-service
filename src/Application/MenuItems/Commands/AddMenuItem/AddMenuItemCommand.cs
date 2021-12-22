using System.Runtime.Serialization;
using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Commands.AddMenuItem;

[DataContract]
public class AddMenuItemCommand : IRequest<MenuItemDto>
{
    [DataMember]
    public string Name { get; private set; }
    [DataMember]
    public string Description { get; private set; }
    [DataMember]
    public double Price { get; private set; }
    [DataMember]
    public string ImageUrl { get; private set; }
    [DataMember] 
    public string ImageThumbnailUrl { get; set; }
    [DataMember]
    public string Ingredients { get; private set; }
    [IgnoreDataMember]
    public Guid MenuCategoryId { get; set; }

    public AddMenuItemCommand(string name, string description, double price, string imageUrl, string imageThumbnailUrl,
        string ingredients)
    {
        Name = name;
        Description = description;
        Price = price;
        ImageUrl = imageUrl;
        ImageThumbnailUrl = imageUrl;
        Ingredients = ingredients;
    }
}