using Domain.MenuAggregate;
using Xunit;

namespace Domain.Tests.MenusTests;


public class CreateMenuTest
{
    [Fact]
    public void CreateMenuMethod_GivenANewMenu_ShouldCreateANewMenu()
    {
        var menuName = "Menu Almoco";
        var menu = Menu.Create(menuName);
        
        Assert.Equal(menuName, menu.Name);
        Assert.Empty(menu.MenuItems);
    }
}