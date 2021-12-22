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
                Name = "Pilla Pizza",
                Description = "The classic pizza",
                Price = 1500,
                ImageUrl = "https://arthurs.lk/wp-content/uploads/2021/11/pilla-pizza-2.png",
                ImageThumbnailUrl = "https://arthurs.lk/wp-content/uploads/2021/11/pilla-pizza-2-300x300.png",
                MenuCategoryId = Guid.Parse("6E319C7E-8E1B-41BC-8784-4BDB8608ACA2"),
                Ingrediants = "Tomato, cheese, olive oil"
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Mas Kade Pizza",
                Description = "The spicy pizza",
                Price = 2600,
                ImageUrl = "https://arthurs.lk/wp-content/uploads/2019/12/AP_web_photos4.png",
                ImageThumbnailUrl = "https://arthurs.lk/wp-content/uploads/2019/12/AP_web_photos4-300x300.png",
                MenuCategoryId = Guid.Parse("6E319C7E-8E1B-41BC-8784-4BDB8608ACA2"),
                Ingrediants = "Chicken, ham, mutton, chicken sausage, Chicken Bacon, salami & mozzarella."
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Cheese Hatharak Pizza",
                Description = "The spicy pizza",
                Price = 2000,
                ImageUrl = "https://arthurs.lk/wp-content/uploads/2020/04/AP_web_photos31.png",
                ImageThumbnailUrl = "https://arthurs.lk/wp-content/uploads/2020/04/AP_web_photos31-300x300.png",
                MenuCategoryId = Guid.Parse("F3213095-31CD-4647-8FD5-C04A18A2484B"),
                Ingrediants = "Swiss, parmesan, paneer & mozzarella."
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Salami Pizza",
                Description = "The spicy pizza",
                Price = 1900,
                ImageUrl = "https://arthurs.lk/wp-content/uploads/2019/12/AP_web_photos2.png",
                ImageThumbnailUrl = "https://arthurs.lk/wp-content/uploads/2019/12/AP_web_photos2-300x300.png",
                MenuCategoryId = Guid.Parse("FD7D057F-C0B7-404C-ABAF-1555E474C2D5"),
                Ingrediants = "Salami & mozzarella."
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Meat Kawalam Pizza",
                Description = "The spicy pizza",
                Price = 2450,
                ImageUrl = "https://arthurs.lk/wp-content/uploads/2019/12/AP_web_photos3.png",
                ImageThumbnailUrl = "https://arthurs.lk/wp-content/uploads/2019/12/AP_web_photos3-300x300.png",
                MenuCategoryId = Guid.Parse("FD7D057F-C0B7-404C-ABAF-1555E474C2D5"),
                Ingrediants = "Mutton, bacon, chicken & mozzarella."
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Vegetable Nai Miris Pizza",
                Description = "The spicy pizza",
                Price = 1650,
                ImageUrl = "https://arthurs.lk/wp-content/uploads/2020/06/AP_web_photos33.png",
                ImageThumbnailUrl = "https://arthurs.lk/wp-content/uploads/2020/06/AP_web_photos33-300x300.png",
                MenuCategoryId = Guid.Parse("F3213095-31CD-4647-8FD5-C04A18A2484B"),
                Ingrediants = "Vegetables & mozzarella."
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Chicken Hellfire Pizza",
                Description = "The spicy pizza",
                Price = 2500,
                ImageUrl = "https://arthurs.lk/wp-content/uploads/2020/01/AP_web_photos32.png",
                ImageThumbnailUrl = "https://arthurs.lk/wp-content/uploads/2020/01/AP_web_photos32-300x300.png",
                MenuCategoryId = Guid.Parse("3457A568-216D-41C1-A586-36483280A3DA"),
                Ingrediants = "Chicken, nai miris, onions, curry leaves & mozzarella."
            },
            new MenuItem{
                Id = Guid.NewGuid(),
                Name = "Chicken Nai Miris Pizza",
                Description = "The spicy pizza",
                Price = 2000,
                ImageUrl = "https://arthurs.lk/wp-content/uploads/2020/04/AP_web_photos29-1.png",
                ImageThumbnailUrl = "https://arthurs.lk/wp-content/uploads/2020/04/AP_web_photos29-1-300x300.png",
                MenuCategoryId = Guid.Parse("3457A568-216D-41C1-A586-36483280A3DA"),
                Ingrediants = "Chicken, nai miris, onions, curry leaves & mozzarella."
            });
    }
}   