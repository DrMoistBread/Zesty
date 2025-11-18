using Domain.Common;
using Domain.Menus.ValueObjects;
using Domain.Models;

namespace Domain.Menus.Entities;

public class MenuItem : Entity<MenuItemId>
{
    public string Name  { get; set; }
    public string  Ingredients { get; set; }
    public Price Price { get; set; }
    public MenuItemType Type { get; set; }

    private MenuItem(MenuItemId id, string name, string ingredients, Price price, MenuItemType type) : base(id)
    {
        Name = name;
        Ingredients = ingredients;
        Price = price;
        Type = type;
    }

    
    public static MenuItem Create(string name, string ingredients, Price price, MenuItemType type)
    {
        return new MenuItem(MenuItemId.CreateUnique(), name, ingredients, price, type);
    }

   }