using Domain.Common;
using Domain.Models;
using Domain.Tables.ValueObjects;

namespace Domain.Tables.Entities;

public class Bill : Entity<BillId>
{
    private Bill(BillId id, int number, DateTime date, Price totalAmount) : base(id)
    {
        Number = number;
        Date = date;
        TotalAmount = totalAmount;
    }

    public static Bill Create(int number, DateTime date, Price totalAmount)
    {
        return new Bill(BillId.CreateUnique(), number, date, totalAmount);
    }

    public int Number { get; private set; }
    public DateTime Date { get; private set; }
    public Price TotalAmount { get; private set; }
}