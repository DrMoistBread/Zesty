using Domain.Models;

namespace Domain.Menus.ValueObjects;

public class MenuItemId : ValueObject
{
    public Guid Id { get; set; }
    
    private MenuItemId(Guid id)
    {
        Id = id;
    }
    
    public static MenuItemId CreateUnique() => new MenuItemId(Guid.NewGuid());

    public static MenuItemId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}