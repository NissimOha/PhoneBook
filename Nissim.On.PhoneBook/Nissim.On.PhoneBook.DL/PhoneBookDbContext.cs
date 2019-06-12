namespace Nissim.On.PhoneBook.DL
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class PhoneBookDbContext : DbContext
    {
        public PhoneBookDbContext() : base("name=PhoneBookDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Record> Record { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(p => p.PersonId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Record>()
                .Property(r => r.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}