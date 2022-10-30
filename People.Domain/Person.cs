using Tactical.DDD;

namespace People.Domain;

public class Person : AggregateRoot<PersonId>
{
    public string? Name { get; set; }
    public FingerPrint FingerPrint { get; private set; }
}