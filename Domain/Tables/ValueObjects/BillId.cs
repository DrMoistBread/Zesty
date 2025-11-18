using Domain.Models;

namespace Domain.Tables.ValueObjects;

public class BillId : ValueObject
{
    public Guid Id { get; set; }
    private BillId(Guid id)
    {
        Id = id;
    }

    public static BillId CreateUnique()
    {
        return new BillId(Guid.NewGuid());  
    } 
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}