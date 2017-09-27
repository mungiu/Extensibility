using System.Collections.Generic;

namespace PersonRepository.Interface
{
    public interface IPersonRepository
    {
        //Interfaces can also be used as return type
        IEnumerable<Person> GetPeople();

        Person GetPerson(string lastName);

        void AddPerson(Person newPerson);

        void UpdatePerson(string lastName, Person updatedPerson);

        void DeletePerson(string lastName);

        void UpdatePeople(IEnumerable<Person> updatedPeople);
    }
}
