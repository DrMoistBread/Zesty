using Domain.Menus.Entities;
using Domain.Menus.ValueObjects;
using Domain.Models;

namespace Domain.MenuAggregate;

public class Menu :AggregateRoot<MenuId>
{
    private List<MenuItem> _menuItems = new();
    public string Name { get; }
    protected Menu(MenuId id, string name) : base(id)
    {
        Name = name;
    }

    public static Menu Create(string name)
    {
        
        return new Menu(MenuId.CreateUnique(),name );
    }

    public IReadOnlyList<MenuItem> MenuItems => _menuItems.ToList();

    public void Add(MenuItem menuItem)
    {
        _menuItems.Add(menuItem);
    }

    public void Remove(MenuItemId menuItemId)
    {
        var menuItem = _menuItems.FirstOrDefault(i => i.Id == menuItemId);
        if (menuItem is null)
            return;
        
        _menuItems.Remove(menuItem);
    }
    
    
}