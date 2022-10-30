using Tactical.DDD;

namespace People.Domain;

public sealed record FingerPrint : EntityId
{
    private Guid _guid;

    private FingerPrint(string guid) => 
        Guid.Parse(guid);

    public FingerPrint() =>
        _guid = Guid.NewGuid();

    // You might implement this static factory method in order to be able to
    // parse your id from string
    public static FingerPrint Parse(string id) => new(id);

    // ToString implementation
    public override string ToString() => _guid.ToString();
}