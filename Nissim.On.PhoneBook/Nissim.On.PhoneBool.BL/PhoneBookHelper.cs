using Nissim.On.PhoneBook.DL;
using Nissim.On.Repository.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nissim.On.PhoneBool.BL
{
    public static class PhoneBookHelper
    {
        public async static Task<bool> ValidateUserAsync(string userName, string password)
        {
            using(var uOw = new PhoneBookUnitOfWork(new PhoneBookDbContext()))
            {
                var user = await uOw.Person.GetPersonAsync(userName);
                return userName == user.UserName && password == user.Password;
            }
        }

        public async static Task AddUserAsync(Person person)
        {
            using (var uOw = new PhoneBookUnitOfWork(new PhoneBookDbContext()))
            {
                await uOw.Person.AddAsync(person);
            }
        }

        public async static Task<List<Record>> GetAllRecordsAsync(string userName)
        {
            using (var uOw = new PhoneBookUnitOfWork(new PhoneBookDbContext()))
            {
                return await uOw.Record.GetAllRecordsAsync(userName);
            }
        }
    }
}
