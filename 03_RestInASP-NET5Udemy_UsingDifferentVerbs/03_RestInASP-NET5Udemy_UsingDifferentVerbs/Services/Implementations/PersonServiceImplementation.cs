using _03_RestInASP_NET5Udemy_UsingDifferentVerbs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _03_RestInASP_NET5Udemy_UsingDifferentVerbs.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int _count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public IReadOnlyList<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            
            for (int i = 0; i < 8; i++)
            {
                persons.Add(MockPerson(i));
            }

            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Isaac",
                LastName = "Silva",
                Address = "Travessa da Alegria, 984 - Salvador/BA",
                Gender = "M"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = Interlocked.Increment(ref _count),
                FirstName = $"Person Name {i}",
                LastName = $"Person Last Name {i}",
                Address = $"Person Address {i}",
                Gender = "M"
            };
        }
    }
}
