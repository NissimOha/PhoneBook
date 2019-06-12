using Nissim.On.PhoneBook.DL;
using Nissim.On.Repository.IFC;
using System.Linq;
using System.Threading.Tasks;

namespace Nissim.On.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        #region Ctor
        public PersonRepository(PhoneBookDbContext context)
            : base(context)
        {
        }
        #endregion

        #region PhoneBookDbContext
        public PhoneBookDbContext PhoneBookDbContext
        {
            get { return Context as PhoneBookDbContext; }
        }
        #endregion

        #region GetPerson
        public async Task<Person> GetPersonAsync(string userName)
        {
            return await Task.Run(() =>
            {
                return PhoneBookDbContext.Person.SingleOrDefault
                        (p => p.UserName == userName);
            });
        } 
        #endregion
    }
}
