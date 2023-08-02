using RestWithASPNETUdemy.Model;
using System.Security.Cryptography;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        List<Person> FindAll();
        Person FindById(long id);
        
        Person Update(Person person);
        void Delete(long id);
    }
}
