namespace Nissim.On.PhoneBook.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneBook_V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        user_name = c.String(nullable: false, maxLength: 30),
                        password = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.user_name);
            
            CreateTable(
                "dbo.Record",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_name = c.String(maxLength: 30),
                        first_name = c.String(maxLength: 30),
                        last_name = c.String(maxLength: 30),
                        phone_number = c.String(maxLength: 20),
                        address = c.String(maxLength: 50),
                        image = c.String(),
                        is_active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Person", t => t.user_name)
                .Index(t => t.user_name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Record", "user_name", "dbo.Person");
            DropIndex("dbo.Record", new[] { "user_name" });
            DropTable("dbo.Record");
            DropTable("dbo.Person");
        }
    }
}
