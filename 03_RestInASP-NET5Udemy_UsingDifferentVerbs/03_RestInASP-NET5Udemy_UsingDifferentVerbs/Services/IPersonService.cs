using _03_RestInASP_NET5Udemy_UsingDifferentVerbs.Model;
using System.Collections.Generic;

namespace _03_RestInASP_NET5Udemy_UsingDifferentVerbs.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        IReadOnlyList<Person> FindAll();
        void Delete(long id);
        Person Update(Person person);

    }
}
