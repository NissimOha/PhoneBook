namespace Nissim.On.PhoneBook.DL.Migrations
{
    using System;
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
            
        }
    }
}
