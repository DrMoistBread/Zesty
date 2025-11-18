using Domain.Common;
using Domain.Models;
using Domain.Table;

namespace Domain.Tables.Entities;

public class OrderItem : Entity<OrderItemId>
{
    public string Name { get; private set; }
    public Price Price { get; private set; }

    
    private OrderItem(OrderItemId id, string name, Price price) : base(id)
    {
        Name = name;
        Price = price;
    }

    public OrderItem Create(string name, Price price)
    {
        return new OrderItem(OrderItemId.CreateUnique(), name, price);
    }
}