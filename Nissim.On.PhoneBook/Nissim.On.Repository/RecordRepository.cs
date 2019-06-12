using Nissim.On.PhoneBook.DL;
using Nissim.On.Repository.IFC;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Nissim.On.Repository
{
    public class RecordRepository : Repository<Record>, IRecordRepository
    {
        #region Ctor
        public RecordRepository(PhoneBookDbContext context)
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

        #region GetAllRecords
        public async Task<List<Record>> GetAllRecordsAsync(string userName)
        {
            return await PhoneBookDbContext.Record
                    .Where(p => p.UserName == userName)
                    .ToListAsync();
        } 
        #endregion
    }
}
