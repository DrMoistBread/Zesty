using Domain.Common;
using Domain.MenuAggregate;
using Domain.Menus.Entities;
using Domain.Menus.ValueObjects;
using Xunit;

namespace Domain.Tests.MenusTests;

public class MenuItemTests
{
    [Fact]
    public void CreateItem_GivenCreateAMenuItem_ShouldCreateANewMenuItemWithFields()
    {
        var itemName = "Abobora Frita";
        var ingredients = "abobora, alho, farinha, ovo";
        var price = Price.Create(5.00f, "EUR");
        
        var menuItem = MenuItem.Create(itemName, ingredients, price, MenuItemType.Kitchen);
        
        Assert.Equal(itemName, menuItem.Name);
        Assert.Equal(ingredients,menuItem.Ingredients);
        Assert.Equal(price, menuItem.Price);
        Assert.Equal(MenuItemType.Kitchen, menuItem.Type);
    }
    
    [Fact]
    public void AddMenuItem_GivenANewMenu_ShouldAddMenuItemToMenu()
    {
        var itemName = "Abobora Frita";
        var ingredients = "abobora, alho, farinha, ovo";
        var price = Price.Create(5.00f, "EUR");
        
        var menuItem = MenuItem.Create(itemName, ingredients, price, MenuItemType.Kitchen);

        var menu = Menu.Create("Menu da Noite");

        menu.Add(menuItem);
        
        var menuItemInAggregate = menu.MenuItems.Single();
        
        Assert.Single(menu.MenuItems);
        Assert.Equal(itemName, menuItemInAggregate.Name);
        Assert.Equal(ingredients, menuItemInAggregate.Ingredients);
        Assert.Equal(price, menuItemInAggregate.Price);
        Assert.Equal(MenuItemType.Kitchen, menuItemInAggregate.Type);
        
        
        
    }
    
    [Fact]
    public void RemoveMenuItem_GivenAMenuToRemove_ShouldRemoveMenuItemFromMenu()
    {
        var itemName = "Abobora Frita";
        var ingredients = "abobora, alho, farinha, ovo";
        var price = Price.Create(5.00f, "EUR");
        
        var menuItem = MenuItem.Create(itemName, ingredients, price, MenuItemType.Kitchen);

        var menu = Menu.Create("Menu da Noite");

        menu.Add(menuItem);
        
        var menuItemInAggregate = menu.MenuItems.Single();
        
        Assert.Single(menu.MenuItems);
        Assert.Equal(itemName, menuItemInAggregate.Name);
        Assert.Equal(ingredients, menuItemInAggregate.Ingredients);
        Assert.Equal(price, menuItemInAggregate.Price);
        Assert.Equal(MenuItemType.Kitchen, menuItemInAggregate.Type);
        
        menu.Remove(menuItem.Id);
        
        Assert.Empty(menu.MenuItems);



    }
}