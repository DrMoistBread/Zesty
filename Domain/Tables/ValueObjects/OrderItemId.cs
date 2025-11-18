using Domain.Models;

namespace Domain.Table;

public class OrderItemId : ValueObject
{
    public Guid Id  { get; private set; }

    private OrderItemId(Guid id)
    {
        Id = id;
    }

    public static OrderItemId Create(Guid id)
    {
        return new OrderItemId(id);
    }

    public static OrderItemId CreateUnique()
    {
        return new OrderItemId(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}