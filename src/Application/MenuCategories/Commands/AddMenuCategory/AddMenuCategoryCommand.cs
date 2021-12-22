using System.Runtime.Serialization;
using MediatR;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuCategories.Commands.AddMenuCategory;

[DataContract]
public class AddMenuCategoryCommand : IRequest<MenuCategoryDto>
{
    [DataMember]
    public string Name { get; private set; }

    public AddMenuCategoryCommand(string name)
    {
        Name = name;
    }
}