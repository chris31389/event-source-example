namespace People.Domain;

public interface IPersonRepository
{
    Task<PersonId> SavePersonAsync(Person person);
    Task<Person> GetPerson(string id);
}