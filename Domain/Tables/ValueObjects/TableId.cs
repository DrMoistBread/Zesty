using Domain.Models;

namespace Domain.Tables.ValueObjects;

public class TableId : ValueObject
{
    public Guid Id { get; set; }

    private TableId(Guid id)
    {
        Id = id;
    }

    public static TableId CreateUnique()
    {
        return new TableId(Guid.NewGuid());  
    } 
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}