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
                        person_id = c.Int(nullable: false, identity: true),
                        user_name = c.String(maxLength: 30),
                        password = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.person_id)
                .Index(t => t.person_id, unique: true);
            
            CreateTable(
                "dbo.Record",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        person_id = c.Int(nullable: false),
                        first_name = c.String(maxLength: 30),
                        last_name = c.String(maxLength: 30),
                        phone_number = c.String(maxLength: 20),
                        address = c.String(maxLength: 50),
                        image = c.String(),
                        is_active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Person", t => t.person_id, cascadeDelete: true)
                .Index(t => t.person_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Record", "person_id", "dbo.Person");
            DropIndex("dbo.Record", new[] { "person_id" });
            DropIndex("dbo.Person", new[] { "person_id" });
            DropTable("dbo.Record");
            DropTable("dbo.Person");
        }
    }
}
