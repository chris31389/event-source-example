using Tactical.DDD;

namespace People.Domain;

public sealed record PersonId : EntityId
{
    private Guid _guid;

    private PersonId(string guid) => 
        Guid.Parse(guid);

    public PersonId() =>
        _guid = Guid.NewGuid();

    // You might implement this static factory method in order to be able to
    // parse your id from string
    public static PersonId Parse(string id) => new(id);

    // ToString implementation
    public override string ToString() => _guid.ToString();
}