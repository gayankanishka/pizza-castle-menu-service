using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Infrastructure.Persistence.Configuration;

public class MenuCategoryConfiguration : IEntityTypeConfiguration<MenuCategory>
{
    public void Configure(EntityTypeBuilder<MenuCategory> builder)
    {
        builder.HasData(
            new MenuCategory
            {
                Id = Guid.Parse("6E319C7E-8E1B-41BC-8784-4BDB8608ACA2"),
                Name = "Meat",
            },
            new MenuCategory
            {
                Id = Guid.Parse("F3213095-31CD-4647-8FD5-C04A18A2484B"),
                Name = "Vegetarian",
            },
            new MenuCategory
            {
                Id = Guid.Parse("FD7D057F-C0B7-404C-ABAF-1555E474C2D5"),
                Name = "Grill"
            },
            new MenuCategory
            {
                Id = Guid.Parse("3457A568-216D-41C1-A586-36483280A3DA"),
                Name = "Spicy"
            });
    }
}