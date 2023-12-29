namespace Bookify.Domain.Abstractions;

public abstract class Entity
{
    private readonly List<IDomainEvent> domainEvents = new();

    protected Entity(Guid id)
    {
        this.Id = id;
    }

    public Guid Id { get; init; }
}
