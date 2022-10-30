using Tactical.DDD;

namespace People.Infrastructure;

public interface IEventStore
{
    Task SaveAsync(EntityId aggregateId, 
        int originatingVersion, 
        IReadOnlyCollection<DomainEvent> events,
        string aggregateName = "Aggregate Name");

    Task<IReadOnlyCollection<DomainEvent>> LoadAsync(EntityId aggregateRootId);
}