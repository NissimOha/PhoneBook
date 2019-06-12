using Nissim.On.PhoneBook.DL;
using Nissim.On.Repository.IFC;
using System;
using System.Threading.Tasks;

namespace Nissim.On.Repository.UnitOfWork
{
    public class PhoneBookUnitOfWork : IDisposable
    {
        private readonly PhoneBookDbContext _context;

        public PhoneBookUnitOfWork(PhoneBookDbContext context)
        {
            _context = context;
            Record = new RecordRepository(_context);
            Person = new PersonRepository(_context);
        }

        public IRecordRepository Record { get; private set; }
        public IPersonRepository Person { get; private set; }

        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
