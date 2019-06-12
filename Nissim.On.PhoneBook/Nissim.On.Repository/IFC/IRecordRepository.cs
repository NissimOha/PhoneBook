using Nissim.On.PhoneBook.DL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nissim.On.Repository.IFC
{
    public interface IRecordRepository : IRepository<Record>
    {
        Task<List<Record>> GetAllRecordsAsync(string userName);
    }
}
