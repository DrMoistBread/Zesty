namespace Domain.Models;

public abstract class Entity<TId> : IEquatable<Entity<TId>> where TId : notnull 
{
    public TId Id { get; protected set; }

    protected Entity(TId id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        return obj is Entity<TId> other && Id.Equals(other.Id);
    }
    

    public static bool operator ==(Entity<TId> a, Entity<TId> b)
    {
        return Equals(a, b);
    }

    public static bool operator !=(Entity<TId> a, Entity<TId> b)
    {
        return !Equals(a, b);
    }

    public bool Equals(Entity<TId>? other)
    {
        return Equals((object?)other);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
