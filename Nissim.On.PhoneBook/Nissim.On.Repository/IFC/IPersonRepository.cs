using Nissim.On.PhoneBook.DL;
using System.Threading.Tasks;

namespace Nissim.On.Repository.IFC
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetPersonAsync(string userName);
    }
}
