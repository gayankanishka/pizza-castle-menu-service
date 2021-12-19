using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Infrastructure.Persistence.Configuration;

public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>

{
    public void Configure(EntityTypeBuilder<MenuItem> builder)
    {
        builder.HasData(
            new MenuItem
            {
                Id = Guid.NewGuid(),
                Name = "Pizza Margherita",
                Description = "The classic pizza",
                Price = 1500,
                ImageUrl =
                    "https://static.toiimg.com/thumb/56868564.cms?imgsize=1948751&width=800&height=800",
                MenuCategoryId = Guid.Parse("6E319C7E-8E1B-41BC-8784-4BDB8608ACA2"),
                Ingrediants = "Tomato, cheese, olive oil"
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Hot and Spicy Chicken Pizza",
                Description = "The spicy pizza",
                Price = 1800,
                ImageUrl =
                    "https://img.buzzfeed.com/thumbnailer-prod-us-east-1/video-api/assets/216054.jpg",
                MenuCategoryId = Guid.Parse("6E319C7E-8E1B-41BC-8784-4BDB8608ACA2"),
                Ingrediants = "Chicken, cheese, olive oil"
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Tandoori chicken pizza",
                Description = "The spicy pizza",
                Price = 2300,
                ImageUrl =
                    "https://i2.wp.com/www.pepperdelight.com/wp-content/uploads/2016/06/pepper-delight-tandoori-chicken-pizza-3.jpg?resize=3728%2C3696",
                MenuCategoryId = Guid.Parse("6E319C7E-8E1B-41BC-8784-4BDB8608ACA2"),
                Ingrediants = "Tandoori chicken, cheese, olive oil"
            });
    }
}