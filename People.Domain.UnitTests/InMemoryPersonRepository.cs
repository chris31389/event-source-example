using System.Collections.Generic;
using System.Threading.Tasks;
using Tactical.DDD;
using Xunit;

namespace People.Domain.UnitTests;

public class InMemoryPersonRepository : IPersonRepository
{
    private Dictionary<PersonId, IReadOnlyCollection<DomainEvent>> Events = 
        new Dictionary<PersonId, IReadOnlyCollection<DomainEvent>>();

    public Task<PersonId> SavePersonAsync(Person person)
    {
        Events[person.Id] = person.DomainEvents;
        return Task.FromResult(person.Id);
    }

    public Task<Person> GetPerson(string id)
    {
        https://itnext.io/implementing-event-store-in-c-8a27138cc90
        throw new System.NotImplementedException();
    }
}