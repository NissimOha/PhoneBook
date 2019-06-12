namespace Nissim.On.PhoneBook.DL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nissim.On.PhoneBook.DL.PhoneBookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Nissim.On.PhoneBook.DL.PhoneBookDbContext context)
        {
            var persons = new List<Person>()
            {
                new Person()
                {
                    UserName = "Nissim",
                    Password = "123456"
                },
                new Person()
                {
                    UserName = "Meir",
                    Password = "123456"
                }
            };

            var records = new List<Record>()
            {
                new Record()
                {
                    FirstName = "Nissim",
                    LastName = "Ohayon",
                    Address = "Harish",
                    PhoneNumber = "0545601901",
                    IsActive = true,
                    Image = string.Empty
                },
                new Record()
                {
                    FirstName = "Meir",
                    LastName = "Elisha",
                    Address = "Bat-Hefer",
                    PhoneNumber = "0528447284",
                    IsActive = true,
                    Image = string.Empty
                },
                new Record()
                {
                    FirstName = "Aviel",
                    LastName = "Bashari",
                    Address = "Natania",
                    PhoneNumber = "0523948721",
                    IsActive = true,
                    Image = string.Empty
                },
                new Record()
                {
                    FirstName = "Aviel",
                    LastName = "Bashari",
                    Address = "Natania",
                    PhoneNumber = "0523948721",
                    IsActive = false,
                    Image = string.Empty
                }
            };

            persons.ForEach(p => context.Person.AddOrUpdate(p));
            records.ForEach(r => context.Record.AddOrUpdate(r));

            context.SaveChanges();
        }
    }
}
