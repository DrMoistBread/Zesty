using Domain.Models;

namespace Domain.Menus.ValueObjects;

public class MenuId : ValueObject
{
    public Guid Id { get; private set; }

    private MenuId(Guid id)
    {
        Id = id;
    }

    public static MenuId CreateUnique()
    {
        return new MenuId(Guid.NewGuid());
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}