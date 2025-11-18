using Domain.Models;
using Domain.Tables.Entities;
using Domain.Tables.ValueObjects;

namespace Domain.Tables;

public class Table : AggregateRoot<TableId>
{
    protected Table(TableId id, int tableNumber, Bill bill) : base(id)
    {
        TableNumber = tableNumber;
        Bill = bill;
    }

    public static Table Create(int tableNumber, Bill bill)
    {
       return new Table(TableId.CreateUnique(), tableNumber, bill);
    }

    public int TableNumber { get; set; }
    public Bill Bill { get; set; }

    private readonly List<OrderItem> _orderItems = new List<OrderItem>();
    
    public List<OrderItem> OrderItems => _orderItems.ToList();

    public void AddOrderItem(OrderItem orderItem)
    {
        _orderItems.Add(orderItem);
    }

    public void RemoveOrderItem(OrderItem orderItem)
    {
        _orderItems.Remove(orderItem);
    }
}